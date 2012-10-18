namespace UnitTestingAssignment.Contracts
{
  public interface IAccount
  {
    float Balance { get; }
    float AdjustBalance(float adjustAmount);
    int AccountNumber { get; }
  }
}