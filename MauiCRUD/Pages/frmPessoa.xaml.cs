using EntityFrameworkLib.Models;
using VisualBasicLib.Abstracts;
using VisualBasicLib.Interfaces;
using VisualBasicLib.ViewModels;

namespace MauiCRUD.Pages;

public partial class frmPessoa : ContentPage
{
	public frmPessoa(TypeTViewModel<Pessoa> viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}