// gdp_deflator.cs

using System;

namespace gdp_deflator
{
  class Program
  {
    static void Main(string[] args)
    {
	  Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("GDP Deflator");
	  Console.ResetColor();
	  Console.WriteLine("-------------------");
	  Console.Write("Enter Nominal GDP: ");
	  double gdp_nom = Convert.ToDouble(Console.ReadLine());
	  Console.Write("Enter Real  GDP: ");
	  double gdp_real = Convert.ToDouble(Console.ReadLine());

	  double deflator = gdp_nom/gdp_real;
	  deflator *= 100;
	  
	  Console.WriteLine("-------------------");
	  Console.Write("GDP Deflator: ");
	  Console.ForegroundColor = ConsoleColor.Green;
	  Console.Write(deflator);
	  string clear = Console.ReadLine();
    }
  }
}

