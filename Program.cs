using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone - iPhone");
Smartphone iphone = new Iphone("123456789", "iPhone 13", "IMEI123456", "128GB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("Smartphone - Nokia");
Smartphone nokia = new Nokia("987654321", "Nokia 3310", "IMEI654321", "32MB");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");
