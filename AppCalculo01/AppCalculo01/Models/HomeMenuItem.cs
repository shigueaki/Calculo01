using System;
using System.Collections.Generic;
using System.Text;

namespace AppCalculo01.Models
{
    public enum MenuItemType
    {
        PaginaInicial,

        //Números Reais
        ConjuntosNumericos,
        Desigualdades,
        ValorAbsoluto,
        Intervalos,

        //Funções
        DefinicaoDeFuncoes,
        ContraExemplos,
        Graficos,
        Operacoes,
        FuncoesEspeciais,
        FuncoesParesEImpares,
        FuncoesPeriodicas,
        FuncaoInversa,
        AlgumasFuncoesElementares,

        //Extras
        FuncaoConstante,
        FuncaoIdentidade,
        FuncaoModulo,
        FuncaoDePolinomios,
        DivisaoDePolinomios,

        //Limite e Continuidade
        NocaoIntuitiva,
        DefinicaoDeLimite,
        Proposicao,
        PropriedadesDosLimites,
        LimitesLaterais,
        CalculoDeLimites,
        LimitesNoInfinito
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }

        public string Icon { get; set; }
    }
}
