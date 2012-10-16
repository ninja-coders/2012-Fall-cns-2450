using System;

namespace TDDSample
{
  public class FactorialApplication
  {
    static void Main(string[] args)
    {
      IInputOutput io = null;
      IMathOperations math = null;

      RunFactorial(io, math);
    }

    public static void RunFactorial(IInputOutput io, IMathOperations math)
    {
      io.WriteLine("Michael Wright");
      io.WriteLine("CS 2450\n");

      io.Write("Enter a number to get a factorial: ");
      int factorialNumber = 0;
      bool parseSucceeded = int.TryParse(io.ReadLine(), out factorialNumber);
      if (!parseSucceeded)
      {
        return;
      }

      int sum = math.Factorial(factorialNumber);

      io.WriteLine("Factorial Value is {0}", sum);
      io.ReadLine();
    }
  }
}
