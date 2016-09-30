using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {

        public Customer()
        {

        }


        public Customer(int customerId)
        {
            this.CustomerId = customerId;
        }

        private string _lastName; //Backing field

        public string LastName //Property
        {
            get // Used to return the backing field _lastName, you can include code to perform any opperations prior to returning the value
                //i.e code to reformat the data or verify the user is able to access this data (permissions)
            {
                // Any code here
                return _lastName;
            }
            set // This is accessed when the code assigns a value to the property, can add code to validate the value before assigning it
            {
                // Any code here
                _lastName = value;
            }
        }

        public static int InstanceCount { get; set; }

        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; } //private set: We can set the property in the code but any code external to this class cannot

        public string FullName
        {
            get
            {
                string fullname = LastName;

                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullname))
                    {
                        fullname += ", ";
                    }
                    fullname += FirstName;
                }
                return fullname;
            }

        }


        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }


    }
}
