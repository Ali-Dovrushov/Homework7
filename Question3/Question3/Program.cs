using System;

namespace Question3
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
            Console.Write("Enter A side = ");
            int a = NumberChecker();
            Console.Write("Enter B side = ");
            int b = NumberChecker();

            Rectangle rectangle = new Rectangle(a , b);
            rectangle.Display();

            Console.ReadKey();
        }
    }

    class Rectangle
    {
        private int a;
        private int b;

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int B
        {
            get { return b; }
            set { b = value; }
        }

        public bool isSquared
        {
            get
            {
                if (A == B)
                {
                    return true;
                }
                return false;
            }
            private set { }
        }

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void Perimetr()
        {
            if (isSquared == true)
            {
                Console.WriteLine("It's not a rectangle, it's a squared");

                int perimetr = 2 * (A + B);
                Console.WriteLine($"Perimeter = { perimetr }");
            }
            else
            {
                int perimetr = 2 * (A + B);
                Console.WriteLine($"Perimeter = { perimetr }");

            }
        }

        public void Area()
        {           
            int area = A * B;
            Console.WriteLine($"Area = { area }");
        }

        public void Display()
        {
            Perimetr();
            Area();
        }
    }
}
