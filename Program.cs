using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "(37)21010101", modelo: "Nokia S", imei: "123456789", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Iphone");

Smartphone iphone = new Iphone(numero: "(37)3222-1122", modelo: "Iphone 15", imei: "987654321", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagran");