using System;
using MyLib;
namespace seminar_5
{
    class DZ5
    {
        
        static void Main(string[] args)
        {
            
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
                int sizeRows = MyMC.Input("Введите четное количество строк и столбцов массива: ");
                int sizeColumns = sizeRows;
                //int sizeColumns = MyMC.Input("Введите четное количество столбцов массива: ");
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
                while (m != sizeRows*sizeColumns )
                {
                    while (true)
                    {
                        m++;
                        array[i,j]=m;
                        j+=1;
                        //Console.WriteLine($"i={i}, j={j}, m={m}");
                        if (j==(sizeColumns-1-offsetRight) || j<0)  break;
                        
                        

                    }
                    //i+=1;
                    offsetTop+=1;
                    while (true)
                    {
                        m++;
                        array[i,j]=m;
                        i+=1;
                        //Console.WriteLine($"i={i}, j={j}, m={m}");
                        if (i==(sizeRows-1-offsetLow) || i <0 ) break ;
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
                        //Console.WriteLine($"i={i}, j={j}, m={m}");
                        if (j==(0+offsetLeft) || j<0) break;
                        //j-=1;

                    }
                    //i-=1;
                    offsetLeft+=1;
                    if (sizeColumns%2==0 && sizeRows%2==0) if (i==(3) && j == (4)) break;
                    while (m != sizeRows*sizeColumns)
                    {
                        m++;
                        array[i,j]=m;
                        i-=1;
                        //Console.WriteLine($"i={i}, j={j}, m={m}");
                        if (i==(0+offsetTop) || i<0)  break;
                        //i-=1;

                    }
                    
                    offsetLow+=1;
                    
                    //MyMC.PrintArray(array);
                    Console.WriteLine();
                    //Console.WriteLine($"{offsetTop} {offsetRight} {offsetLow} {offsetLeft}");
                    //Console.WriteLine($"{i} {j}");
                }
                MyMC.PrintArray(array);
            }
            Console.Clear();
            //Task58();
            //Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
            void Recursion64(int m, int n)
            {
                if (m>=n) return;
                if (m%3==0) 
                {
                    Console.WriteLine(m); 
                    m+=3;
                }
                else m++;

                Recursion64(m,n);
            }

            void Task64()
            {
                int m = MyMC.Input("Введите m: ");
                int n = MyMC.Input("Введите n: ");
                Recursion64(m,n);
            }
            //Task64();
            //Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.
            int Recursion66(int m, int n, int sum = 0)
            {
                if (m>=n) return sum;
                sum +=m;
                m++;
                return Recursion66(m,n, sum);
                
            }

            void Task66()
            {
                int m = MyMC.Input("Введите m: ");
                int n = MyMC.Input("Введите n: ");
                int sum = Recursion66(m,n);
                Console.WriteLine($"Сумма чисел от {m} до {n} = {sum}");
            }
            //Task66();
            //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            int Recursion68(int m, int n, int result = 0)
            {
                if (m<0 || n<0) return result;

                if (m==0) return n+1;
                if (n==0) return Recursion68(m-1,1,result);
                else 
                {
                    return Recursion68(m-1,Recursion68(m,n-1,result),result);
                }
                
                return Recursion68(m,n, result);
                
            }

            void Task68()
            {
                int m = MyMC.Input("Введите m: ");
                int n = MyMC.Input("Введите n: ");
                int result = Recursion68(m,n);
                Console.WriteLine($"Функция Аккермана для чисел {m} и {n} = {result}");
            }
            Task68();



        } 
          

        
        
    }
}           

    