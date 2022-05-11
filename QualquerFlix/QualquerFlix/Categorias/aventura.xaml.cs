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
    public partial class aventura : ContentPage
    {
        public aventura()
        {
            InitializeComponent();

            btnUncharted.Source = ImageSource.FromResource("QualquerFlix.Posters.uncharted_poster.jpg");
            btnDrEstranho.Source = ImageSource.FromResource("QualquerFlix.Posters.doutor_estranho_poster.jpg");
        }

        private async void btnDrEstranho_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.DrEstranho());
            }
            catch (Exception ex)
            {
                await DisplayAlert("eita", "deu merda bixo", "ta");
            }

        }

        private async void btnUncharted_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.uncharted());
            }
            catch (Exception ex)
            {
                await DisplayAlert("eita", "deu merda bixo", "ta");
            }

        }
    }
}