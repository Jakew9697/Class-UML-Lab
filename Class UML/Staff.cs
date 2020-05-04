using System;
using System.Collections.Generic;
using System.Text;

namespace Class_UML
{
    class Staff : Person
    {
        //properties
        public string school
        {
            get;

            set;
        }

        public double pay
        {
            get;

            set;
        }

        //constructors
        public Staff(string Name, string Address, string School, double Pay) : base(Name, Address)
        {
            this.school = School;

            this.pay = Pay;
        }
        //default constructor
        public Staff()
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()} | School Attending: {school} | Tuition Cost: {pay} ";
        }
    }
}
