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
            Console.Write("Enter X1 number: ");
            int x = NumberChecker();

            Console.Write("Enter Y1 number: ");
            int y = NumberChecker();

            Console.Write("Enter X2 number: ");
            int x2 = NumberChecker();

            Console.Write("Enter Y2 number: ");
            int y2 = NumberChecker();

            Point point = new Point(x, y, x2, y2);
            Console.Write("Enter scalar: ");

            int a = NumberChecker();
            point.ScalarForXY = a;
            point.Display();

            Console.ReadKey();
        }
    }

    class Point
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        private int scalar;
        private double b;
        private double c;
        private double d;
        private double e;


        public int X1
        {
            get { return x1; }
            set { x1 = value; }
        }

        public int Y1
        {
            get { return y1; }
            set { y1 = value; }
        }

        public int X2
        {
            get { return x2; }
            set { x2 = value; }
        }

        public int Y2
        {
            get { return y2; }
            set { y2 = value; }
        }

        public Point(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public Point(){}

        public void Metod()
        {
            double lenght = x1 * x1 + y1 * y1;
            double lenght1 = x2 * x2 + y2 * y2;

            lenght = Math.Sqrt(lenght);
            lenght1 = Math.Sqrt(lenght1);

            Console.WriteLine($"Vector for (x1, y1)lenght = { lenght }");
            Console.WriteLine($"Vector for (x2, y2)lenght = { lenght1 }");
        }

        public int ScalarForXY
        {
            set
            {
                scalar = value;
                b = value * x1;
                c = value * y1;
                d = value * x2;
                e = value * y2;
            }
        }

        public void Display ()
        {
            Console.WriteLine($"X1 = { x1 }, Y1 = { y1 }, X2 = { x2 }, Y2 = { y2 }");
            Metod();
            Console.WriteLine($"Scalar ({ b }, { c }, { d }, { e })");
        }
    }
}
