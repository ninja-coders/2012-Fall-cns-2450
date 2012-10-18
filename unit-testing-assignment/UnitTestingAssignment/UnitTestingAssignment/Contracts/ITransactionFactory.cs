namespace UnitTestingAssignment.Contracts
{
  public interface ITransactionFactory
  {
    ITransaction CreateDeposit(float amount);
    ITransaction CreateWithdrawal(float amount);
    ITransaction CreateBankFine(float amount);
  }
}