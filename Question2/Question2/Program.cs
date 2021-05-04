using System;

namespace Question2
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

            Console.Write("Enter A = ");
            int a = NumberChecker();

            Console.Write("Enter B = ");
            int b = NumberChecker();

            Console.Write("Enter C = ");
            int c = NumberChecker();

            Triangle triangle = new Triangle(a,b,c);

            triangle.Display();

            Console.ReadKey();
        }
    }

    class Triangle
    {
        private int a;
        private int b;
        private int c;

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

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

        public int C
        {
            get { return c; }
            set { c = value; }
        }

        public bool TriangleChecker
        {
            get
            {
                if (a + b > c && a + c > b && b + c > a)
                {
                    return true;
                }
                return false;
            }
        }

        public void CalcPerimeter()
        {
            if (TriangleChecker == true)
            {
                int perimetr = a + b + c;
                Console.WriteLine($"\nPerimeter = { perimetr }");
            }
            else
            {
                Console.WriteLine("\nTriangle with this side cannot be.");
            }
        }

        public void CalcArea()
        {
            if (TriangleChecker == true)
            {
                double p = (double)(a + b + c) / 2;
                double area = (double)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine($"Area = { area }");
            }
        }

        public void Display()
        {
            Console.Write($"Side\nA = { a }\nB = { b }\nC = { c }");
            CalcPerimeter();
            CalcArea();
        }
    }
}