namespace TeuDinheiroMinhasRegras.ContaBancaria;
using TeuDinheiroMinhasRegras.Exeception;

public class ContaBancaria
{
    private double saldo;
    
    public ContaBancaria (double saldoInicial){
        saldo=saldoInicial;

    }

    public void Sacar (double valorSaque){

         if (valorSaque <= 0)
        {
            throw new ValorInvalidoException( valorSaque);
        }
        if (valorSaque>saldo)
        {
            throw new SaldoInsuficienteException(saldo);
        }

        saldo-=valorSaque;
        Console.WriteLine($"Saque de {valorSaque} realizado com sucesso! Novo saldo: {saldo}");

    }

    public void Depositar (double valorDeposito){
         
         if (valorDeposito <= 0)
        {
            throw new ValorInvalidoException(valorDeposito);
        }
        saldo+=valorDeposito;

        Console.WriteLine($"Deposito de {valorDeposito} realizado com sucesso! Novo saldo: {saldo}");
    }

    public void Transferir(double valorTransferencia, ContaBancaria contaDestino)
        {
             if (valorTransferencia <= 0)
        {
            throw new ValorInvalidoException( valorTransferencia);
        }
        if (valorTransferencia>saldo)
        {
            throw new SaldoInsuficienteException(saldo);
        }
            saldo -= valorTransferencia;
            contaDestino.Depositar(valorTransferencia);
        }
}
