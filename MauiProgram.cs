using Microsoft.Extensions.Logging;

namespace PriscilaZuniga_MauiApp2
{
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

#if DEBUG
    		//Llamada a metodos externos, inyecta codigo
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
