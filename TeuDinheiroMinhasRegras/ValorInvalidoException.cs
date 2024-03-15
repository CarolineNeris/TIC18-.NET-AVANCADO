using System.Dynamic;

namespace TeuDinheiroMinhasRegras.Exeception;

public class ValorInvalidoException: Exception
{
    public double Valor { get;}

    public ValorInvalidoException( double valor):base ("Saldo insuficiente para realizar a operação."){
        Valor=valor;
    }

}
