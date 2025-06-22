from flask import Flask
from flask import request
from logic import getNearbyPlaces
from gemini_advisor import getRecommendedRestaurants


app = Flask(__name__)

@app.route('/backend', methods = ['POST'])
def foo():

    ls = [request.get_json()["people"]]
    return {"myResponse": getRecommendedRestaurants(ls,5,getNearbyPlaces())}


