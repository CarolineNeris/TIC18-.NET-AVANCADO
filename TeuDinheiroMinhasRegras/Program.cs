using System;
using TeuDinheiroMinhasRegras.Exeception;
using TeuDinheiroMinhasRegras.ContaBancaria;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            ContaBancaria conta1 = new ContaBancaria(1000);
            ContaBancaria conta2 = new ContaBancaria(500);

            conta1.Depositar(200);
            conta1.Sacar(300);
            conta1.Transferir(400, conta2);

            // Tenta realizar operações inválidas
            conta2.Sacar(1000); //ele para aqui, não chega a rodar o proximo, pq?
            
            
        }
         catch (ValorInvalidoException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}. Valor inválido: {ex.Valor}"); 
        }
        catch (SaldoInsuficienteException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}. Saldo disponível: {ex.Valor}");
        }
        // teste valor invalido, interessante try-catch para na primeira exception. 
        try{
         ContaBancaria conta3 = new ContaBancaria(1000);
         conta3.Sacar(-100);
            
        }
         catch (ValorInvalidoException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}. Valor inválido: {ex.Valor}");
        }
        catch (SaldoInsuficienteException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}. Saldo disponível: {ex.Valor}");
        }
    
       
        Console.ReadLine();
    }
}
