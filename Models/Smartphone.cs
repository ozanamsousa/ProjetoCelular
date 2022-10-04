namespace ProjetoCelular.Models
{
    public abstract class Smartphone
    {
        public Smartphone()
        {
            
        }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }
        public string Numero {get; set;}
        protected string Modelo {get; set;}
        protected string Imei {get; set;}
        protected int Memoria {get; set;}

        public virtual void Ligar()
        {
            System.Console.WriteLine($"Ligando. . .");
        }
        public virtual void ReceberLigacao()
        {
            System.Console.WriteLine($"Recebendo Ligação. . .");
        }
        public abstract void InstalarAplicativo(string nome);
       
    }
}