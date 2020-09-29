using System;

namespace TheNewYear_MeetingFriends
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] numbers = new int[input.Length];

            for(int i = 0; i < input.Length; i++)
            {
                numbers[i] = Convert.ToInt32(input[i]);
            }

            Array.Sort(numbers);

            Console.WriteLine(numbers[2] - numbers[0]);
        }
    }
}
