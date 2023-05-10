using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassiveTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            
            int stingsInArray = 10;
            int columnsInArray = 10;
            int[,] numbersArray = new int[stingsInArray, columnsInArray];
            Random randomForArray = new Random();
            int minNumberInArray = 10;
            int maxNumberInArray = 100;
            int maxElement = int.MinValue;
            int numberForReplace = 0;

            Console.WriteLine("Выводим массив, которые есть: ");
            for (int i = 0; i < numbersArray.GetLength(0); i++)
            {
                for (int j = 0; j < numbersArray.GetLength(1); j++)
                {
                    numbersArray[i, j] = randomForArray.Next(minNumberInArray, maxNumberInArray);
                    Console.Write(numbersArray[i, j] + "  ");

                    if (maxElement < numbersArray[i, j])
                    {
                        maxElement = numbersArray[i, j];
                    }
                }

                Console.WriteLine();
            }
            
            Console.WriteLine($"\nСамое большое число в массиве: {maxElement}");

            Console.WriteLine($"\nТеперь выведем новый массив, где {maxElement} заменен на {numberForReplace}");

            for (int i = 0; i < numbersArray.GetLength(0); i++) 
            {
                for (int j = 0; j < numbersArray.GetLength(1); j++) 
                {
                    if (numbersArray[i, j] == maxElement) 
                    {
                        numbersArray[i, j] = numberForReplace;
                    }
                    Console.Write(numbersArray[i, j] + "  ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
