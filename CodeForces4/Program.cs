using System;

namespace AShortSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] strings = new string[n];

            for(int i = 0; i < n; i++)
            {
                strings[i] = Console.ReadLine();
            }

            string[] solutions = new string[n];

            for(int i = 0; i < n; i++)
            {
                string solution = "";
                bool every_second_one = true;
                for(int j = 0; j < strings[i].Length; j++)
                {
                    if(every_second_one == true)
                    {
                        if (j == 0)
                        {
                            solution += strings[i][0];
                            solution += strings[i][1];
                            j++;
                            every_second_one = false;
                        }
                        else
                        {
                            solution += strings[i][j];
                            every_second_one = false;
                        }
                    }
                    else
                    {
                        every_second_one = !every_second_one;
                    }

                }

                Console.WriteLine(solution);
            }
        }
    }
}
