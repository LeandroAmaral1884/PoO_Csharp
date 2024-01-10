Nada nada = new();
Console.WriteLine("Estão herdando da Classe Object\nNada nada = new();\nnada.Equals(nada);\r\nnada.ToString();\r\nnada.GetType();\r\nnada.GetHashCode();");
//Os métodos abaixo herda do object
nada.Equals(nada);
nada.ToString();
nada.GetType();
nada.GetHashCode();

Console.ReadLine();

class Nada()
{

}