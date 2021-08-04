using System;

namespace Employee_Wage
{
    class Program
    {
        static void Main(string[] args)
        {
            int Wage_Per_Hr = 20;
            int monthlyWage = 0;
            int EmpWage;
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                int Employee_Hrs = 0;
                int num = rand.Next(1, 4);
                Console.WriteLine("Random number is :" + num);
                switch (num)
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
                        Employee_Hrs = 0;
                        break;
                    default:
                        Console.WriteLine("correct the program");
                        break;
                }

                EmpWage = Employee_Hrs * Wage_Per_Hr;
                monthlyWage += EmpWage;
            }
                Console.WriteLine("The employee wage is " + monthlyWage);
            
        }

    }
}
