using CRUDHikerAppXamarin.Services;
using CRUDHikerAppXamarin.ViewModels;
using Microsoft.Extensions.Logging;

namespace CRUDHikerAppXamarin
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
    		builder.Logging.AddDebug();
#endif 

            //register service
            //services
            builder.Services.AddSingleton<IHikeLogService, HikeLogService>();
            //views
            builder.Services.AddSingleton<HikeLogList>();
            builder.Services.AddTransient<AddHikeLog>();
            //View models
            builder.Services.AddSingleton<HikeLogViewModel>();
            builder.Services.AddTransient<AddHikeLogViewModel>(); 
             

            return builder.Build();
        }
    }
}
