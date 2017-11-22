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
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
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
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
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
        /// Constructor 
        /// </summary>
        /// <param name></param>
        /// <param name></param>
        /// <remarks></remarks>
        public Phone(string homePhone, string cellPhone)
        {
            home = homePhone;
            cell = cellPhone;
        }
    
        public void DefaultValues()
        {
            //TODO
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
            get { return string.Format("{0,-20} {1, -20}", "Home Phone", "Cell Phone"); }
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
            string strOut = string.Format("{0,-20} {1, -20}", home, cell);
            return strOut;
        }
    } // close class
} //close namespace
