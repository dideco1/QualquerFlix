using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QualquerFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class acao : ContentPage
    {
        public acao()
        {
            InitializeComponent();

            btnBatman.Source = ImageSource.FromResource("QualquerFlix.Posters.batman_poster.jpg");
            btnMiranha.Source = ImageSource.FromResource("QualquerFlix.Posters.homemaranha.jpg");
            btnMorbius.Source = ImageSource.FromResource("QualquerFlix.Posters.morbius_poster.jpg");
        }

        private async void btnBatman_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.batman());
            }
            catch (Exception ex)
            {
                await DisplayAlert("eita", "deu merda bixo", "ta");
            }

        }

        private async void btnMiranha_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.miranha());
            }
            catch (Exception ex)
            {
                await DisplayAlert("eita", "deu merda bixo", "ta");
            }
        }

        private async void btnMorbius_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.morbius());
            }
            catch (Exception ex)
            {
                await DisplayAlert("eita", "deu merda bixo", "ta");
            }

        }
    }
}