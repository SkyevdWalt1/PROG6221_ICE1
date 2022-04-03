using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjVatAdd
{
    class Cart
    {
        List<Item> itemPrice = new List<Item>();
        String[] itemsString = new string[26];
        double vat;

        public Cart(List<Item> itemPrice, String[] itemsString)
        {
            this.itemPrice = itemPrice;
            this.itemsString = itemsString;
        }


        public double getTotalPrice()
        {
            double total = 0;
            for (int i = 0; i < itemPrice.Count(); i++)
            {
                Item b = (Item)itemPrice[i];
                total = total + b.price;
            }

            vat = total * 0.14;

            return total;
        }


        public override string ToString()
        {
            String display = "";

            for (int i = 0; i < itemPrice.Count(); i++)
            {
                Item b = (Item)itemPrice[i];
                display += "Item " + itemsString[i] + " R " + b.price + "\n";
            }

            display += "-------------------------" + "\n" +
            "TOTAL R " + getTotalPrice() + "\n" +
            "+ VAT R " + vat + "\n" +
            "-------------------------" + "\n" +
            "Grand Total: R " + (getTotalPrice() + vat) +
            "\n-------------------------" + "\n";


            return display;
        }
    }
}
