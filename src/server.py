from flask import Flask
from flask import request
from logic import getNearbyPlaces



app = Flask(__name__)

@app.route('/backend', methods = ['POST'])
def foo():
    print(request.get_json())
    return {"myResponse":"Hello"}
    return {"myResponse": getNearbyPlaces()}
