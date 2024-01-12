
using HerancaUpscanting;

Circulo circulo = new Circulo(20,20);

Forma forma = circulo; // upcasting

Circulo c = (Circulo)circulo; // downcasting

c.Desenhar();
c.PintarCirculo();

Console.WriteLine(c==forma);
Console.WriteLine(c==circulo);

Console.ReadLine();