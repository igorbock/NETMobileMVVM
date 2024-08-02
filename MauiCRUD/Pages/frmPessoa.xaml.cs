using MauiCRUD.Navigator;
using VisualBasicLib.ViewModels;

namespace MauiCRUD.Pages;

public partial class frmPessoa : ContentPage
{
	public frmPessoa()
	{
        InitializeComponent();
		var navigationManager = new NavigatorMAUI();
		BindingContext = new PessoaViewModel(navigationManager);
	}
}