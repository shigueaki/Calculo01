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
    public partial class DefinicaoDeFuncoesBibliografia : ContentPage
    {
        public DefinicaoDeFuncoesBibliografia()
        {
            InitializeComponent();
            lblVideo.Text = "Feretto Matematica. Função do Primeiro Grau (Função Afim): Conceitos Iniciais (Aula 1 de 9). 2014. (12m49s). Disponível em: <" + "https://www.youtube.com/watch?v=hdMFlAv5GkU&feature=youtu.be" + ">. Acesso em: 05 jun. 2019.";
        }
    }
}