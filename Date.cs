using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Date
    {
        public int day { get; set; }
        public int mon { get; set; }
        public int year { get; set; }
        public Date()
        {
            day = 4;
            mon = 6;
            year = 2022;
        }
        public Date(int day, int mon, int year)
        {
            this.day = day;
            this.mon = mon;
            this.year = year;
        }
        public override string ToString()
        {
            return day.ToString() + "/" + mon.ToString() + "/" + year.ToString();
        }
     }
}

