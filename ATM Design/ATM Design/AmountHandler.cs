using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Design
{
    public abstract class AmountHandler
    {
        protected AmountHandler successor;

        public void setSuccessor(AmountHandler successor)
        {
           this.successor = successor;
        }

        public abstract void getAmount(FinalAmount finalAmount, int amount);
    }
}
