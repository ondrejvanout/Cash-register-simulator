using System;
using System.Security.Cryptography;
using Microsoft.VisualBasic.CompilerServices;

namespace CashRegisterSimulator
{
    public class Round
    {
        private const int PRICE_MAX = 2000;
        private const int PRICE_MIN = 45;
        private const int BILL_MAX = 5000;
        private const int TIP_MAX = 50;
        private const int TIP_MIN = 0;
        
        private Random random = new Random();
        
        private int priceOfSelectedItems;
        public int PriceOfSelectedItems
        {
            get { return priceOfSelectedItems; }
            set { priceOfSelectedItems = value; }
        }

        private int moneyGiven;
        public int MoneyGiven
        {
            get { return moneyGiven; }
            set { moneyGiven = value; }
        }

        private int tip;
        public int Tip
        {
            get { return tip; }
            set { tip = value; }
        }

        private int returnMoney;
        public int ReturnMoney
        {
            get { return returnMoney; }
            set { returnMoney = value; }
        }

        public Round()
        {
            PriceOfSelectedItems = random.Next(PRICE_MIN, PRICE_MAX + 1);
            MoneyGiven = random.Next(PriceOfSelectedItems, BILL_MAX + 1);
            Tip = random.Next(TIP_MIN, TIP_MAX + 1);
            returnMoney = MoneyGiven - (PriceOfSelectedItems + Tip);
        }

        /*
         * Write all values to the console for user
         */
        public void PromptRoundToUser()
        {
            string prompt = $"Price of selected item is \x1b[1m{PriceOfSelectedItems},-\x1b[0m\n" +
                $"User has given \x1b[1m{MoneyGiven},-\x1b[0m\n" +
                $"Tip is \x1b[1m{Tip},-\x1b[0m\n";
            
            Console.WriteLine(prompt);
        }

        public override string ToString()
        {
            return $"Price of selected item: {PriceOfSelectedItems}\n" +
                   $"Money given: {MoneyGiven}\n" +
                   $"Tip: {Tip}\n";
        }
    }
}