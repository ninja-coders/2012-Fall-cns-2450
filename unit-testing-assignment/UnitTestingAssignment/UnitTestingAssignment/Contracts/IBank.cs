namespace UnitTestingAssignment.Contracts
{
  public interface IBank
  {
    int AddAccount(float initialBalance);
    IAccount AccessAccount(int accountId);
    void ApplyTransaction(ITransaction transaction, IAccount account);
  }
}