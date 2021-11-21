using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 51);
            }
            Console.Write("Одномерный массив из 10 случайных чисел в диапазоне [-50,50]:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0,4}", array[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (array[j] < array[i])
                    {
                        int a = array[i];
                        array[i] = array[j];
                        array[j] = a;
                    }
                }
            }
            for (int i = 5; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (array[j] > array[i])
                    {
                        int a = array[i];
                        array[i] = array[j];
                        array[j] = a;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Группа первых пяти элементов массива, отсортированных по возрастанию:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0,4}", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Группа вторых пяти элементов массива, отсортированных по убыванию:");

            for (int i = 5; i < 10; i++)
            {
                Console.Write("{0,4}", array[i]);
            }

            Console.ReadKey();

        }
    }
}
