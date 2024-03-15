using System;

class Program
{
    static void Main(string[] args)
    {
       
           // object o = null;
           // o.ToString(); // Esta linha irá lançar uma exceção

            /*Unhandled exception. ( tá aqui o miseravi!) ---->System.NullReferenceException: Object reference 
            not set to an instance of an object. at Program.Main(String[] args) 
            in C:\Users\Carol\Documents\ResidenciaTic18\DOTNET\TIC18-.NET-AVANCADO\exercicio02\Program.cs:line 9*/
    
    
    try
        {
            object o = null;
            o.ToString(); // Esta linha irá lançar uma exceção
        }
        catch (NullReferenceException ex)
        {
            // Se ocorrer uma exceção, exiba uma mensagem amigável ao usuário
            Console.WriteLine("objeto nulo não pode  converrtr em uma string");
        }
    }
}
