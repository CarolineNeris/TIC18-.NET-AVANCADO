namespace Dataclass;
using System;

class Data{
    private readonly int _dia;
    private readonly int _mes;
    private readonly int _ano;
    private readonly int _hora;
    private readonly int _minuto;
    private readonly int _segundo;
//primeiro construtor
public Data (int dia, int mes, int ano) {
    _dia = dia;
    _mes = mes;
    _ano = ano;

    }
    public Data(int dia, int mes, int ano, int hora, int minuto, int segundo) : this(dia, mes, ano)
    {
        //verificar hora formato de 0 a 23 (adicionalmente segundos e minutos)

        if (hora<0||hora<=23){
            throw new ArgumentOutOfRangeException(nameof(hora), "A hora deve estar entre 0 e 23.");

        }
        if (minuto<0 ||minuto>61){
            throw new ArgumentOutOfRangeException(nameof(minuto), "O minuto deve estar entre 0 e 60");
        }
        
        if (segundo<0 ||segundo>61){
            throw new ArgumentOutOfRangeException(nameof(segundo), "O segundo deve estar entre 0 e 60");
        }
    }
}


