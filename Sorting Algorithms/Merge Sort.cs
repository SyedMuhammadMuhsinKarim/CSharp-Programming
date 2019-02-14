/* Created by SharpDevelop.*/
using System;

namespace Merge_Sort
{
    class Program
    {
        public static int Split(int[] Array, int n)
        {
            if (n >= 2)
            {
                int mid = n / 2;
                int mid1 = n - mid;
                int[] Left = new int[mid];
                int[] Right = new int[mid1];

                for (int i = 0; i < mid; i++)
                {
                    Left[i] = Array[i];
                }

                for (int j = mid; j < n; j++)
                {
                    Right[j - mid] = Array[j];
                }

                Split(Left, mid);

                Split(Right, n - mid);

                MergingSorting(Array, Left, Right, mid1, mid);
            }
            if (n < 2)
            {
                return 0;
            }
            return 1;
        }

        public static int MergingSorting(int[] Array, int[] Left, int[] Right, int R, int L)
        {
            R = Right.Length;
            L = Left.Length;

            int i = 0, j = 0, k = 0;
            // i = Left, j = Right, k = Array

            while (i < L && j < R)
            {
                if (Left[i] <= Right[j])
                {
                    Array[k] = Left[i];
                    i++; k++;
                }
                else
                {
                    Array[k] = Right[j];
                    j++; k++;
                }
            }

            while (i < L)
            {
                Array[k] = Left[i];
                i++; k++;
            }
            while (j < R)
            {
                Array[k] = Right[j];
                j++; k++;
            }
            return 1;
        }

        public static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int[] Array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Array[i] = int.Parse(Console.ReadLine());
            }
            Split(Array, n);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Array[i]);
            }



            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
