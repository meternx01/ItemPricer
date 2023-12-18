using ItemPricer.Services;
using Microsoft.Extensions.Logging;

namespace ItemPricer;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		//create a connection to a local mysql database
		string dbPath = FileAccessHelper.GetLocalFilePath("ItemPricer.db");	
		/*string dbPath = FileAccessHelper.GetLocalFilePath("Vendorprices.sqlite");*/

		builder.Services.AddSingleton<ItemRepository>( s=> ActivatorUtilities.CreateInstance<ItemRepository>(s,dbPath));

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
