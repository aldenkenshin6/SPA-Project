using Microsoft.Extensions.Logging;
using Microsoft.Maui.Hosting;
using Microsoft.Maui;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SPA1.Data;
using SPA1.Services;

namespace SPA1
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
                });

            //// connection String
            var connectionString = "Server=DENSHIN\\SQLEXPRESS; Database=spa; Trusted_Connection=True; TrustServerCertificate=True;";

            //// builder and services
            builder.Services.AddDbContext<SpaContext>(options => options.UseSqlServer(connectionString));

            // will remember the user during session
            builder.Services.AddScoped<UserSession>();

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }



    }
}
