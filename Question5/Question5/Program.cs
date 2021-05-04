using System;

namespace Question5
{
    class Array
    {
        int[] arrayElement;

        public int n
        {
            get;
            private set;
        }

        public int scalar
        {
            private get { return scalar; }
            set
            {
                for (int i = 0; i < arrayElement.Length; i++)
                {
                    arrayElement[i] *= value;
                }
            }
        }

        public Array(int N)
        {
            n = N;
            arrayElement = new int[n];
        }

        public void arrayDisplay()
        {
            for (int i = 0; i < arrayElement.Length; i++)
            {
                Console.Write($"Array index {i} element = ");
                arrayElement[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void scalarDisplay()
        {
            Console.WriteLine("\nElements display");
            for (int i = 0; i < arrayElement.Length; i++)
            {
                Console.Write($"Array index {i} element = {arrayElement[i]}\n");
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
            Console.Write("Enter array length: ");
            int a = NumberChecker();
            Array array = new Array(a);
            array.arrayDisplay();
            array.scalarDisplay();
            Console.Write("\nEnter array scalar: ");
            int b = NumberChecker();
            array.scalar = b;
            array.scalarDisplay();
            Console.ReadKey();

        }
    }
}