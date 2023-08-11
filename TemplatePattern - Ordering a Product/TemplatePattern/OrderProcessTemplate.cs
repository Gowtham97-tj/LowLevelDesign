using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public abstract class OrderProcessTemplate
    {
        public bool isGift;

        public abstract void doSelect();

        public abstract void doPayment();

        public void giftWrap()
        {
            try
            {
                Console.WriteLine("Gift wrap successful");
            }
            catch (Exception e)
            {
                Console.WriteLine("Gift wrap unsuccessful");
            }
        }

        public abstract void doDelivery();

        public void processOrder(bool isGift)
        {
            doSelect();
            doPayment();
            if (isGift)
            {
                giftWrap();
            }
            doDelivery();
        }
    }
}
