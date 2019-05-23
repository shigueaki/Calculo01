using AppCalculo01.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCalculo01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.PaginaInicial, Title="Página Inicial", Icon="fas-home" },
                new HomeMenuItem {Id = MenuItemType.ConjuntosNumericos, Title="Conjuntos Númericos", Icon="fas-sort-numeric-up" },
                new HomeMenuItem {Id = MenuItemType.Desigualdades, Title="Desigualdades", Icon="fas-not-equal" },
                new HomeMenuItem {Id = MenuItemType.ValorAbsoluto, Title="Valor Absoluto", Icon="fas-bullseye" },
                new HomeMenuItem {Id = MenuItemType.Intervalos, Title="Intervalos", Icon="fas-infinity" },
                new HomeMenuItem {Id = MenuItemType.Funcoes, Title="Funções", Icon="fas-chart-line" },
                new HomeMenuItem {Id = MenuItemType.Graficos, Title="Gráficos", Icon="fas-chart-bar" },
                new HomeMenuItem {Id = MenuItemType.FuncoesEspeciais, Title="Funções Especiais", Icon="fas-home" },
                new HomeMenuItem {Id = MenuItemType.FuncoesParesEImpares, Title="Funções Pares e Ímpares", Icon="fas-home" },
                new HomeMenuItem {Id = MenuItemType.FuncoesPeriodicas, Title="Funcções Periódicas", Icon="fas-home" },
                new HomeMenuItem {Id = MenuItemType.FuncaoInversa, Title="Função Inversa", Icon="fas-home" },
                new HomeMenuItem {Id = MenuItemType.AlgumasFuncoesElementares, Title="Algumas Funções Elementares", Icon="fas-home" },
                new HomeMenuItem {Id = MenuItemType.FuncaoConstante, Title="Função Constante", Icon="fas-home" },
                new HomeMenuItem {Id = MenuItemType.FuncaoIdentidade, Title="Função Identidade", Icon="fas-home" },
                new HomeMenuItem {Id = MenuItemType.FuncaoDePolinomios, Title="Função de Polinômios", Icon="fas-home" },
                new HomeMenuItem {Id = MenuItemType.DivisaoDePolinomios, Title="Divisão de Polinômios", Icon="fas-home" },
                new HomeMenuItem {Id = MenuItemType.NocaoIntuitiva, Title="Noção Intuitiva", Icon="fas-home" },
                new HomeMenuItem {Id = MenuItemType.DefinicaoDeLimite, Title="Definição de Limites", Icon="fas-home" },
                new HomeMenuItem {Id = MenuItemType.Proposicao, Title="Proposição (Unicidade do Limite)", Icon="fas-home" },
                new HomeMenuItem {Id = MenuItemType.PropriedadesDosLimites, Title="Propriedades dos Limites", Icon="fas-home"},
                new HomeMenuItem {Id = MenuItemType.LimitesLaterais, Title="Limites Laterais", Icon="fas-home" },
                new HomeMenuItem {Id = MenuItemType.CalculoDeLimites, Title="Cálculo de Limites", Icon="fas-home" },
                new HomeMenuItem {Id = MenuItemType.LimitesNoInfinito, Title="Limites no Infinito", Icon="fas-home" }                            
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}