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
    public partial class GraficosConceito : ContentPage
    {
        public GraficosConceito()
        {
            InitializeComponent();
            DefinirLabels();
        }

        private void DefinirLabels()
        {
            string Texto = "  Seja f uma função. O gráfico de f é o conjunto de todos\n" +
                "os pontos (x, f(x)) de um plano coodenado, onde x pertence ao domínio de f." +
                "\n\n" +
                " Para determinar o gráfico de uma função, assinalamos uma série de pontos, fazendo\n" +
                "uma tabela que nos dá as coordenadas. No ponto em que estamos, não existe outro meio\n" +
                "de determinar o gráfico a não ser este método rudimentar.\n\n";

            lbldefinicao01.Text = Texto;

            Texto = "  (i) O gráfico da função f(x) = x² consiste em todos os pares (x, y) ∈ R² tais que y = x².\n" +
                "Em outras palavras, é a coleção de todos os pares (x, x²) do plano xy.\n\n";

            lblExemplo01.Text = Texto;

            //Imagen 01

            Texto = "  (ii) Consideremos a função f(x) = x. Os pontos de  seu gráfico são os pares (x, x) ∈ R².\n\n";

            lblExemplo02.Text = Texto;

            //Imagem 02

            Texto = "  (iii) Seja f: R → R definida por\n\n";

            lblExemplo03.Text = Texto;

            //Imagem 02 1
            //Imagem 03

            Texto = "  (iv) Seja f(x) = |x|. Quando x ≥ 0, sabemos que f(x) = x.\n" +
                "Quando x < 0, f(x) = -x.\n\n";

            lblExemplo04.Text = Texto;

            //imagem 04

            Texto = "  (v) Seja f(x) = 1/x. Então, D(f) = R - {0}\n\n";

            lblExemplo05.Text = Texto;

            //imagem 05

            Texto = "  (vi) Neste exemplo vamos ilustrar como os gráficos podem nos dar\n" +
                "informações importantes sobre situações práticas\n" +
                "  O gráfico a seguir representa a quantidade diária q de peças produzidas\n" +
                "numa ilha de montagem em função do número de operários n, que trabalham nessa linha.\n" +
                "O que concluir a partir da análise deste gráfico?\n\n";

            lblExemplo06.Text = Texto;

            //imagem 06

            Texto = "  Na figura a seguir representamos o mesmo gráfico onde assinalamos dois pontos importantes\n" +
                "para a análise. Podemos observar que entre 0 e n1 o acréscimo no número de operários acarretará\n" +
                "um acréscimo proporcional na produtividade.\n" +
                "Entre n1 e n2, o acréscimo da produtividade vai se tornando menos significativo,\n" +
                "sendo nulo no ponto n2.\n\n" +
                "  A partir de o acréscimo no número de operários implicará uma diminuição na produtividade.";

            lblExemplo07.Text = Texto;

            //imagem 07

            Texto = "  Podemos nos perguntar se, dada a  curva c no plano xy, ela sempre representa o gráfico\n" +
                "de uma função. A resposta é não. Sabemos que, se f é uma função, um ponto de seu domínio pode ter\n" +
                "somente uma imagem.Assim a curva c só representa o gráfico de uma função quando qualquer reta vertical\n" +
                "corta a curva no máximo em um ponto.\n" +
                "  Na figura a seguir a curva c1, representa o gráfico de uma função, enquanto a curva c2 não representa.\n\n";

            lblExemplo08.Text = Texto;

            //Imagem 08

        }
    }
}