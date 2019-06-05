using Microcharts;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCalculo01.Views.Funcoes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GraficosTeste : ContentPage
    {
        int FocoTxt = -1;
        public GraficosTeste()
        {
            InitializeComponent();
        }

        private void PreencherGraficoQuadratico(float A, float B, float C, float D)
        {
            List<Microcharts.Entry> grafico = new List<Microcharts.Entry>
            {
                new Microcharts.Entry(A)
                {
                    Color = SkiaSharp.SKColors.CornflowerBlue,
                    Label = "-100",
                    ValueLabel = "-100",
                },

                new Microcharts.Entry(B)
                {
                    Color = SkiaSharp.SKColors.CornflowerBlue,
                    Label = "-50",
                    ValueLabel = "-50"
                },

                new Microcharts.Entry(C)
                {
                    Color = SkiaSharp.SKColors.CornflowerBlue,
                    Label = "0",
                    ValueLabel = "0"
                },

                new Microcharts.Entry(D)
                {
                    Color = SkiaSharp.SKColors.CornflowerBlue,
                    Label = "50",
                    ValueLabel = "50"
                }
            };
            cvGrafico.Chart = null;
            cvGrafico.Chart = new LineChart { Entries = grafico };
        }

        private void PreencherGrafico(float A, float B, float C, float D, float E)
        {
            List<Microcharts.Entry> grafico = new List<Microcharts.Entry>
            {
                new Microcharts.Entry(A)
                {
                    Color = SkiaSharp.SKColors.CornflowerBlue,
                    Label = "-100",
                    ValueLabel = "-100",
                },

                new Microcharts.Entry(B)
                {
                    Color = SkiaSharp.SKColors.CornflowerBlue,
                    Label = "-50",
                    ValueLabel = "-50"
                },

                new Microcharts.Entry(C)
                {
                    Color = SkiaSharp.SKColors.CornflowerBlue,
                    Label = "0",
                    ValueLabel = "0"
                },

                new Microcharts.Entry(D)
                {
                    Color = SkiaSharp.SKColors.CornflowerBlue,
                    Label = "50",
                    ValueLabel = "50"
                },


                new Microcharts.Entry(E)
                {
                    Color = SkiaSharp.SKColors.CornflowerBlue,
                    Label = "100",
                    ValueLabel = "100"
                }
            };
            cvGrafico.Chart = null;
            cvGrafico.Chart = new LineChart { Entries = grafico };
        }

        private void TxtFuncao_Focused(object sender, FocusEventArgs e)
        {
            ExibirTeclado(true);
            FocoTxt = 0;
            txtFuncao.CursorPosition = txtFuncao.MaxLength;
        }

        private void KeyBoardButton_OnClicked(object sender, EventArgs e)
        {
            switch (FocoTxt)
            {
                case 0:
                    txtFuncao.Text += ((Button)sender).Text;
                    break;
                case 1:
                    txtB.Text += ((Button)sender).Text;
                    break;
                case 2:
                    txtC.Text += ((Button)sender).Text;
                    break;
            }
        }

        private void KeyBoardButtonClear_OnClicked(object sender, EventArgs e)
        {
            switch (FocoTxt)
            {
                case 0:
                    txtFuncao.Text = "";
                    break;
                case 1:
                    txtB.Text = "";
                    break;
                case 2:
                    txtC.Text = "";
                    break;
            }
        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            ExibirTeclado(false);
            if (ValidarValores(pckTipoFuncao.SelectedIndex))
                switch (pckTipoFuncao.SelectedIndex)
                {
                    case 0:
                        CalcularAfim();
                        break;

                    case 1:
                        CalcularQuadratica();
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    default:
                        break;
                }
        }

        private bool ValidarValores(int aTipoFuncao)
        {
            float A, B, C;
            switch (aTipoFuncao)
            {
                case 0:
                    if ((float.TryParse(txtFuncao.Text, out A)) && (float.TryParse(txtB.Text, out B)))
                    {
                        if (A == 0)
                        {
                            ShowMessage("Opa!", "O valor de ax não pode ser igual a 0.\n" +
                                "Observe que quando 0 é múltiplicado por x não é possível gerar uma imagem.");
                            return false;
                        }
                        else
                            return true;
                    }
                    else
                    {
                        ShowMessage("Opa!", "Por favor preencha os valores de ax e b.");
                        return false;
                    }

                case 1:
                    if ((float.TryParse(txtFuncao.Text, out A)) && (float.TryParse(txtB.Text, out B))
                        && (float.TryParse(txtC.Text, out B)))
                    {
                        if (A == 0)
                        {
                            ShowMessage("Opa!", "O valor de ax não pode ser igual a 0.\n" +
                                "Observe que quando 0 é múltiplicado por x não é possível gerar uma imagem.");
                            return false;
                        }
                        else
                            return true;
                    }
                    else
                    {
                        ShowMessage("Opa!", "Por favor preencha os valores de ax², b e c.");
                        return false;
                    }
            }
            return true;
        }

        private void CalcularAfim()
        {
            try
            {
                float A = float.Parse(txtFuncao.Text), B = float.Parse(txtB.Text);
                PreencherGrafico(A * -100 + B, A * -50 + B, A * 0 + B, A * 50 + B, A * 100 + B);
            }
            catch
            {
                ShowMessage("Eita!", "Houve um erro ao cálcular essa função,\n" +
                    "por favor reveja os valores e tente novamente");
            }

        }

        private void CalcularQuadratica()
        {
            try
            {
                double A = double.Parse(txtFuncao.Text), B = double.Parse(txtB.Text), C = double.Parse(txtC.Text);
                double Delta = Math.Pow(B, 2) - 4 * A * C;

                double X1 = (-B + Math.Sqrt(Delta)) / 2 * A;
                double X2 = (-B - Math.Sqrt(Delta)) / 2 * A;

                double Vx = -B / (2 * A);
                double Vy = -Delta / (4 * A);

                PreencherGraficoQuadratico(Convert.ToSingle(X1),
                    Convert.ToSingle(C),
                    Convert.ToSingle(Vy),
                    Convert.ToSingle(X2));

                lblResposta.Text = "Delta        = " + Delta.ToString("00.00") + "\n" +
                                   "X¹           = " + X1.ToString("00.00") + "\n" +
                                   "X²           = " + X2.ToString("00.00") + "\n" +
                                   "X do Vertice = " + Vx.ToString("00.00") + "\n" +
                                   "Y do Vertice = " + Vy.ToString("00.00") + "\n";
                lblResposta.IsVisible = true;
            }
            catch
            {
                ShowMessage("Eita!", "Houve um erro ao cálcular essa função,\n" +
                    "por favor reveja os valores e tente novamente");
            }
        }

        async void ShowMessage(string TipoMenssagem, string Mensagem)
        {
            await DisplayAlert(TipoMenssagem, Mensagem, "OK");
        }

        private void ExibirTeclado(bool Exibir)
        {
            CustomKeyBoardLayout.IsVisible = Exibir;
            cvGrafico.IsVisible = !Exibir;
            btnCalcular.IsVisible = !Exibir;
            lblResposta.IsVisible = !Exibir;
        }

        private void Limpar()
        {
            lblResposta.Text = "";
            cvGrafico.Chart = null;
            txtFuncao.Text = "";
            txtB.Text = "";
            txtC.Text = "";
        }

        private void KeyBoardButtonConfirmar_OnClicked(object sender, EventArgs e)
        {
            ExibirTeclado(false);
        }

        private void PckTipoFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Limpar();
            switch (pckTipoFuncao.SelectedIndex)
            {
                case 0:
                    lblA.Text = "ax=";
                    lblB.Text = "b=";
                    lblC.IsVisible = false;
                    txtC.IsVisible = false;
                    break;

                case 1:
                    lblA.Text = "ax²=";
                    lblB.Text = "b=";
                    lblC.IsVisible = true;
                    txtC.IsVisible = true;
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;
            }
        }

        private void TxtB_Focused(object sender, FocusEventArgs e)
        {
            ExibirTeclado(true);
            FocoTxt = 1;
            txtB.CursorPosition = txtB.MaxLength;
        }

        private void TxtC_Focused(object sender, FocusEventArgs e)
        {
            ExibirTeclado(true);
            FocoTxt = 2;
            txtC.CursorPosition = txtC.MaxLength;
        }
    }
}