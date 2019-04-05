using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCalculo01.Views.NumerosReais
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ValorAbsolutoConceito : ContentPage
	{
		public ValorAbsolutoConceito ()
		{
			InitializeComponent ();

            PreencherLabels();
		}

        private void PreencherLabels()
        {
            string Texto;

            Texto = "O valor absoluto de um número é sua distância até 000. \n" +
                    "Por exemplo, o valor absoluto de 4 é 4: ";

            lblNotacao01.Text = Texto;

            //Imagem

            Texto = "Isso parece meio óbvio. É claro que a distância de 0 até 4 é. " +
                "A história dos valores absolutos fica interessante quando falamos de números negativos. \n" +
                    "Por exemplo, o valor absoluto de -4 também é 4: ";

            lblNotacao02.Text = Texto;
        }
    }
}