// result_gdp.cs

using System;

namespace result_gdp 
{
  class Program
  {
    static void Main(string[] args)
    {
	  Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Resulting GDP");
	  Console.ResetColor();
	  Console.WriteLine("-------------------");
	  Console.Write("Level of Investment: ");
	  double LoI = Convert.ToDouble(Console.ReadLine());
	  Console.Write("Multiplier: ");
	  double mult = Convert.ToDouble(Console.ReadLine());

	  double gdp  = (mult * LoI); 

	  Console.WriteLine("-------------------");
	  Console.Write("Resulting GDP: ");
	  Console.ForegroundColor = ConsoleColor.Green;
	  Console.Write(gdp);
	  string clear = Console.ReadLine();
    }
  }
}

