using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //Задача 38: Задайте массив вещественных чисел.
            //Найдите разницу между максимальным и минимальным элементов массива.

            Console.WriteLine("Введите размер массива");
            int size = Convert.ToInt32(Console.ReadLine());
            double[] numbers = new double[size];
            FillArrayRandomNumbers(numbers);
            Console.WriteLine("Вот наш массив: ");
            PrintArray(numbers);
            double min = Int32.MaxValue;
            double max = Int32.MinValue;

            for (int z = 0; z < numbers.Length; z++)
            {
                if (numbers[z] > max)
                {
                    max = numbers[z];
                }
                if (numbers[z] < min)
                {
                    min = numbers[z];
                }
            }

            Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
            Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

            void FillArrayRandomNumbers(double[] Numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
                }
            }
            void PrintArray(double[] Numbers)
            {
                Console.Write("[ ");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }



    }
}
