using NUnit.Framework;

namespace TDDSample.Tests
{
  [TestFixture]
  public class MathOperationsTests
  {
    [Test]
    public void FactorialOf3Is6()
    {
      const int EXPECTED = 6;
      const int INITIAL = 3;

      TestFactorialValue(INITIAL, EXPECTED, "Factorial of 3 should be 6");
    }

    private static void TestFactorialValue(int initial, int expected, string message="")
    {
      MathOperations implementation = new MathOperations();
      int actual = implementation.Factorial(initial);
      
      Assert.AreEqual(expected, actual, message);
    }

    [Test]
    public void FactorialOf0Is1()
    {
      const int EXPECTED = 1;
      const int INITIAL = 0;
      TestFactorialValue(INITIAL, EXPECTED, "Factorial of 0 should be 1");
    }
  }
}