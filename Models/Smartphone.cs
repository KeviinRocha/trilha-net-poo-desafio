namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        // IMPLEMENTADO||
        private string _modelo;
        private string _imei;
        private int _memoria;
        
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // IMPLEMENTADO||
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
        }

        public string Modelo
            {
                get { return _modelo; }
            }
            public string IMEI
            {
                get { return _imei; }
            }
            public int Memoria
            {
                get { return _memoria; }
            }


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
}