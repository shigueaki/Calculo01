using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCalculo01.Views.Funcoes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GraficosVideo : ContentPage
    {
        public GraficosVideo()
        {
            InitializeComponent();
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width=" + "\u0022" + 315 + "\u0022" + "height=" + 197 + " src=\"https://www.youtube.com/embed/xpv-SWbDUr8\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>";
            navegador.Source = htmlSource;            
        }

        private void BtnAssistirNoYoutube_Clicked(object sender, EventArgs e)
        {
            //var urlStore = Device.OnPlatform("iOS youtubelink", "Android youtubelink", "Windows youtube link");
            Device.OpenUri(new Uri("https://www.youtube.com/watch?v=xpv-SWbDUr8&t=1s"));
        }
    }
}