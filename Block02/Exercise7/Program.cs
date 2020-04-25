using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector;

            int vector_size;
            int max_number;
            int min_number;
            Console.WriteLine("Write the size of the vector:");
            vector_size = Int32.Parse(Console.ReadLine());
            vector = new int[vector_size];


            Console.WriteLine("Put the numbers in the vector:");
            for (int a = 0; a < vector_size; a++)
            {
                vector[a] = Int32.Parse(Console.ReadLine());

            }

            max_number = vector[0];
            min_number = vector[0];

            for (int i = 1; i < vector_size; i++)
            {
                if (vector[i] > max_number)
                {
                    max_number = vector[i];
                }

                if (vector[i] < min_number)
                {
                    min_number = vector[i];
                }

            }

            Console.WriteLine("The maximum number is: " + max_number);
            Console.WriteLine("The minimum number is: " + min_number);


        }
    }
}