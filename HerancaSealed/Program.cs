Cliente cliente = new();
//cliente.Nome = "leandro";
cliente.ExibeNome();


Console.ReadLine();
//Sealed impede que a Cliente herde Pessoa
sealed class Pessoa()
{
    public string? Nome { get; set; }
    public void ExibeNome()
    {
        Console.WriteLine($"Meu nome é {Nome}");
    }
}
class Cliente
{

    public new void ExibeNome()
    {
        /*  Console.WriteLine($"Meu nome é {Nome}");*/
    }
}

class ClassBase
{
    // virtual significa que método pode ser substituido usando override

    protected virtual void Metodo1()
    {
        Console.WriteLine("ClasseBase.Metodo1");
    }
    protected virtual void Metodo2()
    {
        Console.WriteLine("ClasseBase.Metodo2");
    }
}
class ClassBase1 : ClassBase
{
    // override subscreve o virtual
    protected override void Metodo1()
    {
        Console.WriteLine("ClasseBase.Metodo1");
    }
    //Sealed impede que Médoto2 não pode ser mais herdado.
    sealed protected override void Metodo2()
    {
        Console.WriteLine("ClasseBase.Metodo2");
    }
}
