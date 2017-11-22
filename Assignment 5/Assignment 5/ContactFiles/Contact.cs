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
        private string first_NameTTTTTT;
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
            get { return first_NameTTTTTT; }
            set { first_NameTTTTTT = value; }
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
            get { return phone; }
            set { phone = value; }
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
        public Contact() : this(string.Empty, string.Empty, new Address(), new Phone(), new Email())
        {
        }

        /// <summary>
        /// Constructor with five parameters. 
        /// </summary>
        /// <param name="firstName">first name</param>
        /// <param name="lastName">last name</param>
        /// <param name="address">last name</param>
        /// <param name="phone">last name</param>
        /// <param name="email">last name</param>
        /// <remarks></remarks>
        public Contact(string firstName, string lastName, Address address, Phone phone, Email email)
        {
            this.first_NameTTTTTT = firstName;
            this.lastName = lastName;
            this.address = address;
            this.phone = phone;
            this.email = email;
        }

        /// <summary>
        /// Method with check if input data is valid.
        /// </summary>
        /// <returns>true if first or last name, city and country.</returns>
        public bool Checkdata()
        {
            bool validName = !(string.IsNullOrWhiteSpace(FirstName) && string.IsNullOrWhiteSpace(LastName));
            bool validCity = !(string.IsNullOrWhiteSpace(AddressData.City));
            bool validCountry = AddressData.Country != Countries.No_country;
            return (validName && validCity && validCountry);
        }

        public override string ToString()
        {
            string strOut = string.Format("{0,-20} {1, -20}", first_NameTTTTTT, lastName);
            return strOut;
        }
    } // close class
} // close namespace
