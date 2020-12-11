// CPI.cs

using System;

namespace CPI
{
  class Program
  {
    static void Main(string[] args)
    {
	  Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Consumer Price Index (CPI)");
	  Console.ResetColor();
	  Console.WriteLine("-------------------");
	  Console.Write("Consumer Market Basket : ");
	  double mbasket1 = Convert.ToDouble(Console.ReadLine());
	  Console.Write("Base Market Basket: ");
	  double mbasket2 = Convert.ToDouble(Console.ReadLine());

	  double CPI_  = (mbasket1 / mbasket2); 
	  CPI_ *= 100;

	  Console.WriteLine("-------------------");
	  Console.Write("Consumer Price Index: ");
	  Console.ForegroundColor = ConsoleColor.Green;
	  Console.Write(CPI_);
	  string clear = Console.ReadLine();
    }
  }
}

