using DesafioPOO.Models;

// Implementado!!!
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123-456-7890", "Nokia 3310", "123456789012345", 16);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("098-765-4321", "iPhone 13", "987654321098765", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");