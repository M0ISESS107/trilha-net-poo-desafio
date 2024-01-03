using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine($"meu telefone Nokia");
Smartphone nokia = new Nokia(numero:"81 998223-1432",modelo:"modelo-1",mei:"1111",memoria:128);
nokia.Ligar();
nokia.InstalarAplicativo($"Voice");

Console.WriteLine("\n");

Console.WriteLine($"meu Iphone");
Smartphone IPhone13 = new Iphone(numero:"81 99223-4532", modelo:"modelo-13", mei:"4444", memoria:256);
nokia.Ligar();
IPhone13.InstalarAplicativo($"Music Download");