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
    public partial class MainForm : Form
    {
        CustomerManager customerManagerObj = new CustomerManager(); //declare and create CustomerManager object

        public MainForm()
        {
            InitializeComponent();
            InitializeGui();
            //UpdateGui(); TODO: remove in MainForm constructor
        }

        /// <summary>
        /// Intialize user interface
        /// </summary>
        private void InitializeGui()
        {
            this.Text = "Customer Register";
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



        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            int index = lstCustomers.SelectedIndex; //index of selected customer in listbox
            Contact c = customerManagerObj.GetCustomer(index).ContactData;
            //create an instance of Contactform with title as parameter
            ContactForm contactFormObj = new ContactForm("Edit a customer");

            contactFormObj.ContactData = new Contact(c);

            if (contactFormObj.ShowDialog() == DialogResult.OK)
            {
                customerManagerObj.EditCustomer(contactFormObj.ContactData, index); //add the edited customer object

                UpdateGui();
            }
        }

        //If a customer is selected, export contact data to ContactForm
        //if (index != -1)
        //    contactFormObj.ContactData = customerManagerObj.GetCustomer(index).ContactData;
        //

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int index = lstCustomers.SelectedIndex; //index of selected customer in listbox

            customerManagerObj.DeleteCustomer(index);

            UpdateGui();
        }
    } // close class
} // close namespace
