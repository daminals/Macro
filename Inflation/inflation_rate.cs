// inflation_rate.cs

using System;

namespace inflation_rate
{
  class Program
  {
    static void Main(string[] args)
    {
	  Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Inflation Rate");
	  Console.ResetColor();
	  Console.WriteLine("-------------------");
	  Console.Write("Nominal GDP, Year 1: ");
	  double gdp_nom1 = Convert.ToDouble(Console.ReadLine());
	  Console.Write("Nominal  GDP, Year 2: ");
	  double gdp_nom2 = Convert.ToDouble(Console.ReadLine());

	  double deflator = (gdp_nom2 - gdp_nom1); 
	  deflator /= gdp_nom1;
	  deflator *= 100;
	  
	  Console.WriteLine("-------------------");
	  Console.Write("GDP Deflator: ");
	  Console.ForegroundColor = ConsoleColor.Green;
	  Console.Write(deflator);
	  string clear = Console.ReadLine();
    }
  }
}


