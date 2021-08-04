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
            switch(num)
            {
                case 1:
                    Console.WriteLine("Employee is full time present");
                    Employee_Hrs = 8;
                    break;
                case 2:
                    Console.WriteLine("Employee is part time present");
                    Employee_Hrs = 4;
                    break;
                case 3:
                    Console.WriteLine("Employee is absent");
                    break;
                default:
                    Console.WriteLine("correct the program");
                    break;
            }
            int EmpWage = Employee_Hrs * Wage_Per_Hr;
            Console.WriteLine("The employee wage is " + EmpWage);
        }
    }
}
