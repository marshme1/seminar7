
using System;
using MyLib;


namespace seminar_5
{
    class Program
    {
        static void Main(string[] args)
        {
             void Task31()
            {
                int size = MyMC.Input("Введите размер массива: ");
                int[] nums = new int[size];
                
                MyMC.RandomArray(nums, -9, 10);
                MyMC.SumPozitiveAndNegative(nums);
                MyMC.PrintArray(nums);
            }
            //Task31();
            void Task32()
            {
                int size = MyMC.Input("Введите размер массива: ");
                int[] numbers = new int[size];

                MyMC.RandomArray(numbers, -20, 20);
                MyMC.PrintArray(numbers);

                MyMC.TheOppositeArray(numbers);
                Console.WriteLine("Противположный массив =");
                MyMC.PrintArray(numbers);
            }
            //Task32();
            //Задате массив. Напишите программу, котрая определяет, присутсвует ли заданноечисло в массиве
            void Task33()
            {
                int size = MyMC.Input("Введите размер массива: ");
                int[] numbers = new int[size];
                Console.WriteLine("Введите число");
                int num = Convert.ToInt32(Console.ReadLine());
               
                MyMC.ProverkaNalichiyaChislaVMassive(numbers, num);
            }
            //Task33();
            void Task35()
            {
                int size = 10
                int[] numbers = new int[size];
                MyMC.RandomArray(numbers, 0, 1000);
                int count = 0;
                for (int i = 0; i <numbers.Length; i++)
                {
                    if (numbers[i] > 10 && numbers[i]<99)
                    {
                        count+=1;
                    }
                }
                Console.WriteLine(count);
            }
            Task35();
        }
            
        
    }
}
