using DesafioPOO.Models;



Smartphone nokia = new Nokia("55687", "F22", "N55", 556);
Smartphone iphone = new Nokia("55687", "F22", "N55", 556);

Console.WriteLine("----------TESTES-----------");
Console.WriteLine("Nokia");
nokia.Ligar();
nokia.InstalarAplicativo("xadrez");
nokia.ReceberLigacao();
nokia.Numero = "56564";
Console.WriteLine(nokia.Numero);
Console.WriteLine("---------------------------");

Console.WriteLine("----------TESTES-----------");
Console.WriteLine("Iphone");
iphone.Ligar();
iphone.InstalarAplicativo("xadrez");
iphone.ReceberLigacao();
iphone.Numero = "645844";
Console.WriteLine(iphone.Numero);
Console.WriteLine("---------------------------");