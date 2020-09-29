using System;

namespace GiftsFixing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] answers = new int[n];

            for(int i = 0; i < n; i++)
            {
                int pn = Convert.ToInt32(Console.ReadLine());
                string[] inputa = Console.ReadLine().Split();
                string[] inputb = Console.ReadLine().Split();

                int[] a_array = new int[pn];
                int[] b_array = new int[pn];

                int a_min = 0;
                int b_min = 0;

                for(int j = 0; j < pn; j++)
                {
                    if(j == 0)
                    {
                        a_min = Convert.ToInt32(inputa[i]);
                        b_min = Convert.ToInt32(inputb[i]);
                    }
                    else
                    {
                        if(a_min > Convert.ToInt32(inputa[i]))
                        {
                            a_min = Convert.ToInt32(inputa[i]);
                        }

                        if(b_min > Convert.ToInt32(inputb[i]))
                        {
                            b_min = Convert.ToInt32(inputb[i]);
                        }
                    }

                    a_array[i] = Convert.ToInt32(inputa[i]);
                    b_array[i] = Convert.ToInt32(inputb[i]);
                }

                int moves = 0;

                for(int j = 0; j < pn; j++)
                {
                    while(a_array[j] != a_min && b_array[i] != b_min)
                    {
                        if (a_array[j] > a_min && b_array[i] > b_min)
                        {
                            if(a_array[j] - a_min == b_array[j] - b_min)
                            {
                                moves += a_array[j] - a_min;
                                a_array[j] -= -a_min + a_array[j];
                                b_array[j] -= -b_min + a_array[j];
                            }
                            else if(a_array[j] - a_min < b_array[j] - b_min)
                            {
                                moves += a_array[j] - a_min;
                                a_array[j] -= -a_min + a_array[j];
                                b_array[j] -= -a_min + a_array[j];
                            }
                            else
                            {
                                moves += b_array[j] - b_min;
                                a_array[j] -= -b_min + b_array[j];
                                b_array[j] -= -b_min + b_array[j];
                            }
                        }
                        else if(a_array[j] > a_min)
                        {
                            moves += -a_min + a_array[j];
                            a_array[j] -= -a_min + a_array[j];
                        }
                        else if(b_array[j] > b_min)
                        {
                            moves += -b_min + b_array[j];
                            b_array[j] -= -b_min + b_array[j];
                        }
                    }
                }

                answers[i] = moves;

            }

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(answers[i]);
            }
        }
    }
}
