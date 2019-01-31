using System;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var method1 = new Program();
            Console.WriteLine(method1.factorial(10));
        }

        int factorial(int numeric)
        {
            int tmp = numeric - 1;

            if (tmp == 1)
            {
                return numeric;
            }
            else
            {
                return this.factorial(tmp) * numeric;
            }
        }
    }
}
