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
            Console.WriteLine("Введите размер массива");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            FillArrayRandomNumbers(numbers);
            Console.WriteLine("Вот наш массив: ");
            PrintArray(numbers);
            int count = 0;

            for (int z = 0; z < numbers.Length; z++)
                if (numbers[z] % 2 == 0)
                    count++;

            Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

            void FillArrayRandomNumbers(int[] Numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = new Random().Next(100, 1000);
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
