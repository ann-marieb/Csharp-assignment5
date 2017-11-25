/// CustomerManager.cs
/// Ann-Marie Bergström  ai2436 2017-11-29

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment5.ContactFiles;

namespace Assignment5
{
    class CustomerManager
    {
        private List<Customer> customers;

        /// <summary>
        /// Property returning ...
        /// Only read access
        /// </summary>
        public int Count
        {
            get;
        }

        /// <summary>
        /// Property returning ID
        /// Only read access
        /// </summary>
        public int GetNewID
        {
            get;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public CustomerManager()
        {
            List<Customer> customers = new List<Customer>();
        }

        public bool AddCustomer (Contact contactIn)
        {

            customers.Add(contactIn);
            return true;
        }
        
        public Customer GetCustomer(int index)
        {

        }

        public string [] GetCustomerInfo(int index)
        {

        }

        public bool ChangeCustomer(Contact contactIn, int index)
        {

        }

        public bool DeleteCustomer(int index)
        {

        }

        public void TestValues()
        {

        }


    } //close class
} //close namespace
