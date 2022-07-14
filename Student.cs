using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Marks { get; set; }

        public Student()
        {
            Id = 1;
            FirstName = "Sravanth";
            LastName = "Korada";
            Marks = 100;
        }

        public Student(int id, string fname, string lname, int Marks)
        {
            Id = id;
            FirstName = fname;
            LastName = lname;
            this.Marks = Marks;
        }

        public override string ToString()
        {
            return Id + " " + FirstName + " " + LastName + " " + Marks;
        }
    }
}
