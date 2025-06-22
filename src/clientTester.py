import requests
import json
from dotenv import load_dotenv
from os import environ


load_dotenv()
def test():

    url = "http://127.0.0.1:5000/backend"
    headers = {
        "Content-Type": "application/json",
        "X-Goog-Api-Key": environ["USER_API_KEY"],  # Replace YOUR_API_KEY with your actual API key
        "X-Goog-FieldMask": "places.id,places.displayName,places.formattedAddress",
    }

    payload = {
        "people": ["Marko wants to eat sushi", "Shivam wants to eat fried chicken", "Jody wants to eat something healthy", "Jacky wants to eat steak and fries"]
    }

    response = requests.post(url, headers=headers, data=json.dumps(payload))

    if response.status_code == 200:
        
        result = response.text
        return result
        
    else:
        print(f"Error: {response.status_code}")
        print(response.text)

print(test())