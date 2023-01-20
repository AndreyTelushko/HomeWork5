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
            //Задача 36: Задайте одномерный массив, заполненный случайными числами.
            //Найдите сумму элементов, стоящих на нечётных позициях.

            Console.WriteLine("Введите размер массива");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            FillArrayRandomNumbers(numbers);
            Console.WriteLine("Вот наш массив: ");
            PrintArray(numbers);
            int sum = 0;

            for (int z = 0; z < numbers.Length; z += 2)
                sum = sum + numbers[z];

            Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

            void FillArrayRandomNumbers(int[] Numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = new Random().Next(1, 10);
                }
            }
            void PrintArray(int[] Numbers)
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
