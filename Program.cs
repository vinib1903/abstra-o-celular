using DesafioPOO.Models;

Nokia nokia = new("(48) 9 9999-9999",256,"IMEI123","Tijolão");
Iphone iphone = new("(48) 9 9999-9910",128,"IMEI321","DaShopee");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

