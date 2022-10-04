using ProjetoCelular.Models;

System.Console.WriteLine("Smartphone Nokia");
Nokia celular = new Nokia(numero: "189283", modelo: "C20", imei: "1525098230", memoria: 64);
celular.Ligar();
celular.ReceberLigacao();
celular.InstalarAplicativo("Waze");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone Iphone");
Iphone celular2 = new Iphone(numero: "19274618233408", modelo: "XR", imei: "1237153836", memoria: 128);
celular2.Ligar();
celular2.ReceberLigacao();
celular2.InstalarAplicativo("Méqui Delivery");