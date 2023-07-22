
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
        public static void RandomArray(int[] nums, int minValue = -10, int maxValue= 10)
        {
            Random rnd = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
               nums[i] = rnd.Next( minValue, maxValue+1);
            }
        }
        public static void SumPozitiveAndNegative(int[] array)
        {
            int sumotr=0;
            int sumpol=0;
            for (int i=0 ; i<array.Length;i++)
            {
                if (array[i]<0) 
                {sumotr+=array[i];}
                else 
                {sumpol+=array[i];}
            }
            Console.WriteLine($"Сумма отрицательных элементов = {sumotr}");
            Console.WriteLine($"Сумма положительных элементов = {sumpol}");
        }
        public static void TheOppositeArray(int[] array)
        {
             for (int i = 0; i<array.Length; i ++)
                {
                    array[i] = array[i]*(-1);
                }
        }
        public static void ProverkaNalichiyaChislaVMassive(int[] array, int m)
        {
            string bools = $"Число {m} НЕ содержится в массиве";
            MyMC.RandomArray(array, 0, 10);
            for (int i =0; i <array.Length; i++)
            {
                if (m == array[i]) bools = $"Число {m} содержится в массиве ";
                 
            }
            MyMC.PrintArray(array);
            Console.WriteLine(bools);
        }
        public static void CountNumbersOtrezok(int [] array, int minValue, int maxValue)
        {
            int count = 0;
            for (int i = 0; i <array.Length; i++)
            {
                if (array[i] > minValue && array[i]<maxValue)
                {
                    count+=1;
                }
            }
            MyMC.PrintArray(array);
            Console.WriteLine($"Количество элементов массива в отрезке от 10 до 99 = {count}");
        }
        public static int CountChet(int[] array)
        {
            int count = 0;
            for (int i=0; i < array.Length; i++)
            {
                if (array[i]%2==0) count +=1;
            }
            return count;
        }
        public static int SumNechetIndex(int[] array)
        {
            int sum = 0;
            for (int i=1; i < array.Length; i = i + 2)
            {
                sum =+ array[i];
            }
            return sum;
        }
    }
}