using BeautySalonProject.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySalonProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Customer c = new Customer()
            {
                Address = "Kars",
                Name = "Name",
                Surname = "Surname",
                PhoneNumber = "1234567890"
            };

            CustomerDB.DeleteCustomer(1);
            CustomerDB.AddCustomer(c);
        }
    }
}
