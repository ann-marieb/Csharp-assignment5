using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class MainForm : Form
    {
        CustomerManager customerManagerObj = new CustomerManager();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //create an instance of Contactform with title as parameter
            ContactForm contactFormObj = new ContactForm("Add a new customer");

            if(contactFormObj.ShowDialog() == DialogResult.OK)
            {
                //add the new customer object
                customerManagerObj.AddCustomer(contactFormObj.ContactData);
                UpdateCustomerList();
            }
        }

        private void btnChangeCustomer_Click(object sender, EventArgs e)
        {
            int index = lstCustomers.SelectedIndex; //selected customer in listbox

            //If a customer is selected, export contact data to ContactForm
            if (index != -1)
                contactFormObj.ContactData = customerManagerObj.GetCustomer(index).ContactData;
        }
    } // close class
} // close namespace
