
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
                int size = 12; //MyMC.Input("Введите число а: ");
                int[] nums = new int[size];
                
                MyMC.RndArray(nums, -9, 10);
                int sumotr=0;
                int sumpol=0;
                for (int i=0 ; i<nums.Length;i++)
                {
                    if (nums[i]<0) 
                    {sumotr+=nums[i];}
                    else 
                    {sumpol+=nums[i];}
                }
                Console.WriteLine($"Сумма отрицательных элементов = {sumotr}");
                Console.WriteLine($"Сумма положительных элементов = {sumpol}");
                MyMC.PrintArray(nums);
            }
            Task31();
        }
        
    }
}
