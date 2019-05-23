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

            lbldefinicao.Text = Texto;

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
                    "representando g em diagrama";

            lblContraExemplos02.Text = Texto;
            //imagem04
        }
    }
}