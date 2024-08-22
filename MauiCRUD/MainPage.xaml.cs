using EntityFrameworkLib.Models;
using VisualBasicLib.Abstracts;
using VisualBasicLib.Interfaces;
using VisualBasicLib.ViewModels;

namespace MauiCRUD
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(RepositoryAbstract<Pessoa> pessoaRepository, RepositoryAbstract<Endereco> enderecoRepository, INavigationManager navigator)
        {
            InitializeComponent();
            BindingContext = new PessoaViewModel(pessoaRepository, navigator, enderecoRepository);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
