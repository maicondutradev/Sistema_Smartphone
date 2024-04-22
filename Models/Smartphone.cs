namespace Smartphone;

public abstract class Smartphone
{
    public Smartphone(string numero, string modelo, string iMEI, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        IMEI = iMEI;
        Memoria = memoria;
    }

    public string Numero { get; set; }
    private string Modelo { get; set; }
    private string IMEI { get; set; }
    private int Memoria { get; set; }

    public void Ligar()
    {
        Console.WriteLine("Ligando...");
    }
    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação...");
    }
    public abstract void InstalarAplicativo(string nomeApp);

}