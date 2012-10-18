using UnitTestingAssignment.Contracts;

namespace UnitTestingAssignment.YouComplete
{
  public class DepositTransaction : ITransaction
  {
    public DepositTransaction(float amount)
    {
      throw new System.NotImplementedException();
    }

    public bool CanApplyTransaction(IAccount account)
    {
      throw new System.NotImplementedException();
    }

    public void ApplyTransaction(IAccount account)
    {
      throw new System.NotImplementedException();
    }
  }
}