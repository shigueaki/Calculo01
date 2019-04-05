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
	public partial class ValorAbsolutoTeste : ContentPage
	{
		public ValorAbsolutoTeste ()
		{
			InitializeComponent ();
		}

        async void ShowMessage(string TipoMenssagem, string Mensagem)
        {
            await DisplayAlert(TipoMenssagem, Mensagem, "OK");
        }

        private void KeyBoardButton_OnClicked(object sender, EventArgs e)
        {
            txtNumero.Text += ((Button)sender).Text;
        }

        private void KeyBoardButtonClear_OnClicked(object sender, EventArgs e)
        {
            txtNumero.Text = "";
        }

        private void TxtValor_Focused(object sender, FocusEventArgs e)
        {
            CustomKeyBoardLayout.IsVisible = true;
            txtNumero.CursorPosition = txtNumero.MaxLength;
        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            CustomKeyBoardLayout.IsVisible = false;
            if (double.TryParse(txtNumero.Text, out double ValorDouble) || int.TryParse(txtNumero.Text, out int ValorInt))
            {
                lblResultado.Text = "A diferença entre o valor " + txtNumero.Text +
                    " e o número 0 é: \n" + (Math.Abs(Convert.ToDouble(txtNumero.Text))).ToString();
            }
            else
            {
                ShowMessage("Erro", "Por favor digíte um número válido");
            }
        }

        private void TxtNumero_Focused(object sender, FocusEventArgs e)
        {
            CustomKeyBoardLayout.IsVisible = true;
        }
    }
}