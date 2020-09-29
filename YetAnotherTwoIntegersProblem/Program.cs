using System;

namespace YetAnotherTwoIntegersProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                int a = Convert.ToInt32(input[0]);
                int b = Convert.ToInt32(input[1]);

                int moves = 0;

                while(a != b)
                {
                    if (a > b)
                    {
                        if (a - 10 >= b)
                        {
                            a -= 10;
                            moves++;
                        }
                        else
                        {
                            a -= a - b;
                            moves++;
                        }
                    }
                    else
                    {
                        if(a + 10 <= b)
                        {
                            a += 10;
                            moves++;
                        }
                        else
                        {
                            a += b - a;
                            moves++;
                        }
                    }
                   
                }

                Console.WriteLine(moves);
            }

        }
    }
}
