// mps.cs

using System;

namespace mps
{
  class Program
  {
    static void Main(string[] args)
    {
	  Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Marginal Propensity to Save");
	  Console.ResetColor();
	  Console.WriteLine("-------------------");


	  Console.Write("Marginal Propensity to Consume: ");
	  double MPC = Convert.ToDouble(Console.ReadLine());

	  double CM = (1-MPC); 

	  Console.WriteLine("-------------------");
	  Console.Write("Marginal Propensity to Save: ");
	  Console.ForegroundColor = ConsoleColor.Green;
	  Console.Write(CM);
	  string clear = Console.ReadLine();
    }
  }
}


