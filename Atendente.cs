using System;

class Atendente : Desconto
{
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine($"Desconto Atendente do vale Alimentação para atendente {salario*0.15:C}");
    }
}