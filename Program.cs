using System.Reflection;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1234", modelo: "C20", imei: "353190199318249", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Spotify");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "5678", modelo: "15 Pro Max", imei: "356303489345734", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");