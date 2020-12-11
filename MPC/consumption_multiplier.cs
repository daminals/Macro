// consumption_multiplier.cs

using System;

namespace consumption_multiplier
{
  class Program
  {
    static void Main(string[] args)
    {
	  Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Consumption Multiplier");
	  Console.ResetColor();
	  Console.WriteLine("-------------------");


	  Console.Write("Marginal Propensity to Consume: ");
	  double MPC = Convert.ToDouble(Console.ReadLine());

	  double CM = (1/(1-MPC)); 

	  Console.WriteLine("-------------------");
	  Console.Write("Consumption Multiplier: ");
	  Console.ForegroundColor = ConsoleColor.Green;
	  Console.Write(CM);
	  string clear = Console.ReadLine();
    }
  }
}


