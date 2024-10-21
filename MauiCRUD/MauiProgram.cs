using MauiCRUD.Pages;
using Microsoft.Extensions.Logging;
using DevExpress.Maui;
using DevExpress.Maui.Core;
using VisualBasicLib.Abstracts;
using EntityFrameworkLib.Models;
using VisualBasicLib.Interfaces;
using MauiCRUD.Navigator;
using MauiCRUD.Extensions;
using EntityFrameworkLib.Context;
using VisualBasicLib.Classes;

namespace MauiCRUD;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        ThemeManager.ApplyThemeToSystemBars = true;
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseDevExpress(false)
            .UseDevExpressCharts()
            .UseDevExpressCollectionView()
            .UseDevExpressControls()
            .UseDevExpressEditors()
            .UseDevExpressDataGrid()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif
        Routing.RegisterRoute("endereco", typeof(frmEndereco));
        builder.Services.AddScoped<INavigationManager, NavigatorMAUI>();

        builder.Services.AddNinjectModules([new NinjectDI()]);

        builder.Services.AddSingleton<frmPessoa>();

        return builder.Build();
    }
}
