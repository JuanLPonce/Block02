using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nine_multiples;
            int sum_multiples = 0;
           
            nine_multiples = new int[200]; 

            Console.WriteLine("The nine multiples between 100 and 200 are: ");

            for(int a=100; a<200; a++)

            {
                nine_multiples[a] = a;

                if(nine_multiples[a]%9==0)
                {

                    sum_multiples += nine_multiples[a];

                    Console.WriteLine("" + nine_multiples[a]);


                    
                }

               

            }

            Console.WriteLine("The multiples sum is: " + sum_multiples);

        }
    }
}
