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
        public Address() : this (string.Empty, string.Empty, string.Empty)
        {
        }

        /// <summary> 
        /// Constructor with three parameters
        /// </summary>
        public Address(string street, string zip, string city) : this(street, zip, city, Countries.No_country)
        {
        }

        /// <summary> 
        /// Constructor with four parameters
        /// </summary>
        public Address(string street, string zip, string city, Countries country)
        {
            this.street = street;
            this.zipCode = zip;
            this.city = city;
            this.country = country;
        }

       /// <summary> 
       /// Delete underscore char from selected country
       /// </summary>
       /// <returns>Country name without underscore char</returns>
       private string GetCountryString()
        {
            string strCountry = country.ToString();
            strCountry = strCountry.Replace("_", " ");
            return strCountry;
        }

        /// <summary>
        /// Delete underscore chars from all countries
        /// </summary>
        /// <returns>returns countries list without underscore chars </returns>
        public static List<string> GetAllCountryStrings()
        {
            List<string> countries = new List<string>();
            foreach (string country in Enum.GetNames(typeof(Countries)))
            {
                countries.Add(country.Replace("_", " "));
            }
            return countries;
        }

        /// <summary>
        /// Override ToString method to return address formatted to one line
        /// </summary>
        /// <returns>Text string containing address</returns>
        public override string ToString()
        {
            return $"{street,-25} {zipCode,-8} {city,-10} {GetCountryString(),-20}";
        }

        /// <summary>
        /// Method with check if input address data is valid.
        /// </summary>
        /// <returns>true if city and country.</returns>
        public bool IsAddressValid()
        {
            bool validCity = !(string.IsNullOrWhiteSpace(city));
            bool validCountry = country != Countries.No_country;
            return (validCity && validCountry);
        }

    }// close class
}// close namespace
