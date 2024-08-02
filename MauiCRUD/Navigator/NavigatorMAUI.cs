using VisualBasicLib.Interfaces;

namespace MauiCRUD.Navigator;

public class NavigatorMAUI : INavigationManager
{
    public async void ShowPage(string pageName)
    {
        if (string.IsNullOrEmpty(pageName)) return;

        await Shell.Current.GoToAsync(pageName);
    }
}
