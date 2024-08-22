using EntityFrameworkLib.Models;
using VisualBasicLib.Abstracts;
using VisualBasicLib.Interfaces;
using VisualBasicLib.ViewModels;

namespace MauiCRUD.Pages;

public partial class frmPessoa : ContentPage
{
	public frmPessoa(RepositoryAbstract<Pessoa> pessoaRepository, RepositoryAbstract<Endereco> enderecoRepository, INavigationManager navigator)
	{
        InitializeComponent();
		BindingContext = new PessoaViewModel(pessoaRepository, navigator, enderecoRepository);
	}
}