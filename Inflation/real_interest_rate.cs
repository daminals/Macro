// real_interest_rate.cs

using System;

namespace real_interest_rate
{
  class Program
  {
    static void Main(string[] args)
    {
	  Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Inflation Rate (CPI)");
	  Console.ResetColor();
	  Console.WriteLine("-------------------");
	  Console.Write("Nominal Interest Rate : ");
	  double int_rate = Convert.ToDouble(Console.ReadLine());
	  Console.Write("Inflation Rate: ");
	  double infl_rate = Convert.ToDouble(Console.ReadLine());

	  double Rinterest_r = (int_rate - infl_rate); 

	  Console.WriteLine("-------------------");
	  Console.Write("Real Interest Rate: ");
	  Console.ForegroundColor = ConsoleColor.Green;
	  Console.Write(Rinterest_r);
	  string clear = Console.ReadLine();
    }
  }
}
