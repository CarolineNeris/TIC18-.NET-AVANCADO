using System;

using LampadaClass;
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma lâmpada inicialmente ligada
            Lampada lampada = new Lampada(true);

            // Imprimindo o estado inicial da lâmpada
            Console.WriteLine("Estado inicial da lâmpada:");
            lampada.Imprimir();

            // Desligando a lâmpada e imprimindo o estado
            lampada.Desligar();
            Console.WriteLine("\nLâmpada desligada:");
            lampada.Imprimir();

            // Ligando a lâmpada novamente e imprimindo o estado
            lampada.Ligar();
            Console.WriteLine("\nLâmpada ligada novamente:");
            lampada.Imprimir();

            // Aguardando o usuário pressionar uma tecla para fechar o programa
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
