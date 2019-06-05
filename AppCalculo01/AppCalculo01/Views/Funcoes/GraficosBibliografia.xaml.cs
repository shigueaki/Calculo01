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
    public partial class GraficosBibliografia : ContentPage
    {
        public GraficosBibliografia()
        {
            InitializeComponent();
            lblVideo.Text = "descomplica. O QUE SÃO FUNÇÕES MATEMÁTICAS? | QUER QUE DESENHE? | DESCOMPLICA. 2018. (6m08s). Disponível em: <" + "https://www.youtube.com/watch?v=xpv-SWbDUr8&t=2s" + ">. Acesso em: 05 jun. 2019.";
        }
    }
}