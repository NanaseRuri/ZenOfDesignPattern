using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge_22
{
    public abstract class Corp
    {
        private Product product;

        protected Corp(Product product)
        {
            this.product = product;
        }

        public void MakeMoney()
        {
            this.product.BeProduced();
            this.product.BeSold();
        }
    }
}
