using System;

namespace Employee_Wage
{
    class Program
    {
        static void Main(string[] args)
        {
            int Wage_Per_Hr = 20;
            int Employee_Hrs = 0;
            Random rand = new Random();
            int num = rand.Next(1, 4);
            Console.WriteLine("Random number is" + num);
            if (num == 1)
            {
                Console.WriteLine("Employee is full time present");
                Employee_Hrs = 8;
            }
            else if (num == 2)
            {
                Console.WriteLine("Employee is part time present");
                Employee_Hrs = 4;
            }
            else
            { 
                Console.WriteLine("Employee is absent");
            }
            int EmpWage = Employee_Hrs * Wage_Per_Hr;
            Console.WriteLine("The employee wage is " + EmpWage);
        }
    }
}
