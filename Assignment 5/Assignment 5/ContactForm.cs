/// ContactForm.cs
/// Ann-Marie Bergström  ai2436 2017-11-29

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment5.ContactFiles;

namespace Assignment5
{
    public partial class ContactForm : Form
    {
        private bool closeForm;
        private Contact contact;

        public Contact ContactData
        {
            get;
            set;
        }

        Contact contactObj; //declare contactObj as type Contact


        public ContactForm()
        {
            InitializeComponent();

            contactObj = contact; // set contactObj to contact

            InitializeGui();
            UpdateGui();
        }

        private void btnContactOK_Click(object sender, EventArgs e)
        {

        }

        private void FillCountryComboBox()
        {

        }

        private void InitializeGui()
        {
            List<string> countriesList = new List<string>();

            = Enum.GetValues(typeof(Countries));
        }
 
        private void UpdateGui()
        {

        }

        /// <summary>
        /// Method
        /// </summary>
        /// <returns></returns>
        private Address ReadAddress()
        {

        }

        /// <summary>
        /// Method
        /// </summary>
        /// <returns></returns>
        private Address ReadPhones()
        {

        }

        /// <summary>
        /// Method
        /// </summary>
        /// <returns></returns>
        private Address ReadEmails()
        {

        }


    } // close class
} // close namespace
