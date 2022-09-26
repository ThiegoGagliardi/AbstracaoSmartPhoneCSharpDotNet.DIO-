using AbstacaoSmartPhoneCSharpDotNet.DIO.src.Models;

Console.WriteLine("Smartphone Nokia:");
SmartPhone nokia = new Nokia(numero: "912341234", modelo: "N95", imei: "1111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Smartphone iPhone:");
SmartPhone iphone = new Iphone(numero: "9163256898", modelo: "14", imei: "222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
