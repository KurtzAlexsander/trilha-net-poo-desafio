using DesafioPOO.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Smartphone c1 = new Nokia(numero: "48456", modelo: "Modelo 1", imei:"22" , memoria:64) ;
        c1.Ligar();
        c1.InstalarAplicativo("Telegran");
        c1.ReceberLigacao();

        Console.WriteLine("-----");

        Smartphone c2 = new Iphone(numero: "54631", modelo: "Modelo 2", imei: "22", memoria: 128);
        c2.Ligar();
        c2.InstalarAplicativo("WhatsApp");
        c2.ReceberLigacao();

    }
}