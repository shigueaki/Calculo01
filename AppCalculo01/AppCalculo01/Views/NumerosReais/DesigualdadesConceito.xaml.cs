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
    public partial class DesigualdadesConceito : ContentPage
    {
        public DesigualdadesConceito()
        {
            InitializeComponent();
            PreencherLabels();
        }

        private void PreencherLabels()
        {
            string Texto = "";
            Texto = "  Para podermos dizer que um número real é maior ou menor que outro, devemos introduzir o conceito" +
                "de número real positivo e uma relação de ordem\n\n";
            lbldefinicao01.Text = Texto;

            Texto = "  No conjunto de números reais existe um subconjunto denominado números positivos, tal que:\n" +
                "    (i) se a ∈ R, exatamente uma das três afirmações ocorre: a = 0; a é positivo; -a é positivo;\n" +
                "    (ii) a soma de dois números positivos é positiva;\n" +
                "    (iii) o produto de dois números positivos é positivo.";
            lbldefinicao02.Text = Texto;

            Texto = "  O número real a é negativo se e somente se -a é positivo.\n" +
                "  Os símbolos < (menor que) e > (maior que) são definidos:\n" +
                "    (i) a < b ↔ b - a é positivo;\n" +
                "    (ii) a > b ↔ a > b ou a = b.\n\n" +
                "  Os símbolos  ≤ (menor igual que) e ≥ (maior igual que) são definidos:\n" +
                "    (i) a ≤ b ↔ a < b ou a = b;\n" +
                "    (ii) a ≥ b ↔ a > b ou a = b.\n\n" +
                "  Expressões que envolvem os símbolos definidos acima são chamados de DESIGUALDADES. " +
                "a < b e a > b são desigualdades estritas, enquanto a ≤ b e a ≥ b são desigualdades não estritas.";
            lbldefinicao03.Text = Texto;

            Texto = "  Sejam a, b, c, d ∈ R\n" +
                "    (i) Se a > e b > c, então a > c.\n" +
                "    (ii) Se a > b e c > 0, então ac > bc.\n" +
                "    (iii) Se a > b e c < 0, então ac < bc.\n" +
                "    (iv) Se a > b, então a + c > b + c para todo real c.\n" +
                "    (v) Se a > b e c > d, então a + c > b + d.\n" +
                "    (vi) Se a > b > 0e c > d > 0, então ac > bd.\n\n" +
                "  As propriedades enunciadas podem ser facilmente provadas " +
                "usando-se as definições anteriores. Por exemplo:\n\n";
            lbldefinicao04.Text = Texto;

            Texto = "  (Se a > b e b > c, então a > c)\n" +
                "  Se a > b → (a - b) > 0.\n" +
                "  Se b > c → (b - c) > 0.\n" +
                "  Usando (ii) temos (a - b) + (b - c) > 0\n" +
                "    ou a - c > 0 → a > c.\n\n";
            lblexemplo01.Text = Texto;

            Texto = "(Se a > b e c > 0, então ac > bc.)\n" +
                "  Se a > b → (a - b) > 0.\n" +
                "  Usando (iii), temos (a - b) * c > 0 ou (ac - bc) > 0 e finalmente, pela definição, ac > bc.";
            lblexemplo02.Text = Texto;
        }
    }
}