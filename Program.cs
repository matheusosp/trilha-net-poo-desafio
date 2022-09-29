using DesafioPOO.Models;

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "9945158587", modelo: "5", IMEI: "6", memoria: 12);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "47545463", modelo: "4555", IMEI: "454545", memoria: 32);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");