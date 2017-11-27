/// MainForm.cs
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
    /// MainForm: user interface, handles customer list
    /// </summary>
    public partial class MainForm : Form
    {
        //declare and create CustomerManager object
        CustomerManager customerManagerObj = new CustomerManager(); 

        /// <summary>
        /// Default constructor MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGui();
        }

        /// <summary>
        /// Intialize user interface
        /// </summary>
        private void InitializeGui()
        {
            this.Text = "Customer Register";
            lstCustomers.Items.Clear();
        }

        /// <summary>
        /// Update user interface
        /// </summary>
        private void UpdateGui()
        {
            lstCustomers.Items.Clear();
            lstCustomers.Items.AddRange(customerManagerObj.GetCustomerInfo());
        }
        
        /// <summary>
        /// add customer to customer list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //create an instance of Contactform with title as parameter
            ContactForm contactFormObj = new ContactForm("Add a new customer");

            if(contactFormObj.ShowDialog() == DialogResult.OK)
            {
                customerManagerObj.AddCustomer(contactFormObj.ContactData); //add the new customer object

                UpdateGui();
            }
        }
        
        /// <summary>
        /// edit customer if selected in list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            int index = lstCustomers.SelectedIndex; //index of selected customer in listbox
            //check if index is out of range, ie if no customer is selected
            if (!customerManagerObj.CheckIndex(index))
            {
                MessageBox.Show("Please select a customer in the customer list.");
            }
            else
            {
                //get customer from customer manager
                Contact c = customerManagerObj.GetCustomer(index).ContactData;
                //create an instance of Contactform with title as parameter
                ContactForm contactFormObj = new ContactForm("Edit a customer");

                contactFormObj.ContactData = new Contact(c);

                if (contactFormObj.ShowDialog() == DialogResult.OK)
                {
                    customerManagerObj.EditCustomer(contactFormObj.ContactData, index); //add the edited customer object

                    UpdateGui(); //update customer list
                }
            }
        }

        /// <summary>
        /// delete customer if selected in list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int index = lstCustomers.SelectedIndex; //index of selected customer in listbox

            //check if index is out of range, ie if no customer is selected
            if (!customerManagerObj.CheckIndex(index))
            {
                MessageBox.Show("Please select a customer in the customer list.");
                return;
            }
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Are you sure?",
                "Think twice!", buttons);

            if (result == DialogResult.Cancel)
                return;
            else
             customerManagerObj.DeleteCustomer(index); //delete customer at selected index

            UpdateGui();
        }

    } // close class
} // close namespace
