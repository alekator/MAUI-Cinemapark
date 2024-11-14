﻿using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using MAUI_Cinemapark.Pages;
using MAUI_Cinemapark.Services;
using MAUI_Cinemapark.ViewModels;

namespace MAUI_Cinemapark;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");
				fonts.AddFont("Poppins-Semibold.ttf", "PoppinsSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddHttpClient(TmdbService.TmdbHttpClientName,
			httpClient => httpClient.BaseAddress = new Uri("https://api.themoviedb.org"));

		builder.Services.AddSingleton<TmdbService>();
		builder.Services.AddSingleton<HomeViewModel>();
		builder.Services.AddSingleton<MainPage>();

		builder.Services.AddSingleton<CategoriesViewModel>();
		builder.Services.AddSingleton<CategoriesPage>();

		builder.Services.AddTransientWithShellRoute<DetailsPage, DetailsViewModel>(nameof(DetailsPage));

		return builder.Build();
	}
}
