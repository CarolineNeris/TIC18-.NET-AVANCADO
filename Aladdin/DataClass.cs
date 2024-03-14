namespace Dataclass;
using System;

class Data{
    private readonly int _dia;
    private readonly int _mes;
    private readonly int _ano;
    private readonly int _hora;
    private readonly int _minuto;
    private readonly int _segundo;

    public const int FORMATO_12H = 12;
    public const int FORMATO_24H = 24;
//primeiro construtor
public Data (int dia, int mes, int ano) {
    _dia = dia;
    _mes = mes;
    _ano = ano;

    }
    public Data(int dia, int mes, int ano, int hora, int minuto, int segundo) : this(dia, mes, ano)
    {
        //verificar hora formato de 0 a 23 (adicionalmente segundos e minutos)

        if (hora<0||hora>23){
            throw new ArgumentOutOfRangeException(nameof(hora), "A hora deve estar entre 0 e 23.");

        }
        if (minuto<0 ||minuto>61){
            throw new ArgumentOutOfRangeException(nameof(minuto), "O minuto deve estar entre 0 e 60");
        }
        
        if (segundo<0 ||segundo>61){
            throw new ArgumentOutOfRangeException(nameof(segundo), "O segundo deve estar entre 0 e 60");
        }

        _hora=hora;
        _minuto=minuto;
        _segundo=segundo;
    }

    public int Dia => _dia;
    public int Mes => _mes;
    public int Ano => _ano;
    public int Hora => _hora;
    public int Minuto => _minuto;
    public int Segundo => _segundo;


    public void Imprimir(int formatoHora)
    {
        
        string formato;
        if (formatoHora == FORMATO_12H)
        {
            formato = "dd/MM/yyyy hh:mm:ss tt"; // Formato de 12 horas
        }
        else if (formatoHora == FORMATO_24H)
        {
            formato = "dd/MM/yyyy HH:mm:ss"; // Formato de 24 horas
        }
        else
        {
            throw new ArgumentException("Formato de hora inválido. Use FORMATO_12H ou FORMATO_24H.");
        }

        if (_hora == 0 && _minuto == 0 && _segundo == 0)
        {
            formato = "dd/MM/yyyy"; 
        }

        DateTime dataHora = new DateTime(Ano, Mes, Dia, Hora, Minuto, Segundo);
        Console.WriteLine(dataHora.ToString(formato));
    }

}


