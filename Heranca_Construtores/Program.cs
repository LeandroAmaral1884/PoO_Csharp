Console.WriteLine("\n-----------------Classe Pessoa\n");
Pessoa pessoa1 = new Pessoa();

Console.WriteLine("\n----------------Classe Aluno herda Pessoa\n");
Aluno aluno1 = new Aluno();

Console.WriteLine("\n---------------Classe Aluno herda Pessoa passando parametro\n");
Aluno aluno2 = new Aluno("Leandro");
Console.ReadLine();


//classe base
class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("construtor da classe Pessoa");
    }
    public Pessoa( string nome)
    {
        Console.WriteLine("construtor da classe Pessoa com parametro");
    }
}

class Aluno : Pessoa
{
    public Aluno() : base() // base() chama construtor  public Pessoa() sem parametro
    {
        Console.WriteLine("construtor da classe Aluno");
    }
    public Aluno(string nome) :base(nome) // base(nome) chama construtor   public Pessoa( string nome) com parametro
    {
        Console.WriteLine("construtor da classe Aluno com parametro");
    }
}