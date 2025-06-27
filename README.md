# Feel2Meal

Welcome to **Feel2Meal**! This project was built for SpurHacks 2025.

## About

Feel2Meal is an innovative application that connects people's individual preferences with restaurant recommendations, aiming to bring the best recommended restaurants based on what you, and your friends, feel like eating. Simply enter each user's meal preference in the application, select the price range for the restaurant, and press go. The application will do the rest and will output the top 5 most recommended restuarants within your area based on all users' preferences.

## How To Run

1. Clone this repository

2. Run the backend server backend with the command:

`flask --app src/server run`.

3. Using Visual Studio, build the .NET solution first and then run the frontend.

## Tech Stack Used

- **Frontend:** C# (Windows Forms App, .NET Framework, built in Visual Studio)
- **Backend:** Python (Flask micro web framework)
- **APIs:** Gemini API
- **Other:** Integration between C# frontend and Python backend via HTTP POST requests
