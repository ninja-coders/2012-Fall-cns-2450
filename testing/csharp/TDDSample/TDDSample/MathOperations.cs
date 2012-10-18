namespace TDDSample
{
  public class MathOperations : IMathOperations
  {
    public int Factorial(int factorialNumber)
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