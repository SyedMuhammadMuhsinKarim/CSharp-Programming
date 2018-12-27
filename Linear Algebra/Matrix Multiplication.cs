using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            Console.WriteLine("First Matrix: ");
            Console.Write("No of Rows: ");
            int r1 = int.Parse(Console.ReadLine());
            Console.Write("No of Columns: ");
            int c1 = int.Parse(Console.ReadLine());

            int[,] arr1 = new int [r1 , c1];

            Console.WriteLine("1st Matrix Input: ");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    Console.Write("[{0},{1}]: ", i, j);
                    arr1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("1st Matrix is: ");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    Console.Write(arr1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("2nd Matrix: ");
            Console.Write("No of Rows: ");
            int r2 = int.Parse(Console.ReadLine());
            Console.Write("No of Columns: ");
            int c2 = int.Parse(Console.ReadLine());

            int[,] arr2 = new int[r2, c2];

            Console.WriteLine("2nd Matrix Input: ");
            for (i = 0; i < r2; i++)
            {
                for (j = 0; j < c2; j++)
                {
                    Console.Write("[{0},{1}]: ", i, j);
                    arr2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("2nd Matrix is: ");
            for (i = 0; i < r2; i++)
            {
                for (j = 0; j < c2; j++)
                {
                    Console.Write(arr2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int matrixFirst_Row = r1;
            int matrixSecond_Col = c2;

            if (arr1.GetLength(0) == arr2.GetLength(1))
            {
                Console.WriteLine("Row of 1st Matrix = Col of 2nd Matrix");
                int[,] c = new int[matrixFirst_Row, matrixSecond_Col];

                for (i = 0; i < matrixFirst_Row; i++)
                {
                    for (j = 0; j < matrixFirst_Row; j++)
                    {
                        c[i, j] = 0;
                        for (k = 0; k < matrixFirst_Row; k++)
                        {
                            c[i, j] = c[i, j] + arr1[i, k] * arr2[k, j];
                        }
                    }
                }

                Console.WriteLine("Multiplication Of Matrix A and B is: ");
                for (i = 0; i < matrixFirst_Row; i++)
                {
                    for (j = 0; j < matrixSecond_Col; j++)
                    {
                        Console.Write(c[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Error! We Can't Calculate Because Row of 1st Matrix isn't Equal to Column of 2nd Matrix");
            }

            Console.ReadKey();

        }
    }
}
