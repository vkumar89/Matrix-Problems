using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Spiral_Matrix
    {
        static void Main()
        {
            int[,] mat = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };

            int StartRow = 0;
            int StartCol = 0;
            int EndRow = mat.GetLength(0) - 1;
            int EndCol = mat.GetLength(1) - 1;

            while (StartRow <= EndRow && StartCol <= EndCol)
            {
                //Top boundry
                for (int j = StartCol; j <= EndCol; j++)
                {

                    Console.Write(mat[StartRow, j] + " ");
                }

                // right boundry
                for (int i = StartRow + 1; i <= EndRow; i++)
                {
                    Console.Write(mat[i, EndCol] + " ");
                }

                //bottom boundry

                for (int j = EndCol - 1; j >= StartCol; j--)
                {
                    if (StartCol == EndCol)
                        break;
                    Console.Write(mat[EndRow, j] + " ");
                }

                //left boubdry

                for (int i = EndRow - 1; i >= StartRow + 1; i--)
                {
                    if (StartRow == EndRow)
                        break;
                    Console.Write(mat[i, StartCol] + " ");
                }

                StartRow++;
                StartCol++;
                EndRow--;
                EndCol--;
            }
        }
    }
}
