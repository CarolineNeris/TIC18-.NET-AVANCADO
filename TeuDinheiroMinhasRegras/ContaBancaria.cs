namespace TeuDinheiroMinhasRegras.ContaBancaria;

public class ContaBancaria
{
    private double saldo;
    

    public ContaBancaria (double saldoInicial){
        saldo=saldoInicial;
    }

    public void Sacar (double valorSaque){

        saldo-=valorSaque;

    }

    public void Depositar (double valorDeposito){
        saldo+=valorDeposito;
    }

    public void Transferir(double valorTransferencia, ContaBancaria contaDestino)
        {
            saldo -= valorTransferencia;
            contaDestino.Depositar(valorTransferencia);
        }

}
