

using HerancaUpscanting;// chamando class circulo

Circulo circulo = new Circulo(10, 20); // Circulo é instanciado 
Forma forma = circulo;  //Forma é instanciado e passa receber circulo Upscanting ( Circulo circulo = new Circulo(10, 20);)                                 
forma.Desenhar();

Console.WriteLine(forma==circulo);

Console.ReadLine();

