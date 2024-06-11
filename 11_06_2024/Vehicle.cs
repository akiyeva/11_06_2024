using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_06_2024
{
    public abstract class Vehicle
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public abstract void ShowInfo();
        public Vehicle(int year)
        {
            Year = year;
        }
    }
}
