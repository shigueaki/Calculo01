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
    public partial class DesigualdadesTeste : ContentPage
    {
        public DesigualdadesTeste()
        {
            InitializeComponent();
            pckTipo.Items.Clear();
            pckTipo.Items.Add("≤ e ≥");
            pckTipo.Items.Add("< e >");
            pckTipo.SelectedIndex = 0;
        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (txtA.Text == "" || txtB.Text == "")
                {
                    ShowMessage("Eita", "Faltou preencher algum campo, dá uma olhadinha nas duas caixas de texto por favor.");
                }
                else if(pckTipo.SelectedIndex < 0)
                {
                    ShowMessage("Hmmm...!", "Não se esqueça de escolher o tipo da desigualdade");
                }
                else
                {
                    string resposta = "", simboloMaior = "", simboloMenor = "", descricaoMaior = "", descricaoMenor = "";
                    if (pckTipo.SelectedIndex == 0)
                    {
                        resposta = "Desigualdade estrita onde:\n";
                        simboloMaior = "≥";
                        simboloMenor = "≤";
                        descricaoMaior = "maior ou igual que";
                        descricaoMenor = "menor ou igual que";
                    }
                    else if (pckTipo.SelectedIndex == 1)
                    {
                        resposta = "Desigualdade não estrita onde:\n";
                        simboloMaior = ">";
                        simboloMenor = "<";
                        descricaoMaior = "maior que";
                        descricaoMenor = "menor que";
                    }

                    if (Convert.ToDouble(txtA.Text) > Convert.ToDouble(txtB.Text))
                    {
                        resposta += "A é " + descricaoMaior +" B.\n Ou A " + simboloMaior + " B";
                    }
                    else if (Convert.ToDouble(txtA.Text) < Convert.ToDouble(txtB.Text))
                    {
                        resposta += "A é " + descricaoMenor + " B.\n Ou A " + simboloMenor + " B";
                    }
                    else if (Convert.ToDouble(txtA.Text) == Convert.ToDouble(txtB.Text))
                    {
                        resposta = "Os valores são iguais e portanto não há desigualdade";
                    }
                    lblResposta.Text = resposta;
                }
            }
            catch
            {
                ShowMessage("Aoba!", "Vamos aprender a cálcular esse trem que você digitou, mas por " +
                    "enquanto digite apenas números por favor.");
            }
        }

        async void ShowMessage(string TipoMenssagem, string Mensagem)
        {
            await DisplayAlert(TipoMenssagem, Mensagem, "OK");
        }
    }
}