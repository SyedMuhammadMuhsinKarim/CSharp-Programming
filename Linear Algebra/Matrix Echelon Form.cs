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
            double[,] matrix = new double[4, 5] { {1, 2, 4, 8, 5.3}, {1, 5.5, 30.25, 166.375, 5.5}, {1, 11, 121 , 1331, 10.2}, {1, 13, 169, 2197, 9.35} };
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            double[,] result = new double[row, col];
            Console.WriteLine("Row = {0}, Col = {1}",  row, col);

            pivotFinding(matrix, 0, row, col);
            Console.ReadKey();


        }

        static void pivotFinding(double [,] matrix, int nCol, int row, int col) 
        {
            int i = 0;
            int j = nCol;
            while(i < row) {
               if(matrix[i,j] == 0) {
                   i++;
                }
               else if (matrix[i, j] != 0) {
                   if(matrix[i,j] != 1 && i != col) {
                       matrix[i, j] /= matrix[i, j];
                        double temp = matrix[j, j];
                        matrix[j, j] = matrix[i, j];
                        matrix[i, j] = temp;
                        i++;
                        break;
                   } 
                   else if(matrix[i,j] != 1 && i == col) {
                        matrix[i, j] /= matrix[i, j];
                        i++;
                        break;
                    }
                    else if (matrix[i, j] == 1) {
                        break;
                    }
               } 
            }


            Console.WriteLine("Pivot Resolve");
            for (int r = 0; r < row; r++) {
                for (int c = 0; c < col; c++) {
                    Console.Write(matrix[r, c] + "        ");
                }
                Console.WriteLine();
            }

            //Console.WriteLine(nCol);
            Echelon(matrix, nCol, col, row);
        }

        static void Echelon(double[,] matrix, int nCol, int col, int row) {
            int k = nCol;
            double [,] result = new double[row, col];

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    result[r, c] = matrix[r, c];
                }
                Console.WriteLine();
            }

            Console.WriteLine("Process On Matrix");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i != nCol)
                    {
                        result[i, j] = matrix[i, j] - (matrix[nCol, j] * matrix[i, nCol]);
                        //Console.WriteLine("[{0},{1}] = [{0},{1}] - ([{2},{1}] * [{0},{2}]) = {3}", i, j, nCol, result[i, j]);
                    }
                }
            }

            Console.WriteLine("Get Matrix After Process");
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrix[r, c] = result[r,c];
                    Console.Write(result[r, c] + "     ");
                }
                Console.WriteLine();
            }

            nCol = nCol + 1;
            if (nCol < row) {
                pivotFinding(matrix, nCol, row, col);
            }
        }
    }
}
