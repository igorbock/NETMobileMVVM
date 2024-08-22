using VisualBasicLib.Interfaces;

namespace MauiCRUD.Navigator;

public class NavigatorMAUI : INavigationManager
{
    public void CloseAllPages()
    {
        throw new NotImplementedException();
    }

    public void ClosePage()
    {
        throw new NotImplementedException();
    }

    public void ClosePage(string pageName)
    {
        throw new NotImplementedException();
    }

    public void ShowDialog(string pageName)
    {
        throw new NotImplementedException();
    }

    public async void ShowPage(string pageName)
    {
        if (string.IsNullOrEmpty(pageName)) return;

        await Shell.Current.GoToAsync(pageName);
    }
}
