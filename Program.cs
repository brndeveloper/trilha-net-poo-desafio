using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// -User: REALIZADO!
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456", "Modelo 1", "1111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\nSmartphone iPhone:");
Smartphone iphone = new Iphone("4987", "Modelo 2", "22222222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
