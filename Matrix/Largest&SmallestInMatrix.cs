using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Largest_SmallestInMatrix
    {
        static void Main()
        {
            int[,] mat = new int[3, 3] { { 11, 20, 13 }, { 33, 24, 35 }, { 6, 7, 8 } };

            int mx = mat[0,0];
          
            for(int i=1; i<mat.GetLength(0); i++)
            {
                for(int j=1;j<mat.GetLength(1);j++)
                {
                    if (mat[i, j] > mat[i-1,j-1] && mx< mat[i, j])
                    {
                        mx = mat[i,j];
                    }
                    
                }
            }
            Console.WriteLine(mx);
            

        }
    }
}
