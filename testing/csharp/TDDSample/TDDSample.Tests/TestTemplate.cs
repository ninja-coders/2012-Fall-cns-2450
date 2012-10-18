using NUnit.Framework;

namespace TDDSample.Tests
{
  [TestFixture]
  public class TestTemplate
  {
    [Test]
    public void ATestInTheFixtureThatWillRun()
    {
    }

    [TestFixtureSetUp]
    public void BeforeAllTestsInTheClass()
    {
    }

    [TestFixtureTearDown]
    public void AfterAllTestsInTheClass()
    {
    }

    [SetUp]
    public void BeforeEachTest()
    {
    }

    [TearDown]
    public void AfterEachTest()
    {
    }

    public void AMethodThatWillNotRunAsATest()
    {
    }
  }
}
