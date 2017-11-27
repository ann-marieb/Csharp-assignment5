/// Customer.cs
/// Ann-Marie Bergström  ai2436 2017-11-29

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment5.ContactFiles;

namespace Assignment5
{
    class Customer
    {
        private Contact contactObj; 
        private string id;

        /// <summary>
        /// Property related to contact
        /// Both read and write access
        /// </summary>
        public Contact ContactData
        {
            get => contactObj;
            set => contactObj = value;
        }

        /// <summary>
        /// Property related to the field id
        /// Both read and write access
        /// </summary>
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public Customer()
        {

        }

        public Customer(Contact contactIn, string id)
        {
            contactObj = contactIn;
            this.id = id;
        }

        public override string ToString()
        {
            string strOut = $" {id} {contactObj}";
            return strOut;
        }

    } // close class
} // close namespace
