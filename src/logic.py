import requests
import json

from dotenv import load_dotenv
from os import environ
load_dotenv()


def getNearbyPlaces(lat = 43.51538583788745, long = -80.51351417895715, radius = 2000):

    url = "https://places.googleapis.com/v1/places:searchNearby"

    headers = {
        "Content-Type": "application/json",
        "X-Goog-Api-Key": environ["USER_API_KEY"],
        "X-Goog-FieldMask": "places.id,places.displayName,places.formattedAddress",
    }

    payload = {
        "includedTypes": ["restaurant"],
        "maxResultCount": 20,
        "locationRestriction": {
            "circle": {
                "center": {
                    "latitude":lat,
                    "longitude":long 
                },
                "radius": radius
            }
        }
    }

    response = requests.post(url, headers=headers, data=json.dumps(payload))

    if response.status_code == 200:
        
        result = response.json()
        return [{
            "id": place["id"],
            "address": place["formattedAddress"],
            "name" : place["displayName"]["text"]}
             for place in result["places"]]
        
    else:
        print(f"Error: {response.status_code}")
        print(response.text)

# nearby = getNearbyPlaces(43.51538583788745, -80.51351417895715, 2000)
# print([key["name"] for key in nearby])