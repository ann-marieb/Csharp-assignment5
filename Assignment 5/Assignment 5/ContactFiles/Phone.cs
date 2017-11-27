/// Phone.cs
/// Ann-Marie Bergström  ai2436 2017-11-29

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.ContactFiles
{
    public class Phone
    {
        //home phone
        private string home;
        //cell phone
        private string cell;

        /// <summary>
        /// Property related to the field home
        /// Both read and write access
        /// </summary>
        public string Home
        {
            //home phone
            get { return home; }
            set { home = value; }
        }

        /// <summary>
        /// Property related to the field cell
        /// Both read and write access
        /// </summary>
        public string Cell
        {
            get { return cell; }
            set { cell = value; }
        }

        /// <summary>
        /// Default constructor - calls another constructor in this class
        /// </summary>
        public Phone() : this(string.Empty, string.Empty)
        {
        }

        /// <summary>
        /// Constructor with two parameters
        /// </summary>
        public Phone(string homePhone, string cellPhone)
        {
            home = homePhone;
            cell = cellPhone;
        }

         /// <summary>
        /// Delivers a formatted string with data stored in the object. The values will
        /// appear as columns.  Make sure that a font like "Courier New" is used in
        /// the control displaying this information.
        /// </summary>
        /// <returns>the Formatted strings.</returns>
        public override string ToString()
        {
            string strOut = string.Format("{0,-20} {1, -20}", home, cell);
            return strOut;
        }

    } // close class
} //close namespace
