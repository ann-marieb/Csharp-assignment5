/// Address.cs
/// Ann-Marie Bergström  ai2436 2017-11-29

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.ContactFiles
{
    public class Address
    {
        // street part of address
        private string street;
        // zip code part of address
        private string zipCode;
        // city part of address
        private string city;
        private Countries country;

        /// <summary>
        /// Property related to the field street
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string Street
        {
            // street part of address
            get { return street; }
            set { street = value; }
        }


        /// <summary>
        /// Property related to the field zipCode
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string ZipCode
        {
            // zip code part of address
            get { return zipCode; }
            set { zipCode = value; }
        }

        /// <summary>
        /// Property related to the field city
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string City
        {
            // zip code part of address
            get { return city; }
            set { city = value; }
        }

        /// <summary>
        /// Property related to the field country
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public Countries Country
        {
            // country part of address
            get { return country; }
            set { country = value; }
        }

        /// <summary> Default constructor
        /// </summary>
        public Address() : this (string.Empty, string.Empty, "Malmö")
        {

        }

        /// <summary> 
        /// Constructor
        /// </summary>
        public Address(string street, string zip, string city) : this(street, zip, city, Countries.Sverige)
        {

        }

        /// <summary> 
        /// Constructor
        /// </summary>
        public Address(string street, string zip, string city, Countries country)
        {
            this.street = street;
            this.zipCode = zip;
            this.city = city;
            this.country = country;
        }

       /// <summary> 
       /// Delete underscore char from country
       /// </summary>
       /// <returns>Country name without underscore char</returns>
       private string GetCountryString()
        {
            string strCountry = country.ToString();
            strCountry = strCountry.Replace("_", " ");
            return strCountry;
        }

        /// <summary>
        /// Override ToString method to return address formatted to one line
        /// </summary>
        /// <returns>Text string containing address</returns>
        public override string ToString()
        {
            string strOut = string.Format("{0, -25} {1, -8} 2, -10} {3}", street, zipCode, city, GetCountryString());
            return strOut;
        }

    }// close class
}// close namespace
