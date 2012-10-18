using System;
using NUnit.Framework;

namespace UnitTestingAssignmentTests
{
  [TestFixture]
  public class BankTests
  {
    [Test]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void AddAccount_ShouldThrowArgumentOutOfRangeException_WhenInitialBalanceIsNegative()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void AddAccount_CreatesNewAccount_WithSuppliedBalance()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void AddAccount_CreatesAccountThatCanBeRetrieved_ByCallingAccessAccountWithReturnedAccountNumber()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void AccessAccount_ReturnsNull_WhenAccountDoesntExistForPassedAccountId()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void AccessAccount_ReturnsNull_WhenRequestedAccountIdIs0()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void AccessAccount_ReturnsNull_WhenRequetedAccountIdIsNegative()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void AccessAccount_ReturnsAccount_WhenAccountExistsWithPassedAccountId()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void ApplyTransaction_WillApplyPassedTransaction_WhenTransactionCanBeApplied()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void ApplyTransaction_WillNotApplyPassedTransaction_WhenTransactionCannotBeApplied()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void ApplyTransaction_WillCreateAFineTransactionOf25Dollars_WhenPassedTransactionCannotBeApplied()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void ApplyTransaction_WillApplyFineTransactionToAccount_WhenPassedTransactionCannotBeApplied()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    [ExpectedException(typeof(ArgumentNullException))]
    public void ApplyTransaction_ThrowsArgumentNullException_WhenTransactionIsNull()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    [ExpectedException(typeof(ArgumentNullException))]
    public void ApplyTransaction_ThrowsArgumentNullException_WhenAccountIsNull()
    {
      Assert.Fail("Not Implemented");
    }
  }
}