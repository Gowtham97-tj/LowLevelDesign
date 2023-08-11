using System;

namespace ATM_Design
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SBI ATM");
            Console.WriteLine("Press 1 for Balance Check");
            Console.WriteLine("Press 2 for Cash Withdrawl");
            Account account = new Account();

            int input = Convert.ToInt32(Console.ReadLine());

            if (input > 2)
            {
                Console.WriteLine("Invalid Input");
                Environment.Exit(0);
            }

            if (input == 1)
            {
                Console.WriteLine("Your balance is " + account.getBalance() + " rupees");
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("Please Enter the amount for withdrawl and Amount should be multiples of 100");
                    int inputAmount = Convert.ToInt32(Console.ReadLine());
                    if (inputAmount % 100 != 0)
                    {
                        Console.WriteLine("Please provide amount in multiples of 100");
                    }
                    else
                    {
                        FinalAmount finalAmount = new FinalAmount();
                        CashHandler2000 h1 = new CashHandler2000();
                        CashHandler500 h2 = new CashHandler500();
                        CashHandler100 h3 = new CashHandler100();
                        h1.setSuccessor(h2);
                        h2.setSuccessor(h3);
                        h1.getAmount(finalAmount, inputAmount);
                        Console.WriteLine("Please collect your cash");
                        Console.WriteLine("2000 * " + finalAmount.count2000 + " 500 * " + finalAmount.count500 + " 100 * " + finalAmount.count100);
                    }
                }
            }
        }
    }
}
