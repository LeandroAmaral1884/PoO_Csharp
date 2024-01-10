var gato = new Gato() { Nome = "bichano" };
gato.ExibeNome();
var cachorro = new Cachorro() { Nome = "preto" };

//cachrro herda de animal
cachorro.ExibeNome();

Console.ReadLine();

// classe 
class Animal()
{
    public string? Nome { get; set; }
    // virtual significa que método pode ser substituido usando override 
    public virtual void ExibeNome()
    {
        Console.WriteLine($"Meu nome é {Nome}");
    }
}

class Gato:Animal
{
   // override subscreve o virtual
    public override void ExibeNome()
    {
        Console.WriteLine($"\nSou um gato;meu nome é {Nome}");
    }
}

class Cachorro:Animal
{

}
