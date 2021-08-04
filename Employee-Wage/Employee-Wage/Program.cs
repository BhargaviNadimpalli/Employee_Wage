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
            int count = 0;
            int numOfHrsWorked = 0;
            int daysWorked = 0;
            Random rand = new Random();
            while (numOfHrsWorked <= 100 && daysWorked <= 20)
            {
                EmpWage = 0;
                int Employee_Hrs = 0;
                int num = rand.Next(1, 4);
                Console.WriteLine("Random number is :" + num);
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Employee is full time present");
                        Employee_Hrs = 8;
                        numOfHrsWorked += Employee_Hrs;
                        daysWorked++;
                        break;
                    case 2:
                        Console.WriteLine("Employee is part time present");
                        Employee_Hrs = 4;
                        numOfHrsWorked += Employee_Hrs;
                        daysWorked++;
                        break;
                    case 3:
                        Console.WriteLine("Employee is absent");
                        Employee_Hrs = 0;
                        break;
                    default:
                        Console.WriteLine("correct the program");
                        break;
                }
                Console.WriteLine("Number of hours worked" + numOfHrsWorked);
                EmpWage = Employee_Hrs * Wage_Per_Hr;
                monthlyWage += EmpWage;
                count++;
            }

                Console.WriteLine("Number of times counter ran" + count);
                Console.WriteLine("Days worked " + daysWorked);
                Console.WriteLine("The employee wage is " + monthlyWage);
            
        }

    }
}
