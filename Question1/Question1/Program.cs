using System;

namespace Question1
{
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
            Console.Write("Enter X number: ");

            int x = NumberChecker();
            Console.Write("Enter Y number: ");
            int y = NumberChecker();
            Point point = new Point(x, y);
            Console.Write("Enter scalar: ");

            int a = NumberChecker();
            point.ScalarForXY = a;
            point.Display();

            Console.ReadKey();
        }
    }

    class Point
    {
        private int x;
        private int y;
        private int scalar;
        private double b;
        private double c;


        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(){}

        public void Metod()
        {
            double lenght = x * x + y * y;
            lenght = Math.Sqrt(lenght);
            Console.WriteLine($"Vector lenght = { lenght }");
        }

        public int ScalarForXY
        {
            set
            {
                scalar = value;
                b = value * x;
                c = value * y;
            }
        }

        public void Display ()
        {
            Console.WriteLine($"X = { x }, Y = { y }");
            Metod();
            Console.WriteLine($"Scalar ({ b }, { c })");
        }
    }
}
