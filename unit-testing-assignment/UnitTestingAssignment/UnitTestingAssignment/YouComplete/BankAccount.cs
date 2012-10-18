using UnitTestingAssignment.Contracts;

namespace UnitTestingAssignment.YouComplete
{
  public class BankAccount : IAccount
  {
    public BankAccount(int accountNumber)
    {
      throw new System.NotImplementedException();
    }

    public float Balance { get; private set; }
    public float AdjustBalance(float adjustAmount)
    {
      throw new System.NotImplementedException();
    }

    public int AccountNumber { get; private set; }
  }
}