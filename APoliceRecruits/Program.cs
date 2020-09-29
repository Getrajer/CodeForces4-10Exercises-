using System;

namespace APoliceRecruits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] cases = Console.ReadLine().Split();

            int count = 0;
            int officers = 0;

            for(int i = 0; i < cases.Length; i++)
            {
                if(cases[i] == "-1")
                {
                    if (officers > 0)
                    {
                        officers--;
                    }
                    else
                    {
                        count++;
                    }
                }
                else
                {
                    int o = Convert.ToInt32(cases[i]);
                    officers += o;
                }
            }

            if(count > 0)
            {
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
