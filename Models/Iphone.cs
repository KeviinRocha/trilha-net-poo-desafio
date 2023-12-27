namespace DesafioPOO.Models
{
    // IMPLEMENTADO ||
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        // IMPLEMENTADO ||
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o Aplicativo {nomeApp} no Iphone");
        }
    }
}