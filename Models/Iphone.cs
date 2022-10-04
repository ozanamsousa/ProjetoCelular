namespace ProjetoCelular.Models
{
    public class Iphone : Smartphone
    {
           public Iphone()
        {
            
        }
        public Iphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }
       
        public override void InstalarAplicativo(string nome)
        {
            System.Console.WriteLine($"Instalando aplicativo {nome} no Smartphone Iphone");
        }
    }
}