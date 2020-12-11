// infl_rate_CPI.cs

using System;

namespace infl_rate_CPI
{
  class Program
  {
    static void Main(string[] args)
    {
	  Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Inflation Rate (CPI)");
	  Console.ResetColor();
	  Console.WriteLine("-------------------");
	  Console.Write("Current CPI: ");
	  double CPI_1 = Convert.ToDouble(Console.ReadLine());
	  Console.Write("Last Year CPI: ");
	  double CPI_2 = Convert.ToDouble(Console.ReadLine());

	  double inflation_r = (CPI_2 - CPI_1);
	  inflation_r /= CPI_1;
	  inflation_r *= 100;

	  Console.WriteLine("-------------------");
	  Console.Write("Inflation Rate: ");
	  Console.ForegroundColor = ConsoleColor.Green;
	  Console.Write(inflation_r);
	  string clear = Console.ReadLine();
    }
  }
}



