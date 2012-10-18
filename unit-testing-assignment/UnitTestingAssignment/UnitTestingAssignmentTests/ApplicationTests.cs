using System;
using NUnit.Framework;

namespace UnitTestingAssignmentTests
{
  [TestFixture]
  public class ApplicationTests
  {
    [Test]
    [ExpectedException(typeof(ArgumentNullException))]
    public void AddAccount_ThrowsArgumentNullException_WhenSuppliedBankIsNull()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    [ExpectedException(typeof(ArgumentNullException))]
    public void AddAccount_ThrowsArgumentNullException_WhenSuppliedInputOutputIsNull()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Balance_ThrowsArgumentNullException_WhenSuppliedBankIsNull()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Balance_ThrowsArgumentNullException_WhenSuppliedInputOutputIsNull()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Deposit_ThrowsArgumentNullException_WhenSuppliedBankIsNull()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Deposit_ThrowsArgumentNullException_WhenSuppliedInputOutputIsNull()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Deposit_ThrowsArgumentNullException_WhenSuppliedTransactionFactoryIsNull()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Withdrawal_ThrowsArgumentNullException_WhenSuppliedBankIsNull()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Withdrawal_ThrowsArgumentNullException_WhenSuppliedInputOutputIsNull()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Withdrawal_ThrowsArgumentNullException_WhenSuppliedTransactionFactoryIsNull()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void AddAccount_ReturnsWithoutAddingAnAccount_WhenTheUserDoesntInputAValidInitialBalance()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void AddAccount_ReturnsWithoutAddingAnAccount_WhenTheUserInputIsANegativeNumber()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void AddAccount_CreatesNewAccount_WhenInitialBalanceIsIntegerValue()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void AddAccount_CreatesNewAccount_WhenInitialBalanceIsFloatingValue()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void AddAccount_DisplaysTheCreatedAccountNumber_WhenAnAccountIsCreated()
    {
      // Hint - You will want to make sure that IInputOutput.WriteLine was called with a set message including the account number
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void Deposit_DoesntApplyATransaction_WhenTheUserEnteredAmountIsNotANumber()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void Deposit_ApplysAmountToAccount_WhenAmountEnteredIsAnInteger()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void Deposit_ApplysAmountToAccount_WhenAmountEnteredIsAFloat()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void Deposit_ApplysTransactionToAccount_ThroughTheBank()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void Withdrawal_DoesntApplyATransaction_WhenTheUserEnteredAmountIsNotANumber()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void Withdrawal_ApplysAmountToAccount_WhenAmountEnteredIsAnInteger()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void Withdrawal_ApplysAmountToAccount_WhenAmountEnteredIsAFloat()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void Withdrawal_ApplysTransactionToAccount_ThroughTheBank()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void Balance_DoesntDisplayBalance_IfUserEntersNonNumberForAccountNumber()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void Balance_DoesntDisplayBalance_IfUserEntersANonExistantAccountNumber()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void Balance_GetsTheBalanceAmount_FromTheAccountReturnedByTheBank()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void Balance_DisplaysBalanceToUser_ThroughInputOutput()
    {
      // Hint - You will want to make sure that IInputOutput.WriteLine was called with a set message including the account number
      Assert.Fail("Not Implemented");
    }
  }
}