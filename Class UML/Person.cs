using System;
using System.Collections.Generic;
using System.Text;

namespace Class_UML
{
    class Person
    {
        //properties
        public string Name
        {
            get;

            set;
        }

        public string Address
        {
            get;

            set;
        }


        public Person(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;      
        }
        //default constructor
        public Person()
        {

        }

        public override string ToString()
        {
            return $"Name: {Name} | Address: {Address}";
        }

    }
}
