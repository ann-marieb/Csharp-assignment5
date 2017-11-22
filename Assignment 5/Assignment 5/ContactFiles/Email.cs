/// email.cs
/// Ann-Marie Bergström ai2436 2017-11-29

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment5.ContactFiles
{
	public class Email
	{
		//private e-mail
		private string personal;
		//business e-mail
		private string business;

        /// <summary>
        /// Property related to the field personal
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string Personal
        {
            //private E-mail
            get { return personal; }
            set { personal = value; }
        }

        /// <summary>
        /// Property related to business field
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string Business
        {
            get { return business; }
            set { business = value; }
        }


        /// <summary>
        /// Default constructor - calls another constructor in this class
        /// </summary>
        public Email() : this(string.Empty)
		{

		}

		/// <summary>
		/// Constructor with one parameter - calls the constructor with
		/// two parameters, using a default value as the second argument.
		/// </summary>
		/// <param name="businessEMail">input coming from the client object</param>
		/// <remarks></remarks>
		public Email(string businessEMail) : this(businessEMail, string.Empty)
		{
		}

		/// <summary>
		/// Constructor with two parameters. This is  constructor that has most
		/// number of parameters. It is in tis constructor that all coding
		/// should be done.
		/// </summary>
		/// <param name="businessEMail">Input - office mail</param>
		/// <param name="personalEMail">Input - private mail</param>
		/// <remarks></remarks>
		public Email(string businessEMail, string personalEMail)
		{
			business = businessEMail;
			personal = personalEMail;
		}

        /// <summary>
        /// Default values
        /// </summary>
        public void DefaultValues()
        {
            //TODO ?
        }

        /// <summary>
        /// This method prepares a format string that is in sync with the ToString
        /// method.  It will be used in the MainForm as part of the heading for the ListBox
        /// before customer information is added in the ListBox.
        /// </summary>
        /// <value></value>
        /// <returns>A formatted string as heading for the values formatted in the ToString
        /// method below.</returns>
        /// <remarks></remarks>
        public string GetToStringItemsHeadings
		{
			get { return string.Format("{0,-20} {1, -20}", "Office E-mail", "Private E-mail"); }
		}

		/// <summary>
		/// Delivers a formatted string with data stored in the object. The values will
		/// appear as columns.  Make sure that a font like "Courier New" is used in
		/// the control displaying this information.
		/// </summary>
		/// <returns>the Formatted strings.</returns>
		/// <remarks></remarks> 1
		public override string ToString()
		{
			string strOut = string.Format("{0,-20} {1, -20}", business, personal);
			return strOut;
		}
	}
}  