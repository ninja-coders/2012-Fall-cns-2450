using NUnit.Framework;
using Rhino.Mocks;

namespace UnitTestingAssignmentTests
{
  [TestFixture]
  public class ExampleTestClass
  {
    [TestFixtureSetUp]
    public void MethodIsRun_BeforeAnyTestStarts()
    {      
    }

    [TestFixtureTearDown]
    public void MethodIsRun_AfterAllTestsHaveBeenRun()
    {      
    }

    [SetUp]
    public void MethodIsRun_BeforeEachTest()
    {      
    }

    [TearDown]
    public void MethodIsRun_AfterEachTest()
    {      
    }

    [Test]
    public void MethodThatIs_ATest()
    {
      // Arrange first
      const int EXPECTED = 4;

      // Act
      int actual = 2 + 2;

      // Assert
      Assert.AreEqual(EXPECTED, actual, "2+2 should be 4");
    }

    [Test]
    public void MethodThat_ContainsAMock()
    {
      // Arrange first
      ITestMe mockTestMe = MockRepository.GenerateMock<ITestMe>();
      mockTestMe.Expect(x => x.CallMe____Maybe());

      // Act
      mockTestMe.CallMe____Maybe();

      // Assert
      mockTestMe.VerifyAllExpectations();
    }
  }

  public interface ITestMe
  {
    void CallMe____Maybe();
  }
}
