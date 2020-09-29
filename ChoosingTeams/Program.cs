using System;

namespace ChoosingTeams
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split();
            string[] input2 = Console.ReadLine().Split();

            int n = Convert.ToInt32(input1[0]);
            int tp = Convert.ToInt32(input1[1]);
            int pm = 0;

            for(int i = 0; i < n; i++)
            {
                int number = Convert.ToInt32(input2[i]);

                if(number + tp <= 5)
                {
                    pm++;
                }
            }

            while(pm%3 != 0)
            {
                pm--;
            }

            Console.WriteLine(pm / 3);

        }
    }
}
