using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] marks_maths;

            double[] marks_physics;

            double[] marks_chemistry;

            double total_three;
            
            double total_math_and_phys;

            int number_applicants;

            int b = 1;

            Console.WriteLine("Write the number of applicants: ");

            number_applicants = Int32.Parse(Console.ReadLine());


            marks_maths = new double[number_applicants];

            marks_physics = new double[number_applicants];

            marks_chemistry= new double[number_applicants];


            for ( int a=0; a <number_applicants; a++)
            {

                Console.WriteLine("Write the marks in maths of the applicant number " +b+ " : ");

                marks_maths[a] = Double.Parse(Console.ReadLine());

                Console.WriteLine("Write the marks in physics of the applicant number " + b + " : ");

                marks_physics[a] = Double.Parse(Console.ReadLine());

                Console.WriteLine("Write the marks in chemistry of the applicant number " + b + " : ");

                marks_chemistry[a] = Double.Parse(Console.ReadLine());

                Console.WriteLine("Total in maths: " +marks_maths[a]);
                Console.WriteLine("Total in physics: " + marks_physics[a]);
                Console.WriteLine("Total in chemistry: " + marks_chemistry[a]);

                total_three = marks_maths[a] + marks_physics[a] + marks_chemistry[a];
                total_math_and_phys = marks_maths[a] + marks_physics[a];
                Console.WriteLine("Total in three: " + total_three);

                if(marks_maths[a]<65 || marks_physics[a]<55 || marks_chemistry[a]<50 || total_three < 180)
                {
                    Console.WriteLine("The applicant " + b + " didn´t passed the eligibility criteria");

                }

                if(marks_maths[a] >= 65 && marks_physics[a] >= 55 && marks_chemistry[a] >= 50 && (total_three >= 180 || total_math_and_phys >= 140))
                {
                    Console.WriteLine("The applicant " + b + " has passed the eligibility criteria");

                }

                





                b++;
            }



        }
    }
}
