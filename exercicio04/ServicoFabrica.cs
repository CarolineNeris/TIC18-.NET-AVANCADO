namespace exercicio04.ServicoFabria;
using exercicio04.IServico;


public class ServicoFabrica<T> where T : IServico, new()
{
    public T NovaInstancia()
    {
        return new T();
    }
}
