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
        private List<Customer> customers; //declare list of customers

        private int nextID = 100;

        /// <summary>
        /// Property returning customer list.
        /// </summary>
        public List<Customer> Customers => customers;

        /// <summary>
        /// Property returning number of customers
        /// Only read access
        /// </summary>
        public int NumOfCustomers
        {
            get => customers.Count;
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
            customers = new List<Customer>(); //create list of customers
        }

        public bool AddCustomer (Contact contactIn)
        {
            Customer customerObj = new Customer(contactIn, NewID()); //declare and create customerobject
            customers.Add(customerObj);
            return true;
        }

        private string NewID()
        {
            nextID++;
            return nextID.ToString();
        }

        //Method returning a customer
        public Customer GetCustomer(int index)
        {
            return customers[index];
        }


        public bool EditCustomer(Customer customerIn, int index)
        {
            if (index >= NumOfCustomers || index == -1)
                return false;
            customers[index] = customerIn;
            return true;
        }

        public bool EditCustomer(Contact contactIn, int index)
        {
            if (index >= NumOfCustomers || index == -1)
                return false;
            customers[index].ContactData = contactIn;
            return true;
        }

        /// <summary>
        /// Deletes customer at specified index from customer list
        /// </summary>
        /// <param name="index"></param>
        /// <returns>true or false</returns>
        public bool DeleteCustomer(int index)
        {
            if (index >= NumOfCustomers || index == -1)
                return false;
            customers.RemoveAt(index);
            return true;
        }

        //public void TestValues()
        //{

        //}

        /// <summary>
        /// Create array of customer strings to display
        /// </summary>
        /// <returns> array in string format</returns>
        public string[] GetCustomerInfo()
        {
            string[] result = new string[NumOfCustomers]; //create result array object

            // for loop to list all customers 
            for (int i = 0; i < NumOfCustomers; i++)
            {
                result[i] = customers[i].ToString();
            }
            return result;
        }

    } //close class
} //close namespace
