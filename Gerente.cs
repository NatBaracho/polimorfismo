using System;

class Gerente : Desconto
{
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine($"Desconto Gerente do vale Alimentação para gerente {salario*0.2:C}");
    }
}