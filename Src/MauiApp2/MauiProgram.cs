namespace MauiApp2;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				//fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				//fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("AtypDisplay-Bold.ttf", "AtypDisplayBold");
				fonts.AddFont("AtypDisplay-Regular.ttf", "AtypDisplayRegular");
            });

		builder.Services.AddSingleton<MainPage>();

		return builder.Build();
	}
}
