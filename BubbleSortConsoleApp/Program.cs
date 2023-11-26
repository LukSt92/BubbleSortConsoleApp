using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
/*            int[] ArrayZ = { 3, 5, 2, 1, 4 };*/
            int[] ArrayA = { };
            int[] ArrayB = { 1, 2, 5, 3, 1, 7, 9, 1, 12, 83, 1, 5, 3, 2 };
            int[] ArrayC = { 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1 };
            int[] ArrayD = { 2, 2, 2, 2 };
            int[] ArrayE = { 1, 2 };
            int[] ArrayF = { 2, 1 };

            int[][] ArrayList = { ArrayA, ArrayB, ArrayC, ArrayD, ArrayE, ArrayF };


            Console.WriteLine("This is simple exercise to learn and understand bubble sort technique.");
            Console.WriteLine("Program will try to sort different arrays:");

            foreach (var array in ArrayList)
            {
                Console.WriteLine();
                Console.WriteLine("Array: ");

                foreach (int i in array)
                {
                    Console.Write(" " + i + " ");
                }
                Console.WriteLine(" ");
                foreach (var item in array)
                {

                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] > array[i + 1])
                        {
                            int x;
                            x = array[i + 1];
                            array[i + 1] = array[i];
                            array[i] = x;
                        }
                    }
                }
                foreach (int i in array)
                {
                    Console.Write(" " + i + " ");
                }
            }

        }
    }
}
