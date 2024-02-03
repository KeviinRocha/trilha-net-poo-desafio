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
            // TODO: Implementar as propriedades faltantes de acordo com o diagrama
            // IMPLEMENTADO||
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
            //IMPLEMENTANDO ALGUMAS EXCEPTIONS PARA QUE O USUÁRIO NÃO DIGITE UM VALOR INAPROPRIÁDO ||
            if (string.IsNullOrEmpty(numero))
            {
            throw new ArgumentException("O número do smartphone não pode ser vazio.", nameof(numero));
            } else if(string.IsNullOrEmpty(modelo))
            {
            throw new ArgumentException("O modelo do smartphone não pode ser vazio.", nameof(modelo));    
            } else if(string.IsNullOrEmpty(imei))
            {
            throw new ArgumentException("O IMEI do smartphone não pode ser vazio.", nameof(imei));
            }   if (memoria <= 0)
            {
            throw new ArgumentException("A memória do smartphone deve ser um valor positivo.", nameof(memoria));
            }

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