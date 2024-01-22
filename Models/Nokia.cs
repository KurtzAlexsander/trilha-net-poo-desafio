namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero , string modelo , string imei, int memoria) : base(numero)
        {
            numero = Numero;
            modelo = Modelo;
            imei = Imei;
            memoria = Memoria;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"instalando {nomeApp} no nokia");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}