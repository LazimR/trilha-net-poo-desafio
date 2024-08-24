using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone Nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "11111111", memoria: 64);
Nokia.Ligar();
Nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone Iphone = new Iphone(numero: "123465", modelo: "Modelo 2", imei: "2222222", memoria: 128);
Nokia.ReceberLigacao();
Nokia.InstalarAplicativo("Telegram");