using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCalculo01.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCalculo01.Views.NumerosReais.ConjuntosNumericos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConjuntosNumericosConceito01 : ContentPage
    {
		public ConjuntosNumericosConceito01 ()
		{
			InitializeComponent ();
            DefinirLabels();               
        }

        private void DefinirLabels()
        {
            string Texto;
             Texto = "Os" +
                " conjuntos numéricos reúnem diversos conjuntos " +
                "cujos elementos são números. Eles são formados " +
                "pelos números naturais, inteiros, racionais, " +
                "irracionais e reais. \n" +
                "Confira abaixo as características de cada " +
                "um deles tais como conceito, símbolo e subconjuntos.";

            lbldefinicao.Text = Texto;
            
            Texto = "O conjunto dos números naturais é representado por N. \n" +
                " Ele reúne os números que usamos para contar (incluindo o zero) e é infinito. \n \n" +
                "Subconjuntos dos Números Naturais \n \n" +
                "N* = {1, 2, 3, 4, 5..., n, ...} ou N* = N – {0}: \n" +
                "conjuntos dos números naturais não-nulos, ou seja, sem o zero. \n" +
                "Np = {0, 2, 4, 6, 8..., 2n, ...}, em que n ∈ N: conjunto dos números naturais pares. \n" +
                "Ni = {1, 3, 5, 7, 9..., 2n+1, ...}, em que n ∈ N: conjunto dos números naturais ímpares. \n" +
                "P = {2, 3, 5, 7, 11, 13, ...}: conjunto dos números naturais primos.";

            lblNumerosNaturais.Text = Texto;
            
            Texto = "O conjunto dos números inteiros é representado por Z. \n" +
                "Reúne todos os elementos dos números naturais (N) e seus opostos. \n" +
                " Assim, conclui-se que N é um subconjunto de Z (N ⊂ Z): \n \n" +
                "Subconjuntos dos Números Inteiros \n \n" +
                "Z* = {..., –4, –3, –2, –1, 1, 2, 3, 4, ...} \n" +
                "ou Z* = Z – {0}: conjuntos dos números inteiros não-nulos, ou seja, sem o zero. \n" +
                "Z+ = {0, 1, 2, 3, 4, 5, ...}: conjunto dos números inteiros e não-negativos. Note que Z+ = N. \n" +
                "Z*+ = {1, 2, 3, 4, 5, ...}: conjunto dos números inteiros positivos e sem o zero. \n" +
                "Z – = {..., –5, –4, –3, –2, –1, 0}: conjunto dos números inteiros não-positivos. \n" +
                "Z*– = {..., –5, –4, –3, –2, –1}: conjunto dos números inteiros negativos e sem o zero. \n";

            lblNumerosInteiros.Text = Texto;


            Texto = "O conjunto dos números racionais é representado por Q. \n " +
                    "Reúne todos os números que podem ser escritos na forma p/q, sendo p e q números inteiros e q≠0. \n" +
                    "Q = {0, ±1, ±1/2, ±1/3, ..., ±2, ±2/3, ±2/5, ..., ±3, ±3/2, ±3/4, ...} \n" +
                    "Note que todo número inteiro é também número racional. Assim, Z é um subconjunto de Q. \n \n" +
                    "Subconjuntos dos Números Racionais \n \n" +
                    "Q* = subconjunto dos números racionais não-nulos, formado pelos números racionais sem o zero. \n" +
                    "Q+ = subconjunto dos números racionais não-negativos, formado pelos números racionais positivos e o zero. \n" +
                    "Q*+ = subconjunto dos números racionais positivos, formado pelos números racionais positivos, sem o zero. \n" +
                    "Q– = subconjunto dos números racionais não-positivos, formado pelos números racionais negativos e o zero. \n" +
                    "Q*– = subconjunto dos números racionais negativos, formado números racionais negativos, sem o zero. \n";

            lblNumerosRacionais.Text = Texto;

            Texto = "O conjunto dos números irracionais é representado por I. Reúne os números decimais " +
                "não exatos com uma representação infinita e não periódica, por exemplo: 3,141592...ou 1,203040... \n" +
                "Importante ressaltar que as dízimas periódicas são números racionais e não irracionais." +
                "Elas são números decimais que se repetem após a vírgula, por exemplo: 1,3333333...";

            lblNumerosIrracionais.Text = Texto;

            Texto = "O conjunto dos números reais é representado por R. " +
                "Esse conjunto é formado pelos números racionais (Q) e irracionais (I)." +
                " Assim, temos que R = Q ∪ I. Além disso, N, Z, Q e I são subconjuntos de R. \n" +
                "Mas, observe que se um número real é racional, ele não pode ser também irracional.Da mesma maneira," +
                " se ele é irracional, não é racional. \n\n" +
                "Subconjuntos dos Números Reais \n\n" +
                "R *= { x ∈ R│x ≠ 0}: conjunto dos números reais não - nulos. \n" +
                "R + = { x ∈ R│x ≥ 0}: conjunto dos números reais não - negativos. \n" +
                "R * + = { x ∈ R│x > 0}: conjunto dos números reais positivos. \n" +
                "R– = { x ∈ R│x ≤ 0}: conjunto dos números reais não - positivos. \n" +
                "R *– = { x ∈ R│x \n";

            lblNumerosReais.Text = Texto;
        }

    }
}