using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjVatAdd
{
    class Item
    {
        List<double> price = new List<double>();
        String[] itemsString = new string[26];

        public Item(List<double>price, String[] itemsString)
        {
            this.price = price;
            this.itemsString = itemsString;
        }


        public double calculateVat() {
            double total = 0;

            for (int i = 0; i < price.Count(); i++)
            {
                total = total + price[i];
            }
            double vat = total * 0.14;

            return vat;
        }
    }
}
