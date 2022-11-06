using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fourth_Lesson
{
    internal class MathOperations
    {
        public void AmountOfPosAndNegNumbers(int[,] arr, int str, int column)
        {
            int positive = 0;
            int negative = 0;
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (arr[i, j] > 0)
                    {
                        positive++;
                    }
                    else
                    {
                        negative++;
                    }
                }
            }

            Console.WriteLine("Amount of posive numbers: " + positive);
            Console.WriteLine("Amount of negative numbers: " + negative);
        }

        public void ArrSort(int[,] arr, int str, int column)
        {
            for (int k = 0; k < str; k++)
            {
                for (int j = 0; j < column; j++)
                {
                    for (int i = 0; i < column - 1; i++)
                    {
                        if (arr[k, i] > arr[k, i + 1])
                        {
                            int t = arr[k, i];
                            arr[k, i] = arr[k, i + 1];
                            arr[k, i + 1] = t;
                        }
                    }
                }
            }

            Console.WriteLine("Sorted array:");
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < column; j++)
                    Console.Write(String.Format("{0,5}", arr[i, j]));
                Console.WriteLine();
            }
        }

        public void Invers(int[,] arr, int str, int column)
        {
            for (int i = 0; i < arr.GetLength(1) / 2; i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    int t = arr[j, i];
                    arr[j, i] = arr[j, arr.GetLength(1) - i - 1];
                    arr[j, arr.GetLength(1) - i - 1] = t;
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(String.Format("{0,5}", arr[i, j]));
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
