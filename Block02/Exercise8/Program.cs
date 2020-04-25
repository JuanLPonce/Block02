using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] two_dims_vec;
            int n;

            Console.WriteLine("Write the dimension of the matrix nxn:");

            n = Int32.Parse(Console.ReadLine());
            two_dims_vec = new int [n,n];
            Console.WriteLine("Write the vector numbers");
            for(int i=0; i<n; i++)
            {
                for (int b = 0; b < n; b++)
                {
                    two_dims_vec[i, b] = Int32.Parse(Console.ReadLine());
                }
            
            }

            for (int i = 0; i < n; i++)
            {
                for (int b = 0; b < n; b++)
                {
                    if (i == b)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("In the " + i + " position of the diagonal is:" + two_dims_vec[i, i]);
                    }
                    else
                    {
                        Console.WriteLine("");
                    }

                }

            }








        }
    }
}
