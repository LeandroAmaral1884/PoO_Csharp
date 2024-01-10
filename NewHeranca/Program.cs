Aluno aluno = new Aluno();
aluno.Nome = "Leandro";
aluno.Curso = "TI";
Console.WriteLine(aluno.Saudacao());


Console.ReadLine();


class Pessoa()
{
    public string? Nome { get; set; }
    public string Saudacao() => $"Oi,Eu sou o (a) {Nome}";
}

class Aluno:Pessoa
{
    public string? Curso { get; set; }
    public new string Saudacao() => $"Oi,Eu sou o (a) {Nome} do curso de :{Curso}";
}