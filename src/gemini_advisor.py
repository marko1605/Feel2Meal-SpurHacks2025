from google import genai
from pydantic import BaseModel
import enum
from dotenv import load_dotenv
from os import environ


load_dotenv()


class Grade(enum.Enum):
    A_PLUS = "A+"
    A = "A"
    B = "B"
    C = "C"
    D = "D"
    F = "F"



class OutputFormat(BaseModel):
    restaurant_name:str
    rating:Grade
    reason:str

client = genai.Client(api_key=environ["USER_API_KEY"])

def getRecommendedRestaurants(peoplePreferences, numRestaurants, restaurantData):

    proompt = f"There are {len(peoplePreferences)} people who all want different things for dinner. Recommend {numRestaurants} restaurants that can satisfy all of their cravings at the same time, with a rating score and your reasoning. The following are their wants: {peoplePreferences}. The restaurants available are: {restaurantData}."

    response = client.models.generate_content(
        model="gemini-2.5-flash", 
        contents=proompt,
        config={
        'response_mime_type': 'application/json',
        'response_schema': list[OutputFormat],
    },
    )
    return [[r.restaurant_name, r.rating.value,r.reason] for r in response.parsed]
# result =getRecommendedRestaurants(["Marko wants to eat sushi", "Shivam wants to eat fried chicken", "Jody wants to eat something healthy", "Jacky wants to eat steak and fries"], 5, ['Browns Socialhouse Waterloo', "McDonald's", 'The Keg Steakhouse + Bar - Waterloo', 'Grey Silo Golf Course', 'Tim Hortons', 'Pho Ben Thanh Restaurant', 'St. Louis Bar & Grill', 'Levetto Waterloo', 'Sushi 99', "Domino's Pizza", 'KENZO RAMEN WATERLOO', 'Red Swan Pizza - Waterloo (E) Northfield Dr', "Tahini's", 'Burger King', 'Daily Grill Restaurant', 'Pita Pit', 'Subway', 'Chopped Leaf', 'Davenport Pizza', "Sandy's Kitchen Chinese Cuisine"])

    # return [{"name" : r.restaurant_name,
    #     "rating": r.rating.value,
    #     "reason": r.reason
    # } for r in response.parsed]