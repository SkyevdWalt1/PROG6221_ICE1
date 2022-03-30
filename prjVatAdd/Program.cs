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
            List<double> price = new List<double>();
            String[] itemsString = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L","M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
            String check = ""; 
            int i = 0;
            while (i<26 && check != "x") {
                try
                {
                    Console.WriteLine("Enter price of Item " + itemsString[i]+ ", or press 'x' to exit.");
                    check = Console.ReadLine();
                    if (check == "x")
                    {
                        Console.WriteLine("Iteration ends..."+"\n");
                    }
                    else {
                        price.Add(Convert.ToInt32(check));
                        ++i;
                    }
                }
                catch {
                    Console.WriteLine("Error in input provided!");
                }
            }

            Item firstObj = new Item(price, itemsString);
            Cart secondObj = new Cart(price, itemsString, firstObj.calculateVat());

            Console.WriteLine(secondObj.ToString());
        }
    }
}
