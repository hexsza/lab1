using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    internal class Matrix
    {
        private int n { get; set; }

        private int a { get; set; }
        private int b { get; set; }

        public Matrix(int n, int a, int b)
        {
            this.n = n;
            this.a = a;
            this.b = b;
            FillMatrix();
        }

        public int[,] matrix = new int[0,0];
        public void FillMatrix()
        {
            Random rnd = new Random();
            
            matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(a,b);
                }
            }
        }
        public void ShowMatrix()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j =0; j < n; j++)
                {
                    Console.Write(matrix[i,j]+"\t");
                }
                Console.WriteLine();

            }
        }
        public int OddCount()
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(matrix[i, j] % 2 == 1)
                    {
                        count++;
                    }
                }

            }
            return count;
        }
    }
}
