using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    class Person
    {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Age { get; set; }
        private double _salary;
        public double getSalary()
        {
            return _salary;
        }
        public void setSalary(double salary)
        {
            _salary = salary;
        }

          
        }
}
