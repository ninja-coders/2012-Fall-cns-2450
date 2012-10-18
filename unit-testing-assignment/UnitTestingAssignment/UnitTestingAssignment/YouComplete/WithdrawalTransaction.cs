using UnitTestingAssignment.Contracts;

namespace UnitTestingAssignment.YouComplete
{
  public class WithdrawalTransaction : ITransaction
  {
    public WithdrawalTransaction(float amount)
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