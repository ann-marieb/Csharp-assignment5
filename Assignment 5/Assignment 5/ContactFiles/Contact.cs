/// Contact.cs
/// Ann-Marie Bergström  ai2436 2017-11-29

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.ContactFiles
{
    public class Contact
    {
        private string firstName;
        private string lastName;
        private Address address;
        private Phone phone;
        private Email email;

        /// <summary>
        /// Property related to the field first name
        /// Both read and write access
        /// </summary>
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// Property related to the field last name
        /// Both read and write access
        /// </summary>
        public string LastName
        {
            get;
            set;
        }

        /// <summary>
        /// Property returning full name
        /// Only read access
        /// </summary>
        public string FullName
        {
            get;
        }

        /// Property related to the field address
        /// Both read and write access
        /// </summary>
        public Address AddressData
        {
            get;
            set;
        }

        /// Property related to the field phone
        /// Both read and write access
        /// </summary>
        public Phone PhoneData
        {
            get;
            set;
        }

        /// Property related to the field email
        /// Both read and write access
        /// </summary>
        public Email EmailData
        {
            get;
            set;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        Contact()
        {

        }

        /// <summary>
        /// Constructor with five parameters. 
        /// </summary>
        /// <param name="firstName">first name</param>
        /// <param name="lastName">last name</param>
        /// <param name="adress">last name</param>
        /// <param name="phone">last name</param>
        /// <param name="email">last name</param>
        /// <remarks></remarks>
        public Email(string firstName, string lastName, Address adress, Phone phone, Email email)
        {
        //TODO
        }
        public override string ToString()
        {
            //string strOut =  TODO
            return strOut;
        }
    } // close class
} // close namespace
