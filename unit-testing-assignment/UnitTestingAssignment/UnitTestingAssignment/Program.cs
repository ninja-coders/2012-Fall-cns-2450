using System;
using UnitTestingAssignment.Contracts;
using UnitTestingAssignment.Implementations;
using UnitTestingAssignment.YouComplete;

namespace UnitTestingAssignment
{
  class Program
  {
    // This is the main program.... I have filled out the shell of what should run.... 
    //   the rest is up to you..... 
    static void Main(string[] args)
    {
      IInputOutput io = new InputOutput();
      ITransactionFactory transactionFactory = new TransactionFactory();
      IAccountFactory accountFactory = new AccountFactory();
      IBank localBank = new Bank(transactionFactory, accountFactory);
      
      Console.WriteLine("Welcome to your local bank's ATM, how can I assist you today");
      bool exit = false;
      while (!exit)
      {
        Console.WriteLine("Options: (a)dd Account\n (d)eposit\n (w)ithdraw\n (b)alance\n (e)xit");
        string option = Console.ReadLine();
        switch (option)
        {
          case "a":
          case "A":
            AddAccount(localBank, io);
            break;
          case "d":
          case "D":
            Deposit(localBank, io, transactionFactory);
            break;
          case "w":
          case "W":
            Withdrawal(localBank, io, transactionFactory);
            break;
          case "b":
          case "B":
            Balance(localBank, io);
            break;
          case "e":
          case "E":
            exit = true;
            break;
          default:
            Console.WriteLine("I'm sorry, but '{0}' is an invalid option, please try again.", option);
            break;
        }
      }

      Console.WriteLine("Thanks for stopping by");
    }

    public static void AddAccount(IBank localBank, IInputOutput io)
    {
      throw new NotImplementedException();
    }

    public static void Deposit(IBank localBank, IInputOutput io, ITransactionFactory transactionFactory)
    {
      throw new NotImplementedException();
    }

    public static void Withdrawal(IBank localBank, IInputOutput io, ITransactionFactory transactionFactory)
    {
      throw new NotImplementedException();
    }

    public static void Balance(IBank localBank, IInputOutput io)
    {
      throw new NotImplementedException();
    }
  }
}
