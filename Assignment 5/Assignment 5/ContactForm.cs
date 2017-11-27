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
    /// <summary>
    /// ContactForm: uers interface, handles contact data
    /// </summary>
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
            set
            {
                contactObj = value;
                UpdateGui();
            }
        }

        private Contact contactObj; //declare contactObj as type Contact

        /// <summary>
        /// constructor with one parameter
        /// </summary>
        /// <param name="title"></param>
        public ContactForm(string title)
        {
            InitializeComponent();
            InitializeGui(title);
            contactObj = new Contact(); // create contactObj
            UpdateGui();
        }

        /// <summary>
        /// initialize user interface
        /// </summary>
        /// <param name="title"></param>
        private void InitializeGui(string title)
        {
            this.Text = title;
            cboCountry.DataSource = Address.GetAllCountryStrings();
            txtFirstName.Focus();
            closeForm = true;
        }

        /// <summary>
        /// update user interface
        /// </summary>
        private void UpdateGui()
        {
            txtFirstName.Text = contactObj.FirstName;
            txtLastName.Text = contactObj.LastName;
            txtHomePhone.Text = contactObj.PhoneData.Home;
            txtCellPhone.Text = contactObj.PhoneData.Cell;
            txtEMailBus.Text = contactObj.EmailData.Business;
            txtEMailPersonal.Text = contactObj.EmailData.Personal;
            txtStreet.Text = contactObj.AddressData.Street;
            txtCity.Text = contactObj.AddressData.City;
            txtZipCode.Text = contactObj.AddressData.ZipCode;
            cboCountry.SelectedIndex = (int) contactObj.AddressData.Country ;
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
                //string resultString = $"{contactObj.ToString()}";
                //MessageBox.Show(resultString);
                closeForm = true;
            }
            else
            {
                MessageBox.Show("A contact needs name, city and country.");
                closeForm = false;
            }
        }
        /// <summary>
        /// Button click Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContactCancel_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Discard all changes?",
                "Think twice!", buttons);

            if (result == DialogResult.OK)
                closeForm = true;
            else
                closeForm = false;
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



        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeForm)
                e.Cancel = false; //close Contact form
            else
                e.Cancel = true; // not close Contact form
        }
    } // close class
} // close namespace
