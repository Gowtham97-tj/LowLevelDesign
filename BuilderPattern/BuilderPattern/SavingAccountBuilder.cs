using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class SavingAccountBuilder : IAccountBuilder
    {
        private Account _loanAccount = new Account();

        public void AddAccountNumber(long accountNumber)
        {
            _loanAccount.AccountNumber = accountNumber;
        }

        public void AddCredential(string userName, string password)
        {
            _loanAccount.UserName = userName;
            _loanAccount.Password = password;
        }

        public void WithLoanAmount(double loanAmount)
        {
            return;
        }

        public void AddInterestRate(double interestRate)
        {
            return;
        }

        public void WithSavingBalance()
        {
            _loanAccount.Balance = 500000;
        }

        public Account GetAccount()
        {
            return _loanAccount;
        }
    }
}
