using BankNuggets;

namespace MethodInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Bank Solution*********");
            BankAccount account = new BankAccount("123456", 1000);

            // deposit 500 into account
            account.Deposit(500);

            // withdraw 200 from account
            account.Withdraw(200);

            // get current balance
            Console.WriteLine("Current balance: " + account.GetBalance());

            Console.ReadLine();
        }
    }
}