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

            Point point = new Point(x, y);
            Console.Write("Enter scalar: ");

            int a = NumberChecker();
            point.ScalarForXY = a;
            point.DisplayForScalar();

            Console.Write("Enter X2 number: ");
            int vectorX = NumberChecker();
            Console.Write("Enter Y2 number: ");
            int vectorY = NumberChecker();
            point.Vector(vectorX, vectorY);
            point.DisplayForVector();

            Console.ReadKey();
        }
    }

    class Point
    {
        private int x1;
        private int y1;
        private int scalar;
        private double b;
        private double c;

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

        public Point(int x1, int y1)
        {
            this.x1 = x1;
            this.y1 = y1;
        }

        public Point(){}

        public void Distance()
        {
            double lenght = x1 * x1 + y1 * y1;

            lenght = Math.Sqrt(lenght);

            Console.WriteLine($"Scalar for (x1, y1) lenght = { lenght }");
        }

        public int ScalarForXY
        {
            set
            {
                scalar = value;
                b = value * x1;
                c = value * y1;
            }
        }


        public void Vector(int a, int b)
        {
            x1 += a;
            y1 += b;
        }
        public void DisplayForVector()
        {
            Console.WriteLine($"Changing vector\nx1={ x1 }, y1={ y1 }");
        }

        public void DisplayForScalar ()
        {
            Console.WriteLine($"x1 = { x1 }, y1 = { y1 }");
            Distance();
        }
    }
}
