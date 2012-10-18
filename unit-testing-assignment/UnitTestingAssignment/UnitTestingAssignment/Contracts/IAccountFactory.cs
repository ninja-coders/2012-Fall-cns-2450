namespace UnitTestingAssignment.Contracts
{
  public interface IAccountFactory
  {
    IAccount CreateNewAccount(int accountNumber);
  }
}