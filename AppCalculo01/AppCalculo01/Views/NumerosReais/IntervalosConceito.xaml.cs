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
	public partial class IntervalosConceito : ContentPage
	{
		public IntervalosConceito ()
		{
			InitializeComponent ();
            DefinirLabels();
		}

        private void DefinirLabels()
        {
            string Texto;

            Texto = "Em matemática, podemos representar conjuntos, subconjuntos e soluções de equações pela notação de intervalo. \n" +
                " Intervalo significa que o conjunto possui cada número real entre dois extremos indicados, " +
                "seja numericamente ou geometricamente. Não é possível representar subconjuntos ou conjuntos que não sejam reais " +
                "(ou contidos nos reais) pela notação de intervalo. \n\n" +
                "Vamos, por exemplo, dizer que o conjunto A é um subconjunto dos números naturais e que será representado por:";

            lbldefinicao.Text = Texto;

            Texto = "A={x∈N:1<x<2}";

            lblExemplo01.Text = Texto;

            Texto = "Note que qualquer elemento de A pertence ao conjunto dos naturais," +
                " porém é um absurdo dizer que nos naturais existem números entre 1 e 2, ou seja," +
                " em N não existe o número 1,5 , por exemplo. Então, neste caso, dizemos que o conjunto " +
                "A é vazio. E será representado por:";

            lblNotacao01.Text = Texto;

            Texto = "A=Ø";

            lblExemplo02.Text = Texto;          

            Texto = "Logo não é correto dizer que A = ]1,2[. A não é um subconjunto dos números reais," +
                " então nem todos os números possíveis estão no intervalo quaisquer números naturais, " +
                "ou inteiros ou racionais." +
                "Mas, se A fosse um subconjunto dos reais, poderíamos dizer que:";

            lblNotacao02.Text = Texto;

            Texto = "A={x ∈ R: 1 < x < 2}=]1,2[";

            lblExemplo03.Text = Texto;

            Texto = "O que geometricamente representamos:";

            lblNotacao03.Text = Texto;

            Texto = "1. Dizemos que um intervalo é aberto quando seus extremos não estão incluídos. Exemplo:";

            lblNotacao04.Text = Texto;

            Texto = "]a,b[={x ∈ R: a < x < b}";

            lblExemplo04.Text = Texto;

            Texto = "Geometricamente representamos por uma bolinha branca indicando o elemento não incluído:";

            lblNotacao05.Text = Texto;

            Texto = "O intervalo também é aberto quando indicamos apenas um dos extremos e o outro pode ser " +
                    "uma infinidade de elementos à direita (+∞) ou à esquerda (−∞). Ou seja:";

            lblNotacao06.Text = Texto;

            Texto = "]a,+∞[={x ∈ R: x > a}";

            lblExemplo05.Text = Texto;

            Texto = "]−∞,a[={x ∈ R:x < a}";

            lblExemplo06.Text = Texto;

            Texto = "Toda ocasião em que um extremo for uma infinidade de elementos, este sempre será um extremo aberto. \n" +
                    "2.Um intervalo fechado é aquele em que seus extremos são incluídos:";

            lblNotacao07.Text = Texto;

            Texto = "[a,b]={x∈R:a ≤ x ≤ b}";

            lblExemplo07.Text = Texto;

            Texto = "Na reta, o elemento incluído será uma bolinha preta:";

            lblNotacao08.Text = Texto;

            //imagem

            Texto = "3. Dizemos que um intervalo é semiaberto ou semifechado quando " +
                    "um de seus extremos são incluídos, ou seja:";

            lblNotacao09.Text = Texto;

            Texto = "[a,b[={x∈R: a ≤ x < b}";

            lblExemplo08.Text = Texto;

            //imagem

            Texto = "]a,b]={x∈R: a < x ≤ b}";

            lblExemplo09.Text = Texto;

            //imagem

            Texto = "E também com extremos ao infinito:";

            lblNotacao10.Text = Texto;

            Texto = "[a,+∞[={ x ∈ R: x ≥ a}";

            lblExemplo10.Text = Texto;

            //imagem

            Texto = "]−∞,a]={x∈R:x≤a}";

            lblExemplo11.Text = Texto;

            //imagem

            Texto = "Podemos também assumir que, se um intervalo é um subconjunto dos números reais," +
                " é possível realizar algumas operações entre intervalos, tais como união e interseção de intervalos." +
                " Supondo que tenhamos dois intervalos: [a, b] e [c, d] e que d > c > b > a. \n" +
                    "A união dos intervalos será dada por: ";

            lblNotacao11.Text = Texto;

            Texto = "[a, b]∪[c, d]={x∈R:a ≤ x ≤ b ou c ≤ x ≤ d";

            lblExemplo12.Text = Texto;

            Texto = "E geometricamente representamos:";

            lblNotacaoExtra.Text = Texto;

            //imagem

            Texto = "E a sua interseção é vazia, pois não existem elementos comuns em ambos os intervalos:";

            lblNotacao12.Text = Texto;

            Texto = "[a,b]∩[c,d]=∅";

            lblExemplo13.Text = Texto;

            Texto = "Vamos tomar um exemplo com valores. Supondo os intervalos [1,5] e [2,7]. A sua união será:";

            lblNotacao13.Text = Texto;

            Texto = "[1,5]∪[2,7]=[1,7]={x ∈ R: 1 ≤ x ≤ 7}";

            lblExemplo14.Text = Texto;

            Texto = "Se representarmos na reta, vemos que seus elementos estão ligados linearmente:";

            lblNotacao14.Text = Texto;

            //Imagem

            Texto = "Então a sua união será a “soma” de todos os elementos de seus intervalos, " +
                "resultando em um intervalo único de 1 a 7. Porém, a sua interseção será dada por:";

            lblNotacao15.Text = Texto;

            Texto = "[1,5]∩[2,7]=[2,5]={x ∈ R: 2 ≤ x ≤ 5}";

            lblExemplo15.Text = Texto;

            Texto = "Geometricamente vemos que existe um intervalo entre eles que é composto pelos " +
                    "elementos que são comuns em ambos, no caso, o intervalo [2,5], veja:";

            lblNotacao16.Text = Texto;
            //Imagem

            Texto = "Concluindo: Intervalos serão sempre subconjuntos dos números reais, " +
                "o que nos garante a validade de todas as propriedades e operações da teoria dos conjuntos." +
                " A representação geométrica de um intervalo é muito importante pois podemos observar " +
                "o comportamento dos intervalos, " +
                "facilitando a sua classificação e as suas possíveis operações.";

            lblNotacao17.Text = Texto;
        }
    }
}