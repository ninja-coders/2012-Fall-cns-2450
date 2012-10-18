using System;
using NUnit.Framework;
using Rhino.Mocks;

namespace TDDSample.Tests
{
  [TestFixture]
  public class RunFactorialTests
  {
    private IMathOperations _mockMath;
    private IInputOutput _mockIO;

    [SetUp]
    public void SetupDependencies()
    {
      _mockMath = MockRepository.GenerateMock<IMathOperations>();
      _mockIO = MockRepository.GenerateMock<IInputOutput>();
    }

    [Test]
    public void RunFactorial_DoesntCalculateFactorial_WhenInputIsNotANumber()
    {
      _mockIO.Expect(x => x.ReadLine()).Return("Invalid String");

      FactorialApplication.RunFactorial(_mockIO, _mockMath);

      _mockMath.AssertWasNotCalled(x => x.Factorial(Arg<int>.Is.Anything));
    }

    [Test]
    public void RunFactorial_PassesUserInputtedNumber_ToFactorialMethod()
    {
      const int EXPECTED = 10;

      _mockIO.Expect(x => x.ReadLine()).Return(EXPECTED.ToString());

      FactorialApplication.RunFactorial(_mockIO, _mockMath);

      _mockMath.AssertWasCalled(x => x.Factorial(EXPECTED));
    }
  }
}
