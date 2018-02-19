using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithData
{
    class Employee : Person, IUser, IEquatable<Employee>
    {
        protected internal string UserName { get; set;  }
        protected internal string Password { get; set; }
        // when using an interface you need to implement the entire thing..
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

       // protected internal Employee NewUser = new Employee("Chuck", "Kang", "email address");
        //protected internal Manager NextUser = new Manager();
        public Employee() : base ()
        {
            UserName = "";
            Password = "";
        }

        public Employee(string strFirst) : base (strFirst)
        {
            UserName = "";
            Password = "";
        }

        public Employee(string strFirst, string strLast, string strEmail) : base(strFirst, strLast, strEmail)
        {
            UserName = "";
            Password = "";
        }

        public Employee(string strFirst, string strLast, string strEmail, string strUser, string strPass) : this (strFirst, strLast, strEmail)
        {
            UserName = strUser;
            Password = strPass;
        }

        public bool CheckDuplicate(Employee user1, Employee user2)
        {  //  This is a implementable interface available using iEmployee
            bool isSame = true;

            //  This is not quite complete
            
            return isSame;
        }

        public bool AddUser(Employee user1)
        {
            bool added = false;

           // added = NextUser.AddUser(NewUser);
            return added;
        }
        //*************************i equatable******************

        public bool Equals(Employee peeps)
        {
            bool isDuplicate = false;
            if ((FirstName == peeps.FirstName) && (LastName == peeps.LastName))
            { return true; }

            return isDuplicate;
        }

        //*************************i equatable******************
        //public int CompareTo(object obj)
        //{
        //    if (!(obj is Employee))
        //    {
        //        throw new ArgumentException("Object is not Employee");
        //    }
        //    Employee other = obj as Employee;
        //    return FirstName.CompareTo(other.FirstName);
        //    //return 1;
        //}
        // This will check to see if we can use the interface for the address to update the address
        // Not sure how this is difference than just instantiating a object.
        public bool UpdateAddress(string street, string city, string state, string zip)
        {
            bool isUpdated = false;
            //string displayAddress = "";
            IUser update = new Employee();
            update.Street = "abc";
            update.City = "san jose";
            update.State = "ca";
            update.Zip = "12354";
            isUpdated = update.UpdateAddress("123 Elm", "gilroy", "CA", "95020");

            //displayAddress = update.DisplayAddress();

            return isUpdated;
        }
          
        internal protected string DisplayEmployee()
        {
            string displayemployee = "";
            displayemployee += "FirstName - " + FirstName + "\n";
            displayemployee += "LastName - " + LastName + "\n";
            displayemployee += "Email - " + Email + "\n";
            displayemployee += "UserName - " + UserName + "\n";
            displayemployee += "Password - " + Password + "\n";

            return displayemployee;

        }
    }
}
