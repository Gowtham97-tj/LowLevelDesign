using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Design
{
    public class CashHandler2000 : AmountHandler
    {
        public override void getAmount(FinalAmount finalAmount, int amount)
        {
            int count2000 = amount / 2000;
            int remainder = amount % 2000;
            finalAmount.count2000 = count2000;
            if (remainder != 0)
            {
                this.successor.getAmount(finalAmount, remainder);
            }
        }
    }
}
