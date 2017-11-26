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
            get { return firstName; }
            set { firstName = value; }
        }

        /// <summary>
        /// Property related to the field last name
        /// Both read and write access
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
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
            get { return address; }
            set { address = value; }
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
            get { return email; }
            set { email = value; }
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
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.phone = phone;
            this.email = email;
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"></param>
        public Contact (Contact other)
        {
            this.firstName = other.firstName;
            this.lastName = other.lastName;
            this.address = other.address;
            this.phone = other.phone;
            this.email = other.email;
        }

        /// <summary>
        /// Method with check if input data is valid.
        /// </summary>
        /// <returns>true if first or last name, city and country.</returns>
        public bool Checkdata()
        {
            bool validName = !(string.IsNullOrWhiteSpace(FirstName) && string.IsNullOrWhiteSpace(LastName));
            return (validName && AddressData.IsAddressValid());
        }

        public override string ToString()
        {
            string strOut = $"{firstName}{lastName}{phone}{email}{address}";
            return strOut;
        }
    } // close class
} // close namespace
