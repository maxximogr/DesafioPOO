using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine($"Iniciando testes com o celular Nokia:");
Nokia nokia = new Nokia(numero: "3310", modelo: "O Indestrutível 3310", imei: "000000123456789",memoria: 8);
nokia.ModeloCeluar(": Nokia 3310");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.Instalando("Space Impact");
nokia.InstalarAplicativo("");

Console.WriteLine("");

Console.WriteLine("Testes realizados com sucesso!");
Console.WriteLine("");


Console.WriteLine("Iniciando testes com o Smartphone Iphone:");
Iphone iphone = new Iphone(numero: "12", modelo: "Iphone 12", imei: "000001123456789",memoria: 128);
iphone.ModeloCeluar(": Iphone 12");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.Instalando("Instagram");
iphone.InstalarAplicativo("");

Console.WriteLine("");

Console.WriteLine("Testes realizados com sucesso!");

