using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjVatAdd
{
    class Item
    {
        public double price;

        public Item(double price)
        {
            this.price = price;
        }


        //CALCULATE ITEM VAT
        public double calculateVat()
        {
            double vat = price * 0.14;

            return vat;
        }
    }
}