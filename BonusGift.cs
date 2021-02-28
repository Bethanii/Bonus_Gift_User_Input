/*
Assignment: Lab 1
Name: Bethany Hampton
Date: 1/14/2021
Describtion: Write and run C# code that takes a customer's first and last name,
company name, item purchased, quantity purchased, and cost of the item. 
Add a const variable for tax rate, and ask if item is taxable, 
and calculate total cost dependant on response. 
Output information in 4 linesthat includes all 7 variables.
 */
using System;
using static System.Console;
using System.Collections.Generic;
using static System.Convert;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp
{
    class Program
    {
        public const double tax_rate = (double)1.065M;
        static void Main(string[] args)
        {
            Write("Enter customer's first name: ");
            string FirstName = ReadLine();
            Write("Enter " + FirstName + "'s last name: ");
            string LastName = ReadLine();
            Write("Enter company name: ");
            string CompanyName = ReadLine();
            Write("Enter item purchased for " + CompanyName + ": ");
            string ItemPurchased = ReadLine();
            Write("Enter the quantity of the item(s) purchased: ");
            double ItemQuantity = Convert.ToDouble(ReadLine());
            Write("Enter the cost of each " + ItemPurchased + ": ");
            double ItemCost = Convert.ToDouble(ReadLine());
            Write("\nIs this item taxable?(Y or N) ");
            string Tax = ReadLine();
            double TaxedCost = Math.Round((ItemQuantity * ItemCost) * tax_rate, 2);
            double UntaxedCost = ItemQuantity * ItemCost;

            string TotalCost = Tax == "N" || Tax == "n" && Tax == "Y" || Tax == "y" ? TaxedCost.ToString() : UntaxedCost.ToString();
            string Output = CompanyName + "\n" + "Item Purchased: " + ItemPurchased + "\n" +
                               "Quantity and cost per each " + ItemPurchased + ": " + ItemQuantity +
                               " at " + ItemCost + " each \nTotal cost: " + TotalCost.ToString();

            Write(Output + "\n" + "Press any key to continue");
            ReadKey();
            Clear();

            string BonusGift = "Chose the bonus gift" + "\n" + "\t" + "1. Autographed book" + "\n" + "\t" +
                "2. Trophy" + "\n" + "\t" + "3. Taco Bell Gift Card" + "\n";
            Write(BonusGift);
            string BonusNumber = ReadLine();

            while (BonusNumber != "1" && BonusNumber != "2" && BonusNumber != "3")
            {
                Write("Try again, please enter a 1, 2, or 3     ");
                BonusNumber = ReadLine();
            }

            if (BonusNumber == "1")
            {
                string BonusChoice = "an autographed book";
                string BonusOutput = FirstName + " also gets " + BonusChoice + "\n" +
                     "Will be signed, Happy New Year " + FirstName + LastName;
                Write(BonusOutput);
            }
            else if (BonusNumber == "2")
            {
                string BonusChoice = "a trophy";
                string BonusOutput = CompanyName + " will recieve " + BonusChoice + "\n" + CompanyName + " is honored by " + FirstName;
                Write(BonusOutput);
            }
            else if (BonusNumber == "3")
            {
                string BonusChoice = "Taco Bell gift card";
                //string BonusOutput = "Congratulations " + FirstName + "!" + "\n" + "Enjoy your " + TotalCost.ToString() + " " + BonusChoice + ".";
                Write($"Congratulations  {FirstName}! \n Enjoy your {TotalCost.ToString("C")} {BonusChoice}");
                //Write(BonusOutput);
            }
        }
    }
}

