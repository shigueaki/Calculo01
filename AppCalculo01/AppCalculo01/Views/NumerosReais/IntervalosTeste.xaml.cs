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
	public partial class IntervalosTeste : ContentPage
	{
        int Digitando = 0;
		public IntervalosTeste ()
		{
			InitializeComponent ();
        }

        private void SwtFinal_Toggled(object sender, ToggledEventArgs e)
        {
            if (!swtFinal.IsToggled && !swtFechado.IsToggled)
            {
                txtNumeroFinal.IsEnabled = true;
                swtFechado.IsEnabled = true;
                txtNumeroFinal.Placeholder = "Número Final";
            }
            else
            {
                txtNumeroFinal.Text = "";
                txtNumeroFinal.IsEnabled = false;
                txtNumeroFinal.Placeholder = "Infinito";
                swtFechado.IsToggled = true;
                swtFechado.IsEnabled = false;
                swtInicial.IsToggled = false;
            }
        }

        private void SwtInicial_Toggled(object sender, ToggledEventArgs e)
        {
            if (!swtInicial.IsToggled)
            {
                txtNumeroInicial.IsEnabled = true;
                swtAberto.IsEnabled = true;
                txtNumeroInicial.Placeholder = "Número Inicial";                
            }
            else
            {
                txtNumeroInicial.Text = "";
                txtNumeroInicial.IsEnabled = false;
                txtNumeroInicial.Placeholder = "Infinito";
                swtAberto.IsToggled = true;
                swtAberto.IsEnabled = false;
                swtFinal.IsToggled = false;
            }
        }

        async void ShowMessage(string TipoMenssagem,string Mensagem)
        {
            await DisplayAlert(TipoMenssagem, Mensagem, "OK");
        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            string NumeroInicial = "", NumeroFinal = "", TipoEntrada = "", TipoSaida = "", ConjuntoNumerico = "R";

            CustomKeyBoardLayout.IsVisible = false;

            if (double.TryParse(txtNumeroInicial.Text, out double ValorInicial))
                NumeroInicial = ValorInicial.ToString();

            if (double.TryParse(txtNumeroFinal.Text, out double ValorFinal))
                NumeroFinal = ValorFinal.ToString();

            if (double.TryParse(txtNumeroInicial.Text, out double ValorA) &&
                double.TryParse(txtNumeroFinal.Text, out double ValorB))
            {
                if (ValorA > ValorB)
                {
                    ShowMessage("Erro","O valor inicial deve ser maior que o valor final");
                    lblResultado.Text = "";
                    imgResultado.Source = "";
                    return;
                }
                else
                {
                    imgResultado.Source = "IntervalosEx01.png";

                    NumeroInicial = txtNumeroInicial.Text;
                    NumeroFinal = txtNumeroFinal.Text;

                    if (ValorA >= 0 && ValorB >= 0)
                        ConjuntoNumerico = "N";
                    else if (int.TryParse(txtNumeroInicial.Text, out int IntA) &&
                        int.TryParse(txtNumeroFinal.Text, out int IntB))
                        ConjuntoNumerico = "I";
                    else
                        ConjuntoNumerico = "R";
                }
            }
            if (swtAberto.IsToggled)
            {
                TipoEntrada = "]";
                NumeroInicial = "A";
                imgResultado.Source = "IntervalosEx07.png";
            }
            else
                TipoEntrada = "[";

            if (swtFechado.IsToggled)
            {
                TipoSaida = "[";
                NumeroFinal = "B";
                imgResultado.Source = "IntervalosEx06.png";
            }
            else
                TipoSaida = "]";

            if (swtInicial.IsToggled)
                NumeroInicial = "-∞";

            if (swtFinal.IsToggled)
                NumeroFinal = "+∞";


            lblResultado.Text = "A={x ∈ " + ConjuntoNumerico + ":" +
                        NumeroInicial +
                        " < x < " + NumeroFinal +
                        "}=" + TipoEntrada + NumeroInicial + "," + NumeroFinal + TipoSaida;

            if (swtAberto.IsToggled && swtFechado.IsToggled)
                imgResultado.Source = "IntervalosEx01.png";

            /*if (swtInicial.IsToggled && swtInicial.IsToggled)
            {
                case 0: //Aberto                          
                    lblResultado.Text = "A={x ∈ R:" +
                        NumeroInicial +
                        " < x < " + NumeroFinal +
                        "}=]" + NumeroInicial + "," + NumeroFinal + "[";
                    break;

                case 1: //Fechado
                    lblResultado.Text = "A={x ∈ R:" +
                        txtNumeroInicial.Text +
                        " < x < " + txtNumeroFinal.Text +
                        "}=[" + NumeroInicial + "," + NumeroFinal + "]";
                    break;

                case 2: //Semi Aberto
                    if (NumeroFinal == "∞")
                    {
                        lblResultado.Text = "A={x ∈ R:" +
                        txtNumeroInicial.Text +
                        " < x < " + txtNumeroFinal.Text +
                        "}=[" + NumeroInicial + "," + NumeroFinal + "[";
                    }
                    break;
            }            */
        }

        private void TxtNumeroInicial_Focused(object sender, FocusEventArgs e)
        {
            CustomKeyBoardLayout.IsVisible = true;
            txtNumeroInicial.CursorPosition = txtNumeroInicial.MaxLength;
            Digitando = 0;
        }

        private void TxtNumeroFinal_Focused(object sender, FocusEventArgs e)
        {
            CustomKeyBoardLayout.IsVisible = true;
            txtNumeroFinal.CursorPosition = txtNumeroFinal.MaxLength;
            Digitando = 1;
        }

        private void KeyBoardButton_OnClicked(object sender, EventArgs e)
        {
            if (Digitando == 0)
                txtNumeroInicial.Text += ((Button)sender).Text;
            else
                txtNumeroFinal.Text += ((Button)sender).Text;
        }

        private void KeyBoardButtonClear_OnClicked(object sender, EventArgs e)
        {
            if (Digitando == 0)
                txtNumeroInicial.Text = "";
            else
                txtNumeroFinal.Text = "";
        }

        private void SwtAberto_Toggled(object sender, ToggledEventArgs e)
        {
            if (!swtAberto.IsToggled)
            {
                txtNumeroInicial.IsEnabled = true;
                txtNumeroInicial.Placeholder = "Número Inicial";
            }
            else
            {
                txtNumeroInicial.Text = "";
                txtNumeroInicial.IsEnabled = false;
            }
        }

        private void SwtFechado_Toggled(object sender, ToggledEventArgs e)
        {
            if (!swtFechado.IsToggled && !swtFinal.IsToggled)
            {
                txtNumeroFinal.IsEnabled = true;
                txtNumeroFinal.Placeholder = "Número Inicial";
            }
            else
            {
                txtNumeroFinal.Text = "";
                txtNumeroFinal.IsEnabled = false;
            }
        }
    }
}