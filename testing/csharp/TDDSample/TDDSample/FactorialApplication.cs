using System;

namespace TDDSample
{
  class FactorialApplication
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Michael Wright");
      Console.WriteLine("CS 2450\n");

      Console.Write("Enter a number to get a factorial: ");
      int factorialNumber = 0;
      int.TryParse(Console.ReadLine(), out factorialNumber);

      int sum = 0;
      for (int i = 0; i < factorialNumber; ++i)
      {
        sum *= i;
      }
      Console.WriteLine("Factorial Value is {0}", sum);
      Console.ReadLine();
    }
  }
}
