﻿using CommunityToolkit.Mvvm.ComponentModel;
using MAUI_Cinemapark.Services;
using System.Collections.ObjectModel;

namespace MAUI_Cinemapark.ViewModels
{
    public partial class CategoriesViewModel : ObservableObject
    {
        private readonly TmdbService _tmdbService;

        private IEnumerable<Genre> _genreList;

        public CategoriesViewModel(TmdbService tmdbService)
        {
            _tmdbService = tmdbService;
        }
        public ObservableCollection<string> Categories { get; set; } = new();

        public async Task InitializeAsync()
        {
            _genreList ??= await _tmdbService.GetGenresAsync();

            Categories.Clear();
            Categories.Add("My List");
            Categories.Add("Downloads");

            foreach (var genre in _genreList)
            {
                Categories.Add(genre.Name);
            }
        }
    }
}
