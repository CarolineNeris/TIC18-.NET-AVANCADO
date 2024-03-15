using exercicio04.ServicoFabria;
using exercicio04.Manufatura;
using exercicio04.IServico;
class Program
{
    static void Main(string[] args)
    {
        
        ServicoFabrica<Manufatura> fabrica = new ServicoFabrica<Manufatura>();
        Manufatura meuManufaturado = fabrica.NovaInstancia();
        meuManufaturado.Executar();
    }
}