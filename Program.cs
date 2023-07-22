
using System;
using MyLib;


namespace seminar_5
{
    class Program
    {
        //static void Main(string[] args)
        
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
                int size = 10;
                int[] numbers = new int[size];
                MyMC.RandomArray(numbers, 0, 2000);
                MyMC.CountNumbersOtrezok(numbers, 10, 99);
            }
            //Task35();
            void Task37()
            {
                int size = MyMC.Input("Введите размер массива: ");
                int[] numbers = new int[size];
                MyMC.RandomArray(numbers, 10, 20);
                MyMC.PrintArray(numbers);
                int size2=0;

                if (size%2 == 1)  size2 = size/2 +1;
                else  size2 = size/2;
                int[] numbers2 = new int[size2];
               
               for (int i = 0; i < numbers2.Length; i++)
               {
                    if (i == numbers.Length - 1 - i)  numbers2[i] = numbers[i];
                    else numbers2[i] = numbers[i] * numbers[(numbers.Length - 1 - i)];

               }
                MyMC.PrintArray(numbers2);
            }
            //Task37();
            void Task34()
            {
                int size = MyMC.Input("Введите размер массива: ");
                int[] numbers = new int[size];
                MyMC.RandomArray(numbers,100,999);
                MyMC.PrintArray(numbers);
                Console.WriteLine($"Количество положительных чисел = {MyMC.CountChet(numbers)}");
            }
            //Task34();
            void Task36()
            {
                int size = MyMC.Input("Введите размер массива: ");
                int[] numbers = new int[size];
                MyMC.RandomArray(numbers,1,10);
                MyMC.PrintArray(numbers);
                Console.WriteLine($"Сумма Элементов с нечетными индексами = {MyMC.SumNechetIndex(numbers)}");
            }
            //Task36();
            void Task38()
            {
                //Задайте массив вещественных чсисел. найдите разницу между максимальным и минимальным элементов массива
                int size = MyMC.Input("Введите размер массива: ");
                double[] numbers = new double[size];
                MyMC.DoubleRandomArray(numbers, 1, 20);
                MyMC.DoublePrintArray(numbers);               
                Console.WriteLine($"Разница между максимальным числом {MyMC.MaxArray(numbers)} и минимальным числом {MyMC.MinArray(numbers)} = {MyMC.MaxArray(numbers)- MyMC.MinArray(numbers)}");
            }
            //Task38();
        
            
        
    }
}
