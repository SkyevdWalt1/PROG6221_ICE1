//EMMANUEL OGUNDIRAN
//STUDENT NUMBER: ST10085103
using System;
using System.Collections.Generic;

namespace prjVatAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> itemPrice = new List<Item>();
            List<double> itemVat = new List<double>();
            String[] itemsString = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };


            String check = "";
            int i = 0;
            while (i < 26 && check != "x")
            {
                try
                {
                    Console.WriteLine("Enter price of Item " + itemsString[i] + ", or press 'x' to exit.");
                    check = Console.ReadLine();
                    if (check == "x")
                    {
                        Console.WriteLine("Iteration ends..." + "\n");
                    }
                    else
                    {
                        Item obj = new Item(Convert.ToInt32(check));
                        itemPrice.Add(obj);

                        itemVat.Add(obj.calculateVat());
                        ++i;
                    }
                }
                catch
                {
                    Console.WriteLine("Error in input provided!");
                }
            }

            Cart secondObj = new Cart(itemPrice, itemsString);
            Console.WriteLine(secondObj.ToString());
        }
    }
}
