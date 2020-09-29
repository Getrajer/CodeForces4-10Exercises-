using System;

namespace RequiredRemider
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] answers = new int[n];

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                int x = Convert.ToInt32(input[0]);
                int y = Convert.ToInt32(input[1]);
                int m = Convert.ToInt32(input[2]);

                int mod = m % x;

                if(mod - y >= 0)
                {
                    m = m - (mod - y);
                }
                else
                {
                    m = m - mod - x + y;
                }

                answers[i] = m;

            }

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(answers[i]);
            }

        }
    }
}
