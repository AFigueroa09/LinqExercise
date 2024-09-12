using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            var sum = numbers.Sum();
            Console.WriteLine("Sum");
            Console.WriteLine(sum);

            //TODO: Print the Average of numbers
            var average = numbers.Average();
            Console.WriteLine("Average");
            Console.WriteLine(average);

            //TODO: Order numbers in ascending order and print to the console
            var ascending = numbers.OrderBy(x => x);
            Console.WriteLine("Ascending");
            foreach (int number in ascending) Console.WriteLine(number);

            //TODO: Order numbers in descending order and print to the console
            var descending = numbers.OrderByDescending(x => x);
            Console.WriteLine("Descending");
            foreach (int number in descending) Console.WriteLine(number);

            //TODO: Print to the console only the numbers greater than 6
            var greaterThanSix = numbers.Where(x => x > 6);
            Console.WriteLine("Greater than Six");
            foreach (int number in greaterThanSix) Console.WriteLine(number);

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var descending2 = numbers.OrderByDescending(x => x).Take(4);
            Console.WriteLine("Descending Take 4");
            foreach (int number in descending2) Console.WriteLine(number);

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers[3] = 34;
            var descending3 = numbers.OrderByDescending(x => x);
            Console.WriteLine("Descending and replace");
            foreach (int number in descending3) Console.WriteLine(number);

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var employeesNames = employees.Select(x => x.FirstName).Where(x => x[0] == 'S' || x[0] == 'C');
            Console.WriteLine("Employees names starting with C and S");
            foreach (var name in employeesNames) Console.WriteLine(name);

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var employeesbyAge = employees.Where(x => x.Age > 26).Select(x => $"{x.FullName} {x.Age}" );
            Console.WriteLine("Employees names greater than 26");
            foreach (var name in employeesbyAge) Console.WriteLine(name);

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var employeesbyExperience = employees.Where(x => x.Age > 35 && x.YearsOfExperience <= 10).Select(x => x.Age).Sum();
            Console.WriteLine("Employees sum of age by YoE");
            Console.WriteLine(employeesbyExperience);

            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var employeesbyAverage = employees.Where(x => x.Age > 35 && x.YearsOfExperience <= 10).Select(x => x.YearsOfExperience).Average();
            Console.WriteLine("Employees average of YoE");
            Console.WriteLine(employeesbyAverage);

            //TODO: Add an employee to the end of the list without using employees.Add()
            var newbie = new Employee("John", "Doe", 30, 10);
            var updatedEmployeed = employees.Append(newbie);
            foreach (var employee in updatedEmployeed) Console.WriteLine($"{employee.FullName} {employee.Age} {employee.YearsOfExperience}");
            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
