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
    public double ValorFinal;
    public string resposta;
    public double valor;
    public int contador;
  
    public void CalcularValorFinal(DateTime DataInicial, DateTime DataFinal)
    {
        TimeSpan span = DataFinal.Subtract(DataInicial);
        
        int meses = span.Days / 30;
        int diasRestantes = span.Days % 30 ;
        Taxa = Taxa / 100;
        contador = 1 ;
      
        Console.WriteLine("+------------------------------------+");
        Console.WriteLine("| Valor Mensal | Mês  | Taxa         |");
        Console.WriteLine("+------------------------------------+");
      
      while(contador <= meses){
        ValorFinal = ValorInicial * Math.Pow(1 + Taxa,contador);
        ValorFinal = ValorFinal * Math.Pow(1 + Taxa,                        diasRestantes / 30.0);

         
        Console.WriteLine($"|  {ValorFinal:C}  |   {contador}   |   {Taxa:P}     |");
        Console.WriteLine("+------------------------------------+");

        
        Console.WriteLine("Deseja Efetuar um Saque?(S ou N");
        resposta = Console.ReadLine();
        
          if(resposta == "s"){
            Console.WriteLine("Informe o Valor desejado");
            valor = double.Parse(Console.ReadLine());
            ValorFinal = ValorFinal - valor;
            Console.WriteLine($"Valor Final: {ValorFinal:C}");
            contador = 0;
        }
      else{
       Console.WriteLine($"Valor Final: {ValorFinal:C}");
        }
        contador++;
      }
    }  
}

class Program
{
    static void Main()
    {  
        Recebe.RecebeDados(null);
    }
}
