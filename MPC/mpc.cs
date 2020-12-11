// mpc.cs

using System;

namespace mpc
{
  class Program
  {
    static void Main(string[] args)
    {
	  Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Marginal Propensity to Consume (MPC)");
	  Console.ResetColor();
	  Console.WriteLine("-------------------");
	  Console.Write("Change in Consumer Spending: ");
	  double ACS = Convert.ToDouble(Console.ReadLine());
	  Console.Write("Change in Disposable Income: ");
	  double ADI = Convert.ToDouble(Console.ReadLine());

	  double MPC_  = (ACS / ADI);

	  Console.WriteLine("-------------------");
	  Console.Write("MPC: ");
	  Console.ForegroundColor = ConsoleColor.Green;
	  Console.Write(MPC_);
	  string clear = Console.ReadLine();
    }
  }
}




