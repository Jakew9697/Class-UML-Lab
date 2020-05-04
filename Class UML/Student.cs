using System;
using System.Collections.Generic;
using System.Text;

namespace Class_UML
{
    class Student : Person
    {
        //properties
        public string Program
        {
            get;

            set;
        }

        public int Year
        {
            get;

            set;
        }

        public double Fee
        {
            get;

            set;
        }

        //constructors
        public Student(string Name, string Address, int Year, double Fee, string Program) : base(Name, Address)
        {

            this.Year = Year;

            this.Fee = Fee;

            this.Program = Program;

        }
        //default constructor
        public Student()
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()} | Class Program: {Program} | Class Year: {Year} | Tuition Cost: {Fee} ";
            
        }        
    }
}
