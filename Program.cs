using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("12341234", "Modelo 1", "111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Console.WriteLine("Smartphone iPhone : ");
Smartphone iphone = new Iphone("41232141", "Modelo 2", "222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
Console.WriteLine(iphone.Modelo);