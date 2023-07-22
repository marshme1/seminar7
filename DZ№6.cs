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
            Console.Clear();
            Task41_1();

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
        }  
        
    }
}

    