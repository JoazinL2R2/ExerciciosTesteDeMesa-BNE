using System;

public class Recebe
{
    public static void RecebeDados(string[] args)
    {
        Metodo Rendimento = new Metodo();

        Console.WriteLine("Informe o valor do investimento inicial:");
        Rendimento.ValorInicial = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o valor da taxa:");
        Rendimento.Taxa = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a Data Inicial (dd/mm/aaaa):");
        string DataInicialStr = Console.ReadLine();
        DateTime DataInicial = DateTime.ParseExact(DataInicialStr, "dd/MM/yyyy", null);

        Console.WriteLine("Informe a Data Final (dd/mm/aaaa):");
        string DataFinalStr = Console.ReadLine();
        DateTime DataFinal = DateTime.ParseExact(DataFinalStr, "dd/MM/yyyy", null);

        Rendimento.CalcularValorFinal(DataInicial, DataFinal);
    }
}

public class Metodo
{
    public double ValorInicial;
    public double Taxa;

    public void CalcularValorFinal(DateTime DataInicial, DateTime DataFinal)
    {
        TimeSpan span = DataFinal.Subtract(DataInicial);
        Console.WriteLine("Time Difference (days): " + span.Days);
        
        int meses = span.Days / 30;
        int diasRestantes = span.Days % 30 ;
        Taxa = Taxa / 100;
        double ValorFinal = ValorInicial * Math.Pow(1 + Taxa, meses);
        ValorFinal = ValorFinal * Math.Pow(1 + Taxa, diasRestantes / 30.0);

        Console.WriteLine(ValorFinal);
    }
}

class Program
{
    static void Main()
    {
        Recebe.RecebeDados(null);
    }
}
