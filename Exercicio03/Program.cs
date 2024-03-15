using System;

enum Exercicio
{
    Funcional = 1,
    Cardio = 2,
    Musculacao = 3,
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine(" exercícios:");
            foreach (Exercicio exercicio in Enum.GetValues(typeof(Exercicio)))
            {
                Console.WriteLine($"Nome: {exercicio}, Valor: {(int)exercicio}");
            }

            Console.WriteLine("Escolha um exercicio pelo numero:");
            int input = int.Parse(Console.ReadLine());

            if (Enum.IsDefined(typeof(Exercicio), input))
            {
                Exercicio exercicioEscolhido = (Exercicio)input;
                Console.WriteLine($"Exercicio escolhidoo: {exercicioEscolhido}");
            }
            else
            {
                Console.WriteLine("Erro: Exercício inválido. escolha outra opção.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Valor inválido. Certifique-se de digitar um número inteiro.");
        }
    }
}



