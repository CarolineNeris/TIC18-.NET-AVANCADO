using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        List<int> numerosInteiros = new List<int> { 3, 7, 2, 4, 6 };
        List<double> numerosDouble = numerosInteiros.ConvertAll(x => (double)x / 2);
        foreach (double numeros in numerosDouble)
        {
            Console.WriteLine(numeros);
        }

    }
}