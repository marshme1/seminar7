using System;
using MyLib;
namespace seminar_5
{
    class DZ5
    {
        
        static void Main(string[] args)
        {
            void Task41_1()
            {
                
                int count = 0;
                string str = " ";
                while (count>=0)
                {
                     Console.WriteLine("Введите число. Чтобы прекратить вводить числа, введите символ, отличный от цифр ");
                     str = Console.ReadLine();
                     int j = 0;
                     var isNumeric = int.TryParse(str, out j); //Проверяет, состоит ли строка только из цифр
                    
                     if (!isNumeric) //Если в строке присутствуют символыЮ отличные от цифр, то прекращает цикл
                     {
                        break;
                     }
                     
                     int num = Convert.ToInt32(str);
                     if (num>0) count +=1;

                }
                Console.WriteLine($"Количество введенных вами чисел больше 0 = {count}");
            }
           
            //Task41_1();

            void Task43()
            {
                //Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями y = k1*x +b1 и y = k2*x +b2, значения задаются пользователем
                double k1 = MyMC.Input("Введите k1 для уравнения первой прямой y = k1*x +b1 ");
                double b1 = MyMC.Input("Введите b1 для уравнения первой прямой y = k1*x +b1 ");
                double k2 = MyMC.Input("Введите k2 для уравнения второй прямой y = k2*x +b2 ");
                double b2 = MyMC.Input("Введите b2 для уравнения второй прямой у = k2*x +b2 ");
                
                if (k2 != k1)
                {
                    double x = (b1-b2)/(k1-k2) * (-1);
                    double y = k1*x + b1;
                    Console.WriteLine($"Точка пересечения двух прямых обладает координатами: ({x} {y}) ");
                }
                else  Console.WriteLine($"Точки пересечения двух прямых с заданными переменными не существует ");
            }
            //Task43();

            
            //Console.Clear();
            
            
           // Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
            void Task47()
            {
                //Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
                int m = MyMC.Input("Введите размер строки массива: ");
                int n = MyMC.Input("Введите размер столбца массива: ");
                double [,] Array = new double[m,n];
                Random random = new Random();
                for (int i = 0; i<Array.GetLength(0); i++)
                {
                    for (int j = 0; j<Array.GetLength(1); j++)
                    {
                        Array[i,j] = random.Next(-100,100) + Math.Round(random.NextDouble(),1);
                    }
                }
                MyMC.PrintDoubleArray(Array);
            }
            //Task47();
            void Task52() //задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
            {
                int m = MyMC.Input("Введите количество строк массива: ");
                int n = MyMC.Input("Введите количество столбцов массива: ");
                int[,] Array = new int[m,n];
                MyMC.FillArray(Array);
                MyMC.PrintArray(Array);
                Console.WriteLine("Среднее арифместическое в каждом столбце:");
                for(int i=0; i<n;i++)
                {
                    Console.Write("_______");
                }
                Console.WriteLine();
                Console.WriteLine("Номер столбца:");
                for(int i=1; i<=n;i++)
                {
                    Console.Write($"{i} \t");
                }
                Console.WriteLine();
                int sum = 0;
                Console.WriteLine("Среднее арифместическое в каждом столбце:");
                for (int i=0;i<n;i++)
                { 

                   for (int j=0;j<m;j++) 
                   {
                        sum +=Array[j,i];
                   }
                    Console.Write($"{sum} \t");
                    sum=0;
                }

            }
            //Task52();
            void Task50()
            {
                int sizeRows = MyMC.Input("Введите количество строк массива: ");
                int sizeColumns = MyMC.Input("Введите количество столбцов массива: ");
                int[,] Array = new int[sizeRows,sizeColumns];
                MyMC.FillArray(Array);
                MyMC.PrintArray(Array);
                int indexRows = MyMC.Input("Введите индекс строки массива: ");
                int indexColumns = MyMC.Input("Введите идекс столбца массива: ");

                if (indexRows>=sizeRows || indexColumns>=sizeColumns)
                {
                    Console.WriteLine("Такого элемента в массиве нет");
                }
                else
                {
                    Console.WriteLine(Array[indexRows,indexColumns]);
                }
            }
            //Task50();
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
            void Task54()
            {
                int sizeRows = MyMC.Input("Введите количество строк массива: ");
                int sizeColumns = MyMC.Input("Введите количество столбцов массива: ");
                int[,] array = new int[sizeRows,sizeColumns];
                MyMC.FillArray(array);
                MyMC.PrintArray(array);
                int [] temp = new int[sizeColumns];
                for (int i = 0; i<array.GetLength(0);i++)
                {
                    for (int j = 0; j<array.GetLength(1);j++)
                    {
                        temp[j] = array[i,j];
                    }
                    //MyMC.PrintArray(temp);
                    Array.Sort(temp);
                    Array.Reverse(temp);
                    //MyMC.PrintArray(temp);
                    for (int k = 0; k<array.GetLength(1);k++)
                    {
                        array[i,k]=temp[k];
                    }
                }
                Console.WriteLine();
                MyMC.PrintArray(array);
                
            }
            //Task54();
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
//строку с наименьшей суммой элементов.
            void Task56()
            {
                int sizeRows = MyMC.Input("Введите количество строк массива: ");
                int sizeColumns = sizeRows;
                int[,] array = new int[sizeRows,sizeColumns];
                MyMC.FillArray(array);
                MyMC.PrintArray(array);
                int indexRows=0;
                int minIndex=0;
                int minSum=0;
                int sum=0;
                for (int i = 0; i<array.GetLength(0); i++)
                {
                    indexRows=i;
                    for (int j = 0; j<array.GetLength(1); j++)
                    {
                        sum +=array[i,j];
                    }
                    //Console.WriteLine(sum);

                    if (i==0) 
                    {
                        minSum=sum;
                    }
                    if (minSum>sum)
                    {
                        minSum=sum;
                        minIndex = indexRows;
                    }
                    sum=0;

                }
                Console.WriteLine($"Строка с наименьшей суммой элементов: {minIndex}");
            }
            //Task56();
                //Задача 58: Заполните спирально массив 4 на 4 числамт от 1 до 16.
            void Task58()
            {
                int sizeRows = MyMC.Input("Введите количество строк массива: ");
                int sizeColumns = MyMC.Input("Введите количество столбцов массива: ");
                int[,] array = new int[sizeRows,sizeColumns];
                
                int m=0;
                int i=0;
                int j=0;
                int offsetTop=0;
                int offsetRight=0;
                int offsetLeft=0;
                int offsetLow=0;
                int br=0;
                //while(br!=2)
                while (true)
                {
                    while (true)
                    {
                        m++;
                        array[i,j]=m;
                        j+=1;
                        if (j>(sizeColumns-1-offsetRight))  break;
                        

                    }
                    //i+=1;
                    offsetTop+=1;
                    while (true)
                    {
                        m++;
                        array[i,j]=m;
                        i+=1;
                        if (i>(sizeRows-1-offsetLow)) break;
                        //if (i==(sizeRows-1)) break;
                        //i+=1;

                    }
                    //j-=1;
                    offsetRight+=1;
                    while (true)
                    {
                        m++;
                        array[i,j]=m;
                        j-=1;
                        if (j>(0+offsetLeft)) break;
                        //j-=1;

                    }
                    //i-=1;
                    offsetLeft+=1;
                    while (true)
                    {
                        m++;
                        array[i,j]=m;
                        i-=1;
                        if (i>(0+offsetTop))  break;
                        //i-=1;

                    }
                    //if (sizeColumns%2==0 && sizeRows%2==0) if (i==sizeRows/2 && j == sizeColumns/2+1) break;
                    //else if (i==sizeRows/2 +1  && j == sizeColumns/2+1) break;
                    //Console.WriteLine($"{i} {j}");
                    offsetLow+=1;
                    if (sizeColumns%2==0 && sizeRows%2==0) if (i==(sizeRows/2) && j == (sizeColumns/2-1)) break;
                    
                    //if (i==sizeRows/2 && j == sizeColumns/2+1) break;
                    //if (sizeColumns%2==0 && sizeRows%2==0) if (i==sizeRows/2 && j == sizeColumns/2-1) break;
                    //else if (i==sizeRows/2-1  && j == sizeColumns/2+1) break;
                    //br+=1;
                    MyMC.PrintArray(array);
                    Console.WriteLine();
                    Console.WriteLine($"{offsetTop} {offsetRight} {offsetLow} {offsetLeft}");
                    Console.WriteLine($"{i} {j}");
                }
                //MyMC.PrintArray(array);
            }
            Console.Clear();
            Task58();



        } 
          

        
        
    }
}           

    