using MAUI_Cinemapark.Pages;

namespace MAUI_Cinemapark;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(CategoriesPage), typeof(CategoriesPage));
	}
}
