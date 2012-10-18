namespace UnitTestingAssignment.Contracts
{
  public interface ITransaction
  {
    bool CanApplyTransaction(IAccount account);
    void ApplyTransaction(IAccount account);
  }
}