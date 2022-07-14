using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student(1, "Sravanth", "Korada", 99);
            //Console.WriteLine(s1);

            Employee e1 = new Employee(1, "Sravanth", 1000000, Department.IT, new Date(02, 07, 2022));
            Console.WriteLine(e1);
            Employee.ShowCount();
            e1.Gross_Salary();

            Employee[] Arr = new Employee[5];
            Arr[0] = new Employee(2, "Sravani", 600, Department.IT, new Date(02, 07, 2022));
            Arr[1] = new Employee(2, "Sravani", 600, Department.IT, new Date(02, 07, 2022));
            Arr[2] = new Employee(2, "Sravani", 600, Department.IT, new Date(02, 07, 2022));
            Arr[3] = new Employee(2, "Sravani", 600, Department.IT, new Date(02, 07, 2022));
            Arr[4] = new Employee(2, "Sravani", 600, Department.IT, new Date(02, 07, 2022));

            Manager m1 = new Manager();
            Manager m2 = new Manager(5000, 300, 1, "Sravanth", 1000000, Department.IT, new Date(02, 07, 2022));
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            m2.Gross_Salary();

            foreach (Employee item in Arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}