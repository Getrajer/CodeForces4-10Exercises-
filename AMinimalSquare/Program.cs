using System;

namespace AMinimalSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] solutions = new int[n];


            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                int a = Convert.ToInt32(input[0]);
                int b = Convert.ToInt32(input[1]);

                if (a > 2 * b)
                {
                    solutions[i] = a * a;
                }
                else if(b > a * 2)
                {
                    solutions[i] = b * b;
                }
                else if(a < b)
                {
                    a = a + a;
                    solutions[i] = a * a;
                }
                else
                {
                    b = b + b;
                    solutions[i] = b * b;
                }
            }

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(solutions[i]);
            }

        }
    }
}
