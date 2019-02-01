using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 第一題 */
            // new Program().factorial(10);

            /* 第二題 */
            // new Program().minArray(new List<int[]> {
            //         new int[] {1, 23, 43, 97, 345},
            //         new int[] {190, 123, 3, 917, 345},
            //         new int[] {981, 243, 3, 97, 345},
            //         new int[] {121, 283, 4903, 15, 345},
            //         new int[] {2331, 2, 42, 354, 67545},
            //     });

            /* 第三題 */
            // new Program().diagonal(new List<int[]> {
            //         new int[] {1, 23, 43, 97, 345},
            //         new int[] {190, 123, 3, 917, 345},
            //         new int[] {981, 243, 3, 97, 345},
            //         new int[] {121, 283, 4903, 15, 345},
            //         new int[] {2331, 2, 42, 354, 67545},
            //     });

            /* 第四題 */
            // new Program().monkeyQue(10);

            /* 第五題 */
            // new Program().countWord("This is a Apple");

            /* 第六題 */
            // new Program().stringCompare("Abcdefg", "gfasee");

            /* 第七題 */
            // new Program().isEven(50);

            /* 第十題 */
            new Program().isUglyNumber(51);
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
        void minArray(List<int[]> twoArray)
        {
            foreach (var item in twoArray)
            {
                Console.WriteLine(item.Min());
            }
        }

        void diagonal(List<int[]> twoArray)
        {
            int sum = 0;
            for (int i = 0; i < twoArray.Count; i++)
            {
                sum += twoArray[i][i];
            }
            Console.WriteLine($"sum:{sum}");
        }
        void monkeyQue(int day)
        {
            int peach = 1;
            for (int i = 0; i < day; i++)
            {
                peach = (peach + 1) * 2;
            }
            Console.WriteLine($"peach:{peach}");
        }

        void countWord(string str)
        {
            Console.WriteLine($"Word count:{str.Split(" ").Count()}");
        }

        void stringCompare(string str1, string str2)
        {
            Console.WriteLine($"String equal:{this.characterCalculator(str1) == this.characterCalculator(str2)}");
        }

        private int characterCalculator(string str)
        {
            byte[] result = Encoding.ASCII.GetBytes(str);
            return result.Sum(i => i);
        }

        void isEven(int numeric)
        {
            Console.WriteLine($"{(numeric % 2) == 0}");
        }

        void isUglyNumber(int numeric)
        {
            bool result = false;
            int tmp = numeric;
            if(tmp > 0) {
                while (tmp % 2 == 0) {
                    tmp = tmp / 2;
                }
                while (tmp % 3 == 0) {
                    tmp = tmp / 3;
                }
                while (tmp % 5 == 0) {
                    tmp = tmp / 5;
                }
            }
            result = tmp == 1;
            Console.WriteLine($"Numeric {numeric} {(result ?"": "not")} is ugly number");
        }
    }
}
