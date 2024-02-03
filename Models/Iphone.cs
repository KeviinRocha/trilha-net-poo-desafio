namespace DesafioPOO.Models
{
    // IMPLEMENTADO ||
    public class Iphone : Smartphone
    {
        // TODO: Herdar da classe "Smartphone"
        // IMPLEMENTADO ||
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        
         // TODO: Sobrescrever o método "InstalarAplicativo"
        // IMPLEMENTADO ||
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o Aplicativo \"{nomeApp}\" no Iphone");
        }
    }
}