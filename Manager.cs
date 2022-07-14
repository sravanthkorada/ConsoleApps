using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Manager : Employee
    {
        public int Salesqty { get; set; }
        public decimal Commission { get; set; }
        public Manager()
        {
            Salesqty = 1000;
            Commission = 200;
        }
        public Manager(decimal Commission, int Salesqty, int id, string name, decimal sal, Department dept, Date dt) : base(id, name, sal, dept, dt)
        {
            this.Commission = Commission;
            this.Salesqty = Salesqty;
        }

        public override string ToString()
        {
            return Commission + " " + Salesqty + "  " + Id + " " + Name + " " + Salary + " " + Dept + " " + Doj;
        }

        public override void Gross_Salary()
        {
            decimal grossSalary = Salary + Salary * 0.7m + Salary * 0.15m + 500.00m + Commission*Salesqty;
            Console.WriteLine("Gross Salary for manager is : " + grossSalary);
        }
    }
}
