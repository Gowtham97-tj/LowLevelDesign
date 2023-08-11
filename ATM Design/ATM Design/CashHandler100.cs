using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Design
{
    public class CashHandler100 : AmountHandler
    {
        public override void getAmount(FinalAmount finalAmount, int amount)
        {
            int count100 = amount / 100;
            int remainder = amount % 100;
            finalAmount.count100 = count100;
            if (remainder != 0)
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}
