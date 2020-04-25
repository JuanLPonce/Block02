using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prime_numbers;
            int[] first_100;

            prime_numbers = new int[101];
            first_100 = new int[101];
            for(int n=1; n<=100; n++)
            {
                
                first_100[n] = n;

                if(first_100[n]%n==0 && first_100[n]-n==0)
                {
                    

                    Console.WriteLine("" +first_100[n]);
                }


            }

            Console.WriteLine("Press enter to go out");
            Console.ReadLine();

        }
    }
}
    
