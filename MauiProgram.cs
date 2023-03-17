using Microsoft.Extensions.Logging;
using CBB_Elo_Ratings.Data;

namespace CBB_Elo_Ratings;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<Data.DataContext>();
		builder.Services.AddSingleton<Data.GamesService>();
		builder.Services.AddSingleton<Data.TeamsService>();
		builder.Services.AddSingleton<Data.PlayerService>();

		return builder.Build();
	}
}

