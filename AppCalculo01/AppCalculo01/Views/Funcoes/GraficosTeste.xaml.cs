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
        public GraficosTeste()
        {
            InitializeComponent();
            List<Microcharts.Entry> grafico = new List<Microcharts.Entry>
        {
            new Microcharts.Entry(-100)
            {
                Color = SkiaSharp.SKColors.CornflowerBlue,
                Label = "-100",
                ValueLabel = "-100",
            },

            new Microcharts.Entry(-50)
            {
                Color = SkiaSharp.SKColors.CornflowerBlue,
                Label = "-50",
                ValueLabel = "400"
            },

            new Microcharts.Entry(0)
            {
                Color = SkiaSharp.SKColors.CornflowerBlue,
                Label = "0",
                ValueLabel = "0"
            },

            new Microcharts.Entry(50)
            {
                Color = SkiaSharp.SKColors.CornflowerBlue,
                Label = "50",
                ValueLabel = "-500"
            },


            new Microcharts.Entry(-100)
            {
                Color = SkiaSharp.SKColors.CornflowerBlue,
                Label = "100",
                ValueLabel = "-100"
            }
        };
            cvGrafico.Chart = new LineChart { Entries = grafico};
        }

        private void TxtFuncao_Focused(object sender, FocusEventArgs e)
        {
            ExibirTeclado(true);
            txtFuncao.CursorPosition = txtFuncao.MaxLength;            
        }

        private void KeyBoardButton_OnClicked(object sender, EventArgs e)
        {
            txtFuncao.Text += ((Button)sender).Text;
        }

        private void KeyBoardButtonClear_OnClicked(object sender, EventArgs e)
        {
            txtFuncao.Text = "";
        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            ExibirTeclado(false);
        }

        private void TxtX_Focused(object sender, FocusEventArgs e)
        {
            ExibirTeclado(false);            
        }

        private void StpY_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            ExibirTeclado(false);
            lblY.Text = stpY.Value.ToString();
        }

        private void ExibirTeclado(bool Exibir)
        {
            CustomKeyBoardLayout.IsVisible = Exibir;            
            lblY.IsVisible = !Exibir;
            stpY.IsVisible = !Exibir;
            cvGrafico.IsVisible = !Exibir;
            btnCalcular.IsVisible = !Exibir;
            lblX.IsVisible = !Exibir;
            txtX.IsVisible = !Exibir;
        }

        private void KeyBoardButtonConfirmar_OnClicked(object sender, EventArgs e)
        {
            ExibirTeclado(false);
        }
    }
}