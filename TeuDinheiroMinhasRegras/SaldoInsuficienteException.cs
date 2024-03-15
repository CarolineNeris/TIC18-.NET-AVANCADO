namespace TeuDinheiroMinhasRegras.Exeception;

public class SaldoInsuficienteException:Exception
{
    public double Valor {get;}

    public SaldoInsuficienteException ( double valor): base("Saldo insuficiente para realizar a operação"){
        Valor = valor;
    }

}
