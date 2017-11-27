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
        public string Business
        {
            get { return business; }
            set { business = value; }
        }
        
        /// <summary>
        /// Default constructor 
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