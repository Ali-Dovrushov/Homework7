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
        private bool triangleChecker;

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            if ((a + b) > c && (a + c) > b && (b + c) > a)
            {
                triangleChecker = true;
                Console.WriteLine("srabotal");
            }
            else
            {
                triangleChecker = false;
            }
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
                return triangleChecker;
            }
        }

        public void CalcPerimeter()
        {
            int perimetr = a + b + c;
            Console.WriteLine($"\nPerimeter = { perimetr }");
        }

        public void CalcArea()
        {
            double p = (double)(a + b + c) / 2;
            Console.WriteLine(p);

            double area = (double)Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            if (triangleChecker == true)
            {
                Console.WriteLine("Triangle with this sides cannot be.");
            }

            else
            {
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