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
        private bool closeForm; // flag to handle closing of form
        //private Contact contact;

        /// <summary>
        /// Property:
        /// </summary> 
        public Contact ContactData
        {
            get => contactObj;
        }

        private Contact contactObj; //declare contactObj as type Contact

        /// <summary>
        /// Default constructor
        /// </summary>
        public ContactForm(string title)
        {
            InitializeComponent();
            InitializeGui(title);
            contactObj = new Contact(); // create contactObj
            UpdateGui();
        }

        // private void FillCountryComboBox()

        private void InitializeGui(string title)
        {
            this.Text = title;
            cboCountry.DataSource = Address.GetAllCountryStrings();
            txtFirstName.Focus();
            closeForm = true;
        }

        private void UpdateGui()
        {

        }

        /// <summary>
        /// Method: read input from form
        /// </summary>
        private void ReadInput()
        {
            ReadNames();
            ReadPhones();
            ReadEmails();
            ReadAddress();
        }

        /// <summary>
        /// Button click OK: read input and update GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContactOK_Click(object sender, EventArgs e)
        {
            ReadInput();
            if (contactObj.Checkdata())
            {
                string resultString = $"{contactObj.ToString()}";
                MessageBox.Show(resultString);
            }
            else
            {
                MessageBox.Show("A contact needs name, city and country.");
            }
        }

        /// <summary>
        /// Method: read names from form
        /// </summary>
        private void ReadNames()
        {
            contactObj.FirstName = txtFirstName.Text;
            contactObj.LastName = txtLastName.Text;
        }

        /// <summary>
        /// Method: read phones from form
        /// </summary>
        private void ReadPhones()
        {
            contactObj.PhoneData.Home = txtHomePhone.Text;
            contactObj.PhoneData.Cell = txtCellPhone.Text;
        }

        /// <summary>
        /// Method: read e-mails from form
        /// </summary>
        private void ReadEmails()
        {
            contactObj.EmailData.Business = txtEMailBus.Text;
            contactObj.EmailData.Personal = txtEMailPersonal.Text;
        }

        /// <summary>
        /// Method: read address from form
        /// </summary>
        private void ReadAddress()
        {
            contactObj.AddressData.Street = txtStreet.Text;
            contactObj.AddressData.City = txtCity.Text;
            contactObj.AddressData.ZipCode = txtZipCode.Text;
            contactObj.AddressData.Country = (Countries)cboCountry.SelectedIndex;
        }

        private void btnContactCancel_Click(object sender, EventArgs e)
        {

        }

        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeForm)
                e.Cancel = false; //close Contact form
            else
                e.Cancel = true; // not close Contact form
        }
    } // close class
} // close namespace
