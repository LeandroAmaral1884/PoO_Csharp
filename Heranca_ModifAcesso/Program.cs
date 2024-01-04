﻿ClasseDerivada cd = new ClasseDerivada();
cd.VerificaAcesso();

Console.ReadKey();
public class ClasseDerivada : ClasseBase
{
    public void VerificaAcesso()
    {
        Public_Membro();
        Protected_Membro();
        Internal_Membro();
        Protected_Internal_Membro();
        // Private_Membro();

        Console.WriteLine("\n\nAcesso ao campo private:private_var usando uma propridade Get");
        int soma = public_var+protected_var+internal_var+Private_var;
        Console.WriteLine("\nTotal soma :" + soma);
    }
}

public class ClasseBase
{
    // campos
    public int public_var = 1;
    protected int protected_var = 2;
    internal int internal_var = 3;
    private int private_var = 4;
    // propridaes
    public int Private_var { get { return private_var; } set { private_var = value; } }



    public void Public_Membro()
    {
        Console.WriteLine("ClasseBase - Método Public");
    }

    protected void Protected_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected");
    }

    internal void Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método Internal");
    }
    protected internal void Protected_Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected Internal");
    }
    private void PPrivate_Membro()
    {
        Console.WriteLine("ClasseBase - Private");
    }
}