using exercicio04.ServicoFabria;
using exercicio04.Manufatura;

class Program
{
    static void Main(string[] args)
    {
        
        ServicoFabrica<Manufatura> fabrica = new ServicoFabrica<Manufatura>();
        Manufatura meuManufaturado = fabrica.NovaInstancia();
        //eu poderia fazer isso?Manufatura Meu manufaturado = Manufatura.executar
        
        meuManufaturado.Executar();
    }
}