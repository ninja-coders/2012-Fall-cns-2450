using UnitTestingAssignment.Contracts;

namespace UnitTestingAssignment.YouComplete
{
  public class Bank : IBank
  {
    public Bank(ITransactionFactory transactionFactory, IAccountFactory accountFactory)
    {
      throw new System.NotImplementedException();
    }

    public int AddAccount(float initialBalance)
    {
      throw new System.NotImplementedException();
    }

    public IAccount AccessAccount(int accountId)
    {
      throw new System.NotImplementedException();
    }

    public void ApplyTransaction(ITransaction transaction, IAccount account)
    {
      throw new System.NotImplementedException();
    }
  }
}