namespace ProjetoCelular.Models
{
    public class Nokia : Smartphone
    {
           public Nokia()
        {
            
        }
        public Nokia(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }
        public override void InstalarAplicativo(string nome)
        {
            System.Console.WriteLine($"Instalando aplicativo {nome} no Smartphone Nokia");
        }
    }
}