using UnitTestingAssignment.Contracts;
using UnitTestingAssignment.YouComplete;

namespace UnitTestingAssignment.Implementations
{
  public class TransactionFactory : ITransactionFactory
  {
    public ITransaction CreateDeposit(float amount)
    {
      return new DepositTransaction(amount);
    }

    public ITransaction CreateWithdrawal(float amount)
    {
      return new WithdrawalTransaction(amount);
    }

    public ITransaction CreateBankFine(float amount)
    {
      return new BankFineTransaction(amount);
    }
  }
}