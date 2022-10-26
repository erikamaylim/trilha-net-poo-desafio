using DesafioPOO.Models;


Console.WriteLine($"Smartphone Nokia:");
Smartphone nokia = new Nokia("123456", "Modelo G21", "111111111", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("e-Título");

Console.WriteLine("");

Console.WriteLine($"Smartphone iPhone:");
Smartphone iphone = new Iphone("987654", "Modelo 14 Pro", "222222222", 256);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Conecte SUS");


