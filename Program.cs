using System;

namespace Euler_1_3
{
    class Euler
    {
        static void Main()
        {
            Console.WriteLine(Euler.Task1());
            Console.WriteLine(Euler.Task2());
            Console.WriteLine(Euler.Task3());
        }

        static int Task1()
        {
            int summ = 0;
            for (int i = 3; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    summ += i;
            }
            return summ;
        }

        static int Task2()
        {
            int first = 1, second = 1, summ = 0;
            while (second < 4000000)
            {
                second += first;
                first = second - first;
                if (first % 2 == 0)
                    summ += first;
            }
            return summ;
        }

        static long Task3()
        {
            long div = 2, num = 600851475143;
            while (num > div)
            {
                if (num % div == 0)
                    num /= div;
                else
                    div++;
            }
            return div;
        }
    }
}
