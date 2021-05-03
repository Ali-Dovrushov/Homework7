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
            Triangle triangle = new Triangle();

            Console.Write("Enter A = ");
            triangle.A = NumberChecker();

            Console.Write("Enter B = ");
            triangle.B = NumberChecker();

            Console.Write("Enter C = ");
            triangle.C = NumberChecker();

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

            if (a + b < c && b + c < a && a + c < b)
            {
                Console.WriteLine("Trinagle with this sides can't possible");
            }
        }

        public Triangle()
        {

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

        //public string TriangleChecker
        //{
        //    get
        //    {
        //        return "Trinagle with this sides can't possible";
        //    }
        //    private set
        //    {
        //        if (a + b < c && b + c < a && a + c < b)
        //        {
        //            string a = value;
        //        }
        //    }
        //}

        public void CalcPerimeter()
        {
            int perimetr = a + b + c;
            Console.WriteLine($"\nPerimeter = { perimetr }");
        }

        public void CalcArea()
        {
            double p = (a + b + c) / 2;
            double area = p * (p - a) * (p - b) * (p - c);
            area = Math.Sqrt(area);
            int test = Convert.ToInt32(area);
            Console.WriteLine($"Area = { test }");
        }

        public void Display()
        {
            Console.Write($"Side\nA = { a }\nB = { b }\nC = { c }");
            CalcPerimeter();
            CalcArea();
        }
    }
}
