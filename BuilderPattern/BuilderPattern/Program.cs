using BuilderPattern;

public class Program
{
    public static void Main()
    {
        IAccountBuilder loanAccountBuilder = new LoanAccountBuilder();
        IAccountBuilder SavingAccountBuilder = new SavingAccountBuilder();
        AccountConfigurationBuilder accountConfigurationBuilder = new AccountConfigurationBuilder();
        var loan_ac = accountConfigurationBuilder.BuildLoanAccount(loanAccountBuilder);
        var save_ac = accountConfigurationBuilder.BuildSavingAccount(SavingAccountBuilder);

        Console.WriteLine("Loan Account Details");
        Console.WriteLine(loan_ac.AccountNumber);
        Console.WriteLine(loan_ac.UserName);
        Console.WriteLine(loan_ac.InterestRate);
        Console.WriteLine(loan_ac.LoanAmount);


        Console.WriteLine("Savings account detail");
        Console.WriteLine(save_ac.AccountNumber);
        Console.WriteLine(save_ac.UserName);
        Console.WriteLine(save_ac.InterestRate);
        Console.WriteLine(save_ac.Balance);

        Console.ReadLine();

    }
}