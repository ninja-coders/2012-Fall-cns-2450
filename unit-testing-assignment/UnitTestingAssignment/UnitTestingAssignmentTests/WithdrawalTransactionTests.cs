using NUnit.Framework;

namespace UnitTestingAssignmentTests
{
  [TestFixture]
  public class WithdrawalTransactionTests
  {
    [Test]
    public void CanApplyTransaction_ShouldReturnFalse_WhenTheAccountIsNull()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void CanApplyTransaction_ShouldReturnFalse_WhenAccountBalanceIsLessThenTransactionWithdrawalAmount()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void CanApplyTransaction_ShouldReturnTrue_WhenAccountBalanceIsGreaterThenTransactionWithdrawalAmount()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void ApplyTransaction_ShouldNotApply_WhenTheAccountIsNull()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void ApplyTransaction_ShouldNotUpdateAccountBalanceWithCtorAmount_WhenAccountBalanceIsLessThenTransactionWithdrawalAmount()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void ApplyTransaction_ShouldUpdateAccountBalanceWithCtorAmount_WhenAccountBalanceIsGreaterThenTransactionWithdrawalAmount()
    {
      Assert.Fail("Not Implemented");
    }
  }
}