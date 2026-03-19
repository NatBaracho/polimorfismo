namespace Polimorfismo;

class Program
{
    static void Main(string[] args)
    {
        //implementação Estagiário

        Desconto ObjE = new Estagiario();
        ObjE.valeAlimentacao(1000);
        ObjE.valeTransporte(1000);
        Console.WriteLine("--------------------------------");
        
        //implementação Atendente
        Desconto ObjA = new Atendente();
        ObjA.valeAlimentacao(2000);
        ObjA.valeTransporte(2000);
        Console.WriteLine("--------------------------------");

        //implementação Gerente

        Desconto ObjG = new Gerente();
        ObjG.valeAlimentacao(3000);
        ObjG.valeTransporte(3000);
        Console.WriteLine("--------------------------------");
    }
}
