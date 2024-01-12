
using HerancaUpscanting;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("--------------------------------Usando AS");
Object carroObj = new Carro();

var x = carroObj as string;
if(x != null)
{
    Console.WriteLine("Converteu obj para string");
}
else { Console.WriteLine("Não foi possivel converter, x em null"); }


Circulo circulo = new Circulo(20, 20);

Forma forma = circulo; // upcasting



Circulo c= forma as Circulo; // downcasting As verefica a converção

if(c != null)
{
    c.PintarCirculo();
}
else
{
    Console.WriteLine("Operação de downcasting é inválida ");
}

Console.WriteLine("--------------------------------Usando IS");
if (forma is Circulo) // virifica se o downcasting é possivel
{
    Console.WriteLine("Converteu Forma para Circulo");
    var tipo = forma as Circulo;//converte
    tipo?.PintarCirculo();
}
else
{
    Console.WriteLine("Operação de downcasting é inválida ");
}



Console.ReadLine();
class Carro { }