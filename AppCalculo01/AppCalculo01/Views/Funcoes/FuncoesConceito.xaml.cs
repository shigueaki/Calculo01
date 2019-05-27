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
    public partial class DefinicaoDeFuncoesConceito : ContentPage
    {
        public DefinicaoDeFuncoesConceito()
        {
            InitializeComponent();
            DefinirLabels();
        }

        private void DefinirLabels()
        {
            string Texto;
            Texto = "  Sejam A e B subconjuntos de R. Uma função f: A → B é uma lei ou regra que" +
               " a cada elemento de A faz corresponder um único elemento de B. \n " +
               "  O conjunto A é chamado domínio de f e é denotado por D(f). \n" +
               "  B é chamado de contra-domínio ou campo de valores de f \n\n";               

            lbldefinicao01.Text = Texto;

            Texto = "  f: A → B \n" +
                "  x → f(x) \n" +
                "ou\n" +
                "  A → B\n" +
                "  x → y = f(x)\n";

            lblEscrevemos.Text = Texto;

            Texto = "Sejam A = {1, 2, 3, 4} e B = {2, 3, 4, 5}. \n" +
                "  (i) f: A → B dada pelo diagrama abaixo é uma função de A em B.\n\n";

            lblExemplo01.Text = Texto;

            //Imagem01

            Texto = "(ii) g: A → B \n" +
                "  x → x + 1\n" +
                "  é uma função de A em B. Podemos representar g em diagrama.\n\n";

            lblExemplo02.Text = Texto;

            //imagem02

            Texto = "Sejam A = {3, 4, 5} e B = {1, 2}.\n" +
                    "  (i) f: A → B dada pelo diagrama a seguir não é uma função de A em B, " +
                    "  pois o elemento 4 ∈ A tem dois correspondentes em B.\n\n";

            lblContraExemplos01.Text = Texto;

            //imagem03

            Texto = "  (ii) g: A → B\n" +
                    "  x → x - 3\n" +
                    "  não é uma função de A em B, pois o elemento 3 ∈ " +
                    "A não tem correspondente em B. Podemos ver isto facilmente " +
                    "representando g em diagrama\n\n";

            lblContraExemplos02.Text = Texto;
            //imagem04


            Texto = "  Seja f: A → B. \n" +
                "  (i) Dado x ∈ A, o elemento f(x) ∈ B é " +
                "chamado de valor da função f no ponto x ou de imagem x por f.\n" +
                "  (ii) O conjunto de todos os valores assumidos pela função é\n" +
                " chamado conjunto imagem de f e é denotado por Im(f)\n\n";

            lbldefinicao03.Text = Texto;

            Texto = "  Sejam A = {1, 2, 3, 4, 5} e B = Z (conjunto dos inteiros) e f: A → B\n" +
                "definida pela regra que a cada elemento de A faz corresponder o seu dobro.\n\n" +
                "  Então:\n" +
                "    - a regra que define f é y = 2x;\n" +
                "    - a imagem do elemento 1 é 2, de 2 é etc.;\n" +
                "    - o domínio de f, D(f) = A;\n" +
                "    - a imagem de f, Im(f) = [2, 4, 6, 8, 10].\n\n";

            lblExemplo03.Text = Texto;

            Texto = "  Seja f: R → R\n" +
                "    x → x²\n" +
                "  Então, D(f) = R," +
                "     Im(f) = [0, +∞). \n\n" +
                "  Quando trabalhamos com subconjuntos de R, é usual caracterizar a \n" +
                "função apenas pela fórmula ou regra que a define. Neste caso, entende-se\n" +
                " que o domínio de f é o conjunto de todos os números reais para os quais\n" +
                " a função está definida\n\n";

            lblExemplo04.Text = Texto;

            Texto = "  Determinar o domínio e a imagem das funções abaixo:\n" +
                "    (i) f(x) = 1/x.\n" +
                "  Esta função só não é definida para x = 0. Logo, D(f) = R - {0}.\n" +
                "    Im(f) = R - {0}\n" +
                "    (ii) f(x) = √x.\n" +
                "  Para x < 0, f(x) não está definida. Então, D(f) = [0, +∞) e Im(f) = [0, +∞).\n" +
                "    (iii) f(x) = -√x-1.\n" +
                "  f(x) não está definida para x < 1.D(f) = [1,∞) e Im(f) = (-∞,0].\n" +
                "    (iv) f(x) = |x|.\n" +
                "D(f) = R e Im(f) = [0, +∞).";

            lblExemplo05.Text = Texto;
        }
    }
}