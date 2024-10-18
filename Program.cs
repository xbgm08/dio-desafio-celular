using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Implementado

Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone(numero: "1234-5678", modelo: "iPhone 15 Pro Max", imei: "7456479854155", memoria: 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Crunchyroll");

Console.WriteLine("\n");

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "8765-4321", modelo: "Nokia G60", imei: "895498541565", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Funimation");