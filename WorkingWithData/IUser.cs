using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithData

{
    interface IUser
    { // this interface will be used to connect all useful user updates
        // interfaces are just contracts that force a class to use these specific methods.
        // the signatures can be defined here but not implemented here.
         string Street { get; set; }
         string City { get; set; }
         string State { get; set; }
         string Zip { get; set; }

        bool UpdateAddress(string address, string city, string state, string zip); // this will update the addresss
    }
}
