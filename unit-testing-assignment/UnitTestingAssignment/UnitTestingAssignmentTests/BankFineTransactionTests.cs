using NUnit.Framework;
using Rhino.Mocks;
using UnitTestingAssignment.YouComplete;

namespace UnitTestingAssignmentTests
{
  [TestFixture]
  public class BankFineTransactionTests
  {
    [Test]
    public void CanApplyTransaction_ShouldReturnFalse_WhenTheAccountIsNull()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void CanApplyTransaction_ShouldReturnTrue_WhenAccountIsNotNull()
    {
      Assert.Fail("Not Implemented");      
    }

    [Test]
    public void ApplyTransaction_ShouldNotApply_WhenTheAccountIsNull()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void ApplyTransaction_ShouldUpdateAccountBalanceWithCtorAmount_WhenAccountIsNotNull()
    {
      Assert.Fail("Not Implemented");
    }
  }
}