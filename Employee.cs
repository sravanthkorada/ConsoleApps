using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Department {IT, Production, Civil, Sales, Mining} //labeled integers
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Department Dept { get; set; }
        public static int Count { get; set; }

        public Date Doj { get; set; }


        public Employee()
        {
            Id = 0;
            Name = "Raju";
            Salary = 10000;
            Dept = Department.IT;
            Doj = new Date();
        }

        static Employee()
        {
            Count = 100;
        }

        public Employee(int id, string name, decimal salary, Department dept, Date doj)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Count++;
            Dept = dept;
            Doj = doj;
        }

        public override string ToString()
        {
            return Id + " " + Name + " " + Salary + " " + Dept + " " + Doj;
        }

        public static void ShowCount()
        {
            Console.WriteLine(Count);
        }

        public virtual void Gross_Salary()
        {
            decimal grossSalary = Salary + Salary * 0.7m + Salary * 0.15m + 500.00m;
            Console.WriteLine("Gross Salary for Employee is : " + grossSalary);
        }
    }
}
