using ClassAbstract;

Quadrado quadrado = new Quadrado();

Console.WriteLine(quadrado.Descricao());

Console.WriteLine("\n Informe a cor da figura");
quadrado.Cor=Console.ReadLine();

Console.WriteLine("\n Informe o valor do lado do quadrado");
quadrado.Lado=Convert.ToInt32(Console.ReadLine());

quadrado.CalculaArea();
quadrado.CalculaPerimetro();

Console.WriteLine($"\nÁrea do quadrado : {quadrado.Area} m2");
Console.WriteLine($"\nPerimetro do quadrado :{quadrado.Perimetro} m2");
Console.WriteLine($"\nCor do quadrado : {quadrado.Cor} m2");

Console.ReadLine();