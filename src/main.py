from google import genai

client = genai.Client(api_key="AIzaSyA141HUOTaDYWM4WTxGpSc6f7U21eIsQR8")

def getRecommendedRestaurants(peoplePreferences, numRestaurants):
    

    proompt = f"There are {len(peoplePreferences)} people who all want different things for dinner. Recommend {numRestaurants} restaurants that can satisfy as much of them as possible. The following are their wants: {peoplePreferences}."


    response = client.models.generate_content(
        model="gemini-2.5-flash", contents=proompt
    )
    print(response.text)

getRecommendedRestaurants(["Marko wants to eat sushi", "Shivam wants to eat fried chicken", "Jody wants to eat something healthy", "Jacky wants to eat steak and fries"], 5)