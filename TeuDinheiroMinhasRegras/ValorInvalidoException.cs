using System.Dynamic;

namespace TeuDinheiroMinhasRegras.Exeception;

public class ValorInvalidoException: Exception
{
    public double Valor { get;}

    public ValorInvalidoException( double valor):base ("Não é possivel realizar a operação"){
        Valor=valor;
    }

}
