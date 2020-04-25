using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int number_employees;

            double[] worked_hours;

            double[] salary_per_hour;

            int b = 1;
           

            Console.WriteLine("Write the number of employees:");
            number_employees = Int32.Parse(Console.ReadLine());

            salary_per_hour = new double[number_employees];

            worked_hours = new double[number_employees];

            for(int a=0; a<number_employees; a++)
            {
                Console.WriteLine("Write the worked hours of the employee number " +b);

                worked_hours[a] = Double.Parse(Console.ReadLine());


                Console.WriteLine("Write the salary per hour of the employee number " + b);

                salary_per_hour[a] = Double.Parse(Console.ReadLine());

               

                if (worked_hours[a] > 37.5)
                {

                    double extra_hours = worked_hours[a] - 37.5;

                    double extra_salary = extra_hours * 2 * salary_per_hour[a];

                    Console.WriteLine("The employee number " + b + " has worked " + extra_hours + " extra hours ");

                    Console.WriteLine("He will be paid " + extra_salary + " euros extra for that extra hours ");

                    double total_salary = worked_hours[a] * salary_per_hour[a] + extra_salary;

                    Console.WriteLine("His total salary will be: " + total_salary);


                }
                else if (worked_hours[a] <= 37.5)
                {
                    Console.WriteLine("The employee number " + b + " has worked " + worked_hours[a] + " hours ");

                    Console.WriteLine("His total salary will be: " + (salary_per_hour[a] * worked_hours[a]));


                }


                if(worked_hours[a] > 40)
                {

                    Console.WriteLine("We will consider also the extra hours if the minimum is 40:");

                    double extra_hours = worked_hours[a] - 40;

                    double extra_salary = extra_hours * 2 * salary_per_hour[a];

                    Console.WriteLine("The employee number " + b + " has worked " + extra_hours + " extra hours ");

                    Console.WriteLine("He will be paid " + extra_salary + " euros extra for that extra hours ");

                    double total_salary = worked_hours[a] * salary_per_hour[a] + extra_salary;

                    Console.WriteLine("His total salary will be: " + total_salary);


                }

                 b++;

            }
           


        }
    }
}
