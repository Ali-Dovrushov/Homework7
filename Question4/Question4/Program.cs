using System;

namespace Question4
{
    class Money
    {
        private int first; // nominal
        private int second; // kolicestvo

        public Money(int first, int second)
        {
            this.first = first;
            this.second = second;
        }

        public int First
        {
            get { return first; }
            set { first = value; }
        }

        public int Second
        {
            get { return second; }
            set { second = value; }
        }

        public int TotalMoney
        {
            get { return First + Second; }
            private set { }
        }

        public bool MoneyCheckerForPrice(int first, int second, int price)
        {
            bool moneyChecker = false;
            if (first * second > price)
            {
                Console.WriteLine("You have enought money");
                moneyChecker = true;
            }
            else if (first * second < price)
            {
                Console.WriteLine("Youu have not enought money.");
            }
            return moneyChecker;
        }

        public void InfoAmount()
        {
            Console.WriteLine($"You have { second } bill, { first }$ = { second * first }$");
        }

        public void Price(int first, int second, int price, bool booller)
        {
            if (booller == true)
            {
                int howMuch = (first * second) / 2;
                Console.WriteLine($"You can buy { howMuch } picec");
            }
        }

        
    }

    class Program
    {
        static int NumberChecker()
        {
            int number;

            for (; ; )
            {
                string numberInString = Console.ReadLine();

                if (Int32.TryParse(numberInString, out number))
                {
                    return number;
                }

                else
                {
                    Console.Write("Incorrect number, please enter again: ");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter dollar: ");
            int bill = NumberChecker();

            Console.Write("Enter bill: ");
            int dollar = NumberChecker();

            Console.Write("Enter price: ");
            int price = NumberChecker();

            Money money = new Money(bill, dollar);
            money.InfoAmount();
            bool result = money.MoneyCheckerForPrice(bill, dollar, price);
            money.Price(bill, dollar, price, result);

            Console.ReadKey();
        }
    }
}
