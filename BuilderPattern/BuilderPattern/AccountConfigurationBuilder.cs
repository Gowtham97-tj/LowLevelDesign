using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class AccountConfigurationBuilder
    {
        public Account BuildLoanAccount(IAccountBuilder accountBuilder)
        {
            accountBuilder.AddAccountNumber(112223);
            accountBuilder.AddCredential("tj", "jjjjjjjjjj");
            accountBuilder.WithLoanAmount(100000);
            accountBuilder.AddInterestRate(12.1);

            return accountBuilder.GetAccount();
        }

        public Account BuildSavingAccount(IAccountBuilder accountBuilder)
        {
            accountBuilder.AddAccountNumber(112223);
            accountBuilder.AddCredential("tj", "jjjjjjjjjj");
            accountBuilder.WithSavingBalance();

            return accountBuilder.GetAccount();
        }
    }
}
