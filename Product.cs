using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine
{
    public abstract class Product
    {
        private int productId;
        public int ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                productId = value;
            }
        }

        private double cost;
        public double Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }
        protected IPayment payment;
        protected IEmail email;
        public string DoPayment()
        {
            return payment.MakePayment();
        }

        public void setDifferentPaymentMethod(IPayment payment)
        {
            this.payment = payment;
        }
    }
}
