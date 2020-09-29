using System;

namespace AHolidayOfEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            int[] numbers = new int[n];

            for(int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt32(input[i]);
            }

            input = new string[0];

            Array.Sort(numbers);
            int max = numbers[numbers.Length - 1];
            int spending = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] != max)
                {
                    spending += max - numbers[i];
                }
            }

            Console.WriteLine(spending);

        }
    }
}
