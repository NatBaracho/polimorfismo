using System;

class Desconto
{
    public virtual void valeAlimentacao(double salario)
    {
        Console.WriteLine($"Desconto padrão do vale Alimentação {salario*0.1:C}");
    }

    public void valeTransporte(double salario)
    {
        Console.WriteLine($"Desconto padrão do vale Transporte {salario*0.06:C}");
    }
}