using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Design
{
    public class CashHandler500 : AmountHandler
    {
        public override void getAmount(FinalAmount finalAmount, int amount)
        {
            int count500 = amount / 500;
            int remainder = amount % 500;
            finalAmount.count500 = count500;
            if (remainder != 0)
            {
                this.successor.getAmount(finalAmount, remainder);
            }
        }
    }
}
