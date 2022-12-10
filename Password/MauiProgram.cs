namespace Password;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		Routing.RegisterRoute("success", typeof(SuccessPage));

		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}
