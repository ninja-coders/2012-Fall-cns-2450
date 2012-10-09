using System;

namespace TDDSample
{
  public class FactorialApplication
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Michael Wright");
      Console.WriteLine("CS 2450\n");

      Console.Write("Enter a number to get a factorial: ");
      int factorialNumber = 0;
      int.TryParse(Console.ReadLine(), out factorialNumber);

      int sum = Factorial(factorialNumber);

      Console.WriteLine("Factorial Value is {0}", sum);
      Console.ReadLine();
    }

    public static int Factorial(int factorialNumber)
    {
      int sum = 1;
      for (int i = 1; i <= factorialNumber; ++i)
      {
        sum *= i;
      }
      return sum;
    }
  }
}
