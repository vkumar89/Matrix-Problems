using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class CreationOfMatrix
    {
        static void Main()
        {
            int[,] mat = new int[3,3];
            
            for(int i=0;i<mat.GetLength(0);i++)
            {
                for(int j=0;j<mat.GetLength(1);j++)
                {
                    //Console.WriteLine($"{i}{j}");
                    mat[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"{mat[i,j]} ");
                   
                }
                Console.WriteLine();
            }
            Console.Clear();
            Search(mat, 6);

        }

        static void Search(int[,]mat,int x)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine($"[{i},{j}]");
                    }
                }
            }
        }
    }
}
