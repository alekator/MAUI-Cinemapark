# MAUI Cinemapark 🎬

**MAUI Cinemapark** is an online cinema application built with .NET MAUI for cross-platform compatibility across Android, iOS, macOS, and Windows. This application utilizes the TMDB API to fetch an extensive online library of movies, with details on genres, categories, recommendations, trailers, and more.

## Features

- **Movie Database Integration**: Access a vast collection of movies fetched from TMDB API.
- **Cross-Platform**: Runs on Android, iOS, Windows, and macOS.
- **User-Friendly UI**: Built with MAUI for a consistent and responsive user interface across platforms.
- **Categories and Genres**: Browse through various genres and categories.
- **Movie Details**: View comprehensive details about movies, including cast, synopsis, release date, and more.
- **Recommendations**: Get movie recommendations based on similar movies.
- **Trailers**: Watch official trailers directly in the app.
- **Bookmarks**: Save favorite movies to a bookmarks list for easy access.
- **Search**: Quickly find movies by title, genre, or keyword.

## Technologies

- **.NET MAUI** - Cross-platform UI toolkit for building applications for Android, iOS, macOS, and Windows.
- **TMDB API** - For accessing an online library of movies, genres, trailers, and categories.
- **CommunityToolkit.Maui** - UI and MVVM toolkit enhancements for .NET MAUI.
- **Microsoft.Extensions** - Dependency injection, logging, and configuration.

## Setup

To set up the project on your local machine:

1. **Clone the repository**:
    ```bash
    git clone https://github.com/yourusername/MAUI_Cinemapark.git
    cd MAUI_Cinemapark
    Rebuild Solution 
    ```

2. **Install dependencies**:
   - Ensure you have [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) installed.
   - Install necessary tools and workloads for .NET MAUI by running:
     ```bash
     dotnet workload install maui
     ```

3. **TMDB API Key**:
   - Obtain an API key from [TMDB](https://www.themoviedb.org/documentation/api).
   - Set your API key in the application by adding it to your configuration file or directly in the code where API calls are made.

4. **Build and Run the Application**:
   - For Android:
     ```bash
     dotnet build -t:Run -f net8.0-android
     ```
   - For iOS (on macOS):
     ```bash
     dotnet build -t:Run -f net8.0-ios
     ```
   - For macOS:
     ```bash
     dotnet build -t:Run -f net8.0-maccatalyst
     ```
   - For Windows:
     ```bash
     dotnet build -t:Run -f net8.0-windows
     ```

## Usage

- **Home Page**: Displays a list of featured movies.
- **Categories Page**: Browse movies by categories such as action, comedy, drama, etc.
- **Movie Details Page**: Detailed view showing information about the selected movie, with options to view trailers and add to bookmarks.
- **Recommendations**: View recommended movies based on the selected movie.
- **Search**: Allows users to search for specific movies by title or category.
- **Bookmarks**: Save and access a list of bookmarked movies for easy reference.

## Screenshots
![4glKJc-Qjc4](https://github.com/user-attachments/assets/aecb700d-d428-4bca-bd37-b8cf12ca28f8)
![hCUYzcQUXmE](https://github.com/user-attachments/assets/1230d086-3aff-4e0a-9240-218ed3ad9704)


## License

[MIT License](https://licenses.nuget.org/MIT)

[Apache License 2.0](https://licenses.nuget.org/Apache-2.0)


---
