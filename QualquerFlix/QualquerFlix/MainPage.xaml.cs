using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QualquerFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void acao_clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Categorias.acao());
            }
            catch (Exception ex)
            {
                await DisplayAlert("opa", "deu merda bixo", "OK");
            }

        }

        private async void aventura_clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Categorias.aventura());
            }
            catch (Exception ex)
            {
                await DisplayAlert("opa", "deu merda bixo", "OK");
            }

        }
    }
}
