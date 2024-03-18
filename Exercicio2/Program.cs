using System;
using System.Collections.Generic;
using Exercicio2.ItemMercado;

public class Program
{
    static void Main()
    {
        List<ItemMercado> listaItens = new List<ItemMercado>
    {
       new ItemMercado("Arroz", Tipos.Comida, 3.90),
       new ItemMercado("Azeite", Tipos.Comida, 2.50),
       new ItemMercado("Macarrão", Tipos.Comida, 3.90),
       new ItemMercado("Cerveja", Tipos.Bebida, 22.90),
       new ItemMercado("Refrigerante", Tipos.Bebida, 5.50),
       new ItemMercado("Shampoo", Tipos.Higiene, 7.00),
       new ItemMercado("Cotonete", Tipos.Higiene, 5.70),
       new ItemMercado("Sabão em Pó", Tipos.Limpeza, 8.20),
       new ItemMercado("Detergente", Tipos.Limpeza, 2.20),
       new ItemMercado("Amaciante", Tipos.Limpeza, 6.40)

    };
        var listaItensHigiene = from itemHigiene in listaItens
                                where itemHigiene.Tipo == Tipos.Higiene
                                orderby itemHigiene.Preco descending
                                select itemHigiene;

        var maiorIgualCinco = from itensMaiorIgualCinco in listaItens
                              where itensMaiorIgualCinco.Preco >= 5
                              orderby itensMaiorIgualCinco.Preco
                              select itensMaiorIgualCinco;

        var bebidaOrComida = from itensBebidaOrComida in listaItens
                             where itensBebidaOrComida.Tipo == Tipos.Comida || itensBebidaOrComida.Tipo == Tipos.Bebida
                             orderby itensBebidaOrComida.Nome
                             select itensBebidaOrComida;

        var quantidadePorTipo = from item in listaItens
                                group item by item.Tipo into grupo
                                select new
                                {
                                    Tipo = grupo.Key,
                                    Quantidade = grupo.Count()
                                };
        var estatisticasPorTipo = from item in listaItens
                                  group item by item.Tipo into grupo
                                  select new
                                  {
                                      Tipo = grupo.Key,
                                      PrecoMaximo = grupo.Max(item => item.Preco),
                                      PrecoMinimo = grupo.Min(item => item.Preco),
                                      PrecoMedio = grupo.Average(item => item.Preco)
                                  };
        foreach (var linq1 in listaItensHigiene)
        {
            Console.WriteLine($"Itens de higiene ordenados por preço: {linq1}");
        }
        foreach (var linq2 in maiorIgualCinco)
        {
            Console.WriteLine($"Lista de itens cujo preço seja maior ou igual a R$ 5,00 com ordenação feita por ordem crescente de preço: {linq2}");
        }
        foreach (var linq3 in bebidaOrComida)
        {
            Console.WriteLine($"Lista de itens cujo tipo seja Comida ou Bebida com ordenação feita por nome em ordem alfabética.: {linq3}");
        }
        foreach (var linq4 in quantidadePorTipo)
        {
            Console.WriteLine($"Tipos associado com a quantidade de itens de cada tipo: {linq4}");
            foreach (var estatistica in estatisticasPorTipo)
            {
                Console.WriteLine($"Tipo: {estatistica.Tipo}");
                Console.WriteLine($"Preço Máximo: {estatistica.PrecoMaximo}");
                Console.WriteLine($"Preço Mínimo: {estatistica.PrecoMinimo}");
                Console.WriteLine($"Preço Médio: {estatistica.PrecoMedio}");
                Console.WriteLine();
            }
        }

    }
}
