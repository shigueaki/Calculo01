using AppCalculo01.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCalculo01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.PaginaInicial, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.PaginaInicial:
                        MenuPages.Add(id, new NavigationPage(new MainPage()));
                        break;
                    case (int)MenuItemType.ConjuntosNumericos:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.NumerosReais.ConjuntosNumericos()));
                        break;
                    case (int)MenuItemType.Desigualdades:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.NumerosReais.Desigualdades()));
                        break;
                    case (int)MenuItemType.ValorAbsoluto:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.NumerosReais.ValorAbsoluto()));
                        break;
                    case (int)MenuItemType.Intervalos:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.NumerosReais.Intervalos()));
                        break;
                    case (int)MenuItemType.Funcoes:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.Funcoes.DefinicaoDeFuncoes()));
                        break;
                    case (int)MenuItemType.Graficos:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.Funcoes.Graficos()));
                        break;
                    case (int)MenuItemType.FuncoesEspeciais:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.Funcoes.FuncoesEspeciais()));
                        break;
                    case (int)MenuItemType.FuncoesParesEImpares:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.Funcoes.FuncoesParesEImpares()));
                        break;
                    case (int)MenuItemType.FuncoesPeriodicas:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.Funcoes.FuncoesPeriodicas()));
                        break;
                    case (int)MenuItemType.FuncaoInversa:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.Funcoes.FuncaoInversa()));
                        break;
                    case (int)MenuItemType.AlgumasFuncoesElementares:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.Funcoes.AlgumasFuncoesElementares()));
                        break;
                    case (int)MenuItemType.FuncaoConstante:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.Funcoes.Extras.FuncaoConstante()));
                        break;
                    case (int)MenuItemType.FuncaoIdentidade:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.Funcoes.Extras.FuncaoIdentidade()));
                        break;
                    case (int)MenuItemType.FuncaoModulo:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.Funcoes.Extras.FuncaoModulo()));
                        break;
                    case (int)MenuItemType.FuncaoDePolinomios:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.Funcoes.Extras.FuncaoDePolinomios()));
                        break;
                    case (int)MenuItemType.DivisaoDePolinomios:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.Funcoes.Extras.DivisaoDePolinomios()));
                        break;
                    case (int)MenuItemType.NocaoIntuitiva:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.LimiteEContinuidade.NocaoIntuitiva()));
                        break;
                    case (int)MenuItemType.DefinicaoDeLimite:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.LimiteEContinuidade.DefinicaoDeLimites()));
                        break;
                    case (int)MenuItemType.Proposicao:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.LimiteEContinuidade.Proposicao()));
                        break;
                    case (int)MenuItemType.PropriedadesDosLimites:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.LimiteEContinuidade.PropriedadeDosLimites()));
                        break;
                    case (int)MenuItemType.LimitesLaterais:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.LimiteEContinuidade.LimitesLaterais()));
                        break;
                    case (int)MenuItemType.CalculoDeLimites:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.LimiteEContinuidade.CalculoDeLimites()));
                        break;
                    case (int)MenuItemType.LimitesNoInfinito:
                        MenuPages.Add(id, new NavigationPage(new AppCalculo01.LimiteEContinuidade.LimitesNoInfinito()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}