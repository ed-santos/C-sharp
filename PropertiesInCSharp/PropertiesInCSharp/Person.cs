using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInCSharp
{
    class Person
    {
        private string _firstname;
        private string _lastname;
        private string _fullname = "Edward Santos";

        //Property in C#
        //The name f the Propertyis Firstname
        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }

        public string FullName
        {
            get
            {
                return _firstname + _lastname;
            }
            
        }
    }
}
