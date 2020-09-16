/*
 Author: Wei Ming Guo
 Date: 09/15/2020
 C# console program to show the grade you get in the class of ISM 4300
*/

using System;

namespace Tech_Project_2B
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to input their expected grade for ISM 4300
            Console.WriteLine("Please enter an interger value of the grade you expect to get in ISM4300");

            try
            {
                int grade;
                grade = int.Parse(Console.ReadLine());

                if (grade <= 59)
                {
                    Console.WriteLine("Your Letter Grade for ISM 4300 is F");
                }
                else if ((grade >= 60) && (grade <= 69))
                {
                    Console.WriteLine("Your Letter Grade for ISM 4300 is D");
                }
                else if ((grade >= 70) && (grade <= 79))
                {
                    Console.WriteLine("Your Letter Grade for ISM 4300 is C");
                }
                else if ((grade >= 80) && (grade <= 89))
                {
                    Console.WriteLine("Your Letter Grade for ISM 4300 is B");
                }
                else if ((grade >= 90) && (grade <= 100))
                {
                    Console.WriteLine("Your Letter Grade for ISM 4300 is A");
                }

            }
            catch
            {
                Console.WriteLine("Please enter an interger value for your expected grade next time");
                Console.WriteLine("Press any key to exit the program and try again");
                Console.ReadKey(true);
            }

            
        }
           
            

    }

}
    

