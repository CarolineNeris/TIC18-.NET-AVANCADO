using System;

public struct Ponto<T>
{
    public T X { get; set; }
    public T Y { get; set; }
    public T Z { get; set; }

    public Ponto(T x, T y, T z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}

public struct Triangulo<T>
{
    public Ponto<T> P1 { get; set; }
    public Ponto<T> P2 { get; set; }
    public Ponto<T> P3 { get; set; }

    public Triangulo(Ponto<T> p1, Ponto<T> p2, Ponto<T> p3)
    {
        P1 = p1;
        P2 = p2;
        P3 = p3;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando diferentes pontos com tipos de dados diferentes
        Ponto<int> pontoInt = new Ponto<int>(8, 8, 3);
        Ponto<double> pontoDouble = new Ponto<double>(1.9, 8.5, 3.5);
        Ponto<float> pontoFloat = new Ponto<float>(1.5f, 2.3f, 7.4f);

        
        Triangulo<int> trianguloInt  = new Triangulo<int>(new Ponto<int>(1, 2, 3), 
        new Ponto<int>(4, 5, 6), new Ponto<int>(7, 8, 9));

        Triangulo<double> trianguloDouble = new Triangulo<double>(new Ponto<double>(1.5, 2.5, 3.5),
        new Ponto<double>(4.5, 5.5, 6.5), new Ponto<double>(7.5, 8.5, 9.5));
        Triangulo<float> trianguloFloat = new Triangulo<float>(new Ponto<float>(1.2f, 2.3f, 3.4f),
        new Ponto<float>(4.2f, 5.3f, 6.4f), new Ponto<float>(7.2f, 8.3f, 9.4f));
        
        Console.WriteLine("Pontos:");
    
        
    Console.WriteLine("{truanguloDouble");
    Console.WriteLine($"Ponto Int: ({pontoInt.X}, {pontoInt.Y}, {pontoInt.Z})");
        Console.WriteLine($"Ponto Double: ({pontoDouble.X}, {pontoDouble.Y}, {pontoDouble.Z})");
        Console.WriteLine($"Ponto Float: ({pontoFloat.X}, {pontoFloat.Y}, {pontoFloat.Z})");

        Console.WriteLine("\nTriângulos:");
        Console.WriteLine($"Triângulo Int: P1({trianguloInt.P1.X}, {trianguloInt.P1.Y}, {trianguloInt.P1.Z}), P2({trianguloInt.P2.X}, {trianguloInt.P2.Y}, {trianguloInt.P2.Z}), P3({trianguloInt.P3.X}, {trianguloInt.P3.Y}, {trianguloInt.P3.Z})");
        Console.WriteLine($"Triângulo Double: P1({trianguloDouble.P1.X}, {trianguloDouble.P1.Y}, {trianguloDouble.P1.Z}), P2({trianguloDouble.P2.X}, {trianguloDouble.P2.Y}, {trianguloDouble.P2.Z}), P3({trianguloDouble.P3.X}, {trianguloDouble.P3.Y}, {trianguloDouble.P3.Z})");
        Console.WriteLine($"Triângulo Float: P1({trianguloFloat.P1.X}, {trianguloFloat.P1.Y}, {trianguloFloat.P1.Z}), P2({trianguloFloat.P2.X}, {trianguloFloat.P2.Y}, {trianguloFloat.P2.Z}), P3({trianguloFloat.P3.X}, {trianguloFloat.P3.Y}, {trianguloFloat.P3.Z})");
    }
}
