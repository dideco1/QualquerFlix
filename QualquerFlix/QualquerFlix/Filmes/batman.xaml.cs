using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QualquerFlix.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class batman : ContentPage
    {
        public batman()
        {
            InitializeComponent();
            var htmlsource = new HtmlWebViewSource();
            htmlsource.Html = @"<iframe width= '400' height= '300'
                                src= 'https://www.youtube.com/watch?v=rsQEor4y2hg'
                                frameborder= '0' allow= 'accelerometer; autoplay; encrypted-media;
                                gyroscope; picture-in-picture' allowfullscreen 
                                </iframe>";
            visualizador.Source = htmlsource;
            poster.Source = ImageSource.FromResource("QualquerFlix.Posters.batman_poster.jpg");
        }
    }
}