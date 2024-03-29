﻿Console.WriteLine(" \nHerança---> Não pode herdar mais de uma classe Base \n");

Funcionario funcionario = new Funcionario();
funcionario.Nome = "Leandro";
funcionario.Email = "Leandro.amaral@";
funcionario.Empresa = "LSA";
funcionario.Salario = 9000;

Console.WriteLine("\nFuncionario\n");
Console.WriteLine(funcionario.Empresa);
Console.WriteLine(funcionario.Salario);
funcionario.Indetificar();

Aluno aluno = new Aluno();
aluno.Nome = "Pedro";
aluno.Email = "Pedro@@@";
aluno.Curso = "TI";
aluno.Nota = 9;
Console.WriteLine("\nAluno\n");
Console.WriteLine(aluno.Curso);
Console.WriteLine(aluno.Nota);
aluno.Indetificar();

Console.ReadKey();

// class base
public class Pessoa
{
    public string Nome{ get; set; }
    public string Email { get; set; }

    public void Indetificar()
    {
        Console.WriteLine($"{Nome} - {Email}");
    }
}
// classe derivada herda Pessoa
public class Funcionario: Pessoa
{
    public string Empresa { get; set; }
    public decimal Salario { get; set; }

}// classe derivada herda Pessoa
public class Aluno : Pessoa
{
    public string Curso { get; set; }
    public decimal Nota { get; set; }

}