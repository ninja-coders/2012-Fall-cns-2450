using UnitTestingAssignment.Contracts;

namespace UnitTestingAssignment.YouComplete
{
  public class BankFineTransaction : ITransaction
  {
    public BankFineTransaction(float amount)
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