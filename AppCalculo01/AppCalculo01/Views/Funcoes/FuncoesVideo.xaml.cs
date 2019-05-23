
using Android;
using Android.Webkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WebView = Xamarin.Forms.WebView;

namespace AppCalculo01.Views.Funcoes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DefinicaoDeFuncoesVideo : ContentPage
    {
        private const string V = "";

        public DefinicaoDeFuncoesVideo()
        {
            InitializeComponent();
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width=" + "\u0022" + 315 + "\u0022" + "height=" + 197  + " src=\"https://www.youtube.com/embed/hdMFlAv5GkU\" frameborder =\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>";
            navegador.Source = htmlSource;
        }

        private void BtnAssistirNoYoutube_Clicked(object sender, EventArgs e)
        {
            //var urlStore = Device.OnPlatform("iOS youtubelink", "Android youtubelink", "Windows youtube link");
            Device.OpenUri(new Uri("https://www.youtube.com/embed/hdMFlAv5GkU"));
        }
    }
}