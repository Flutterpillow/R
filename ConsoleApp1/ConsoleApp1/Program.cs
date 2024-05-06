using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Введите цифры для массива через пробел:");
                string enter = Console.ReadLine();
                string[] enterArray = enter.Split(' ');
                int[] array = new int[enterArray.Length];

                for (int i = 0; i < enterArray.Length; i++)
                {
                    array[i] = Convert.ToInt32(enterArray[i]);
                }

                int maxLength = SubArray(array);
                Console.WriteLine("Максимальная длина под массива: " + maxLength);
            }

            int SubArray(int[] array)
            {
                int maxLength = 0;
                int currentLength = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 1)
                    {
                        currentLength++;
                        maxLength = Math.Max(maxLength, currentLength);
                    }
                    else
                    {
                        currentLength = 0;
                    }
                }

                return maxLength;
            }
        }
    }
}
