﻿using Microsoft.Extensions.Logging;
using ToDo_MauiApp.ViewModel;

namespace ToDo_MauiApp
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

            builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

            builder.Services.AddTransient<DetailPage>();
            builder.Services.AddTransient<DetailViewModel>();
#endif

            return builder.Build();
        }
    }
}
