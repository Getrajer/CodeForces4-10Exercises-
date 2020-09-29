using System;

namespace TwoArraysAndSwaps
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] soulutions = new int[n];
            int[] results = new int[n];

            for(int i = 0; i < n; i++)
            {
                string[] input1 = Console.ReadLine().Split();
                string[] a_string = Console.ReadLine().Split();
                string[] b_string = Console.ReadLine().Split();

                int arr_l = Convert.ToInt32(input1[0]);
                int moves = Convert.ToInt32(input1[1]);

                int[] a_array = new int[arr_l];
                int[] b_array = new int[arr_l];


                for(int j = 0; j < arr_l; j++)
                {
                    a_array[j] = Convert.ToInt32(a_string[j]);
                    b_array[j] = Convert.ToInt32(b_string[j]);
                }

                a_string = new string[0];
                b_string = new string[0];


                Array.Sort(a_array);
                Array.Sort(b_array);

                bool a_biggest = false;

                int c = 0;
                int b = b_array.Length - 1;
                while(a_biggest == false)
                {
                    if (moves == 0)
                    {
                        break;
                    }

                    if (a_array[c] < b_array[b])
                    {
                        int temp = a_array[c];
                        a_array[c] = b_array[b];
                        b--;
                        c++;
                        moves--;
                    }
                    else
                    {
                        a_biggest = true;
                    }
                }

                int sum = 0;

                for(int j = 0; j < a_array.Length; j++)
                {
                    sum += a_array[j];
                }

                soulutions[i] = sum;
            }

            for(int i = 0; i < soulutions.Length; i++)
            {
                Console.WriteLine(soulutions[i]);
            }

        }
    }
}
