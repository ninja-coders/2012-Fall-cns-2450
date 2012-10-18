using System;
using NUnit.Framework;

namespace TDDSample.Tests
{
  [TestFixture]
  public class AAATest
  {
    public int addOne(int x)
    {
      if (x < 0)
      {
        throw new ArgumentOutOfRangeException();
      }

      return x + 1;
    }

    [Test]
    public void TestAddOne()
    {
      const int x = 10;
      const int EXPECTED_RESULT = 11;

      int actualResult = addOne(x);

      Assert.AreEqual(EXPECTED_RESULT, actualResult, "The number that was returned didn't match requested value of 11");
    }

    
    [Test]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void AddOneThrowsAnExceptionWhenInputIsNegative()
    {
      const int x = -1;

      addOne(x);
    }
  }
}