using System;
using MyLib;
namespace seminar_5
{
    class DZ5
    {
        static void Main(string[] args)
        {
            void Task34()
            {
                int size = MyMC.Input("Введите размер массива: ");
                int[] numbers = new int[size];
                MyMC.RandomArray(numbers,100,1000);
                MyMC.PrintArray(numbers);
                Console.WriteLine($"Количество четных = {MyMC.CountChet(numbers)}");
            }
            Task34();
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
}

    