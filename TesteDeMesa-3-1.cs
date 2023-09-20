using System;
public class Metodo
{
    public double ValorInicial;
    public double Taxa;
    public int Periodo;
   
    public void CalcularValorFinal()
    {
        Taxa = Taxa / 100;
        double ValorFinal = ValorInicial * Math.Pow(1 + Taxa, Periodo);
        Console.WriteLine("O valor final é: " + ValorFinal);
    }
}

class Program
{
    static void Main()
    {
        Metodo Rendimento = new Metodo();
        
        Console.WriteLine("Informe o valor do investimento inicial:");
        Rendimento.ValorInicial = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o valor da taxa:");
        Rendimento.Taxa = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o período:");
        Rendimento.Periodo = Int32.Parse(Console.ReadLine());
        Rendimento.CalcularValorFinal();
    }
}
