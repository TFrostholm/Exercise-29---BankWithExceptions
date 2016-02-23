using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // Create a new bank account with 25 % interest rate
            // (is that legal...?)

            BankAccount theAccount = new BankAccount(25.0);
         

            // Deposits 2000 to account
            theAccount.Deposit(2000);


            // Should this be legal...? 
            try
            {
                theAccount.Deposit(-1000);
            }
            catch (NegativeAmountException)
            {
                Console.WriteLine("You can't deposit 0 or a negative number");
            }
            

            // Try to withdraw...
            try
            {
                theAccount.Withdraw(3000);
            }
            catch (WithdrawAmountTooLargeException)
            {
                Console.WriteLine("You tried to withdraw too much money!");
            }


            Console.WriteLine("Balance is now : {0}", theAccount.GetBalance());

            // The LAST line of code should be ABOVE this line
        }
    }
}
