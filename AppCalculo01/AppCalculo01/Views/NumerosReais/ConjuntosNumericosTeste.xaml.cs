using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCalculo01.Views.NumerosReais.ConjuntosNumericos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConjuntosNumericosTeste : ContentPage
	{
		public ConjuntosNumericosTeste()
		{
			InitializeComponent ();
		}

        private void KeyBoardButton_OnClicked(object sender, EventArgs e)
        {
            txtValor.Text += ((Button)sender).Text;
        }

        private void KeyBoardButtonClear_OnClicked(object sender, EventArgs e)            
        {
            txtValor.Text = "";    
        }

        private void ValidarTeste(object sender, EventArgs args)
        {
            CustomKeyBoardLayout.IsVisible = false;
            float Valor;
            int ValorInteiro;
            if (float.TryParse(txtValor.Text, out Valor))
            {
                string Reposta = "";
                if (int.TryParse(txtValor.Text, out ValorInteiro))
                {
                    if (ValorInteiro > 0)
                        Reposta = "Naturais não nulos";
                    else if (ValorInteiro < 0)
                        Reposta = "Inteiros";
                    else
                        Reposta = "Naturais";
                }
                else
                {
                    Reposta = "Racionais";
                }

                lblResultado.Text = "O valor digitado perntence aos conjuntos de números: \n" + Reposta;
            }
            else
            {
                lblResultado.Text = "";
                DisplayAlert("Erro", "O texto pode conter apenas números, ''.'' e ''-''", "OK");
            }
        }

        private void TxtValor_Focused(object sender, FocusEventArgs e)
        {
            CustomKeyBoardLayout.IsVisible = true;
            txtValor.CursorPosition = txtValor.MaxLength;
        }
    }
}