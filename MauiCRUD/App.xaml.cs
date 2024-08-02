using MauiCRUD.Pages;

namespace MauiCRUD;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new frmHome();
    }
}
