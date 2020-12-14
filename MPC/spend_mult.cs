// spend_mult.cs

using System;

namespace spend_mult
{
  class Program
  {
    static void Main(string[] args)
    {
	  Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Consumption Multiplier");
	  Console.ResetColor();
	  Console.WriteLine("-------------------");


	  Console.Write("Marginal Propensity to Save: ");
	  double MPS= Convert.ToDouble(Console.ReadLine());

	  double CM = (1/MPS); 

	  Console.WriteLine("-------------------");
	  Console.Write("Consumption Multiplier: ");
	  Console.ForegroundColor = ConsoleColor.Green;
	  Console.Write(CM);
	  string clear = Console.ReadLine();
    }
  }
}


