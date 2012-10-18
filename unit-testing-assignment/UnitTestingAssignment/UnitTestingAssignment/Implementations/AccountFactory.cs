using UnitTestingAssignment.Contracts;
using UnitTestingAssignment.YouComplete;

namespace UnitTestingAssignment.Implementations
{
  public class AccountFactory : IAccountFactory
  {
    public IAccount CreateNewAccount(int accountNumber)
    {
      return new BankAccount(accountNumber);
    }
  }
}