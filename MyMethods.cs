
using System;

namespace MyLib
{
    public static class MyMC
    {
        
        public static int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());

        }
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
        }
        public static void RndArray(int[] nums, int minValue, int maxValue)
            {
                Random rnd = new Random();

                for (int i = 0; i < nums.Length; i++)
                {
                   nums[i] = rnd.Next( minValue, maxValue+1);
                }
            }
        
    }
}
