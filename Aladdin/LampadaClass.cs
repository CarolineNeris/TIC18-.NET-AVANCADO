namespace LampadaClass;

using System;

class Lampada{
    private bool ligada;

    public Lampada(bool acesa){
        ligada = acesa;
    }
    public void Ligar(){
        ligada = true;
    }

    public void Desligar(){
        ligada = false;
    }

    public void Imprimir()
    {
        if(ligada){
            Console.WriteLine("A lâmpada está ligada//acesa");
        
        }
        else if(ligada==false){
            Console.WriteLine("A lâmpada está apagada");
        }

    }
}   