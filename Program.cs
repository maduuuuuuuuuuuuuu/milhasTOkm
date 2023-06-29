double milhas;
double km;

    Console.WriteLine("");
    Console.WriteLine("este é um convertor de");
    Console.WriteLine("MILHAS para QUILÔMETROS");
    Console.WriteLine("");
    Console.WriteLine("digite o valor em milhas que deseja converter");

milhas = Convert.ToDouble(Console.ReadLine());
km = milhas * 1.609;

    Console.WriteLine(""); 
    Console.WriteLine($"{milhas} são equivalentes a {km} kms");
    Console.WriteLine("");
    Console.WriteLine("obrigado por utilizar este convertor :)");
    Console.WriteLine("");
