using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change Graph to Matrix
            int[,] a = new int[6, 6] { { 0, 0, 1, 1, 0, 0},
                                       { 1, 0, 0, 0, 0, 0},
                                       { 0, 0, 0, 1, 1, 0},
                                       { 0, 0, 0, 0, 0, 1},
                                       { 0, 0, 0, 0, 0, 1},
                                       { 0, 0, 0, 0, 0, 0}
                                      };
            Connection(a);
            Console.Read();
        }
        
        /* How Many Nodes is Connected to Current Node (Matrix Adjency) */
        static void Connection(int[,] a)
        {
            int r = a.GetLength(0);
            int c = a.GetLength(1);
            int[] arr = new int[r];

            int i = 0;
            while (i < r)
            {
                int count = 0;
                for (int j = 0; j < c; j++)
                {
                    if (a[i, j] == 1)
                    {
                        count++;
                        arr[i] = count;
                    }
                }
                i++;
            }

            for (int k = 0; k < r; k++)
            {
                Console.WriteLine("Node {0} connected to {1} nodes", k, arr[k]);
            }
        }
    }
}
