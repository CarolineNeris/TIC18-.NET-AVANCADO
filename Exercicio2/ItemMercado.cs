namespace Exercicio2.ItemMercado;

public class ItemMercado
{
    public string Nome { get; set; }

    public double Preco { get; set; }

    public Tipos Tipo { get; set; }

    public ItemMercado(string nome, Tipos tipo, double preco)
    {
        Nome=nome;
        Preco=preco;
        Tipo=tipo;
    }


}

public enum Tipos
{

    Comida,
    Bebida,
    Higiene,
    Limpeza

}
