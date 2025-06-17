using DesafioPOO.Models;

Nokia nokia = new("11999999999", "Nokia 6.1", "1234567890", 64);
Iphone iphone = new("11988888888", "iPhone 12", "0987654321", 128);

Console.WriteLine("Nokia:");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nIphone:");
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
