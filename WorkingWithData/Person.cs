using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithData
{
    class Person
    {
        public string FirstName { get; set;  }
        public string LastName { get; set; }
        public string Email { get; set; }
        //default constructor:
        public Person()
        {
            FirstName = "";
            LastName = "";
            Email = "";

        }


        public Person(string strFirst)
        {
            FirstName = strFirst;
            LastName = "";
            Email = "";
        }

        // create a constructor off another constructor

        public Person(string strFirst, string strLast) : this(strFirst)
        {
            LastName = strLast;
            Email = "";
        }

        public Person(string strFirst, string strLast, string strEmail) : this (strFirst, strLast)
        {

            Email = strEmail;
        }

        internal protected string DisplayPerson()
        {
            string displayemployee = "";
            displayemployee += "First - " + FirstName + "\n";
            displayemployee += "LastName - " + LastName + "\n";
            displayemployee += "Email - " + Email + "\n";

            return displayemployee;

        }
    }
}
