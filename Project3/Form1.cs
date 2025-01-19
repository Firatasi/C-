using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class Form1 : Form
    {
        CustomerManager customerManager = new CustomerManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              
            dgrwCustomers.DataSource = customerManager.GetAll();
            dgrwCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
           
            Customer customer = new Customer();

            customer.Id = Convert.ToInt32(tbxId.Text);
            customer.Email = tbxEmail.Text;
            customer.City = tbxCity.Text;
            customer.FirstName = tbxFirstName.Text;
            customer.LastName = tbxLastName.Text;   

            customerManager.Add(customer);

            dgrwCustomers.DataSource = customerManager.GetAll();


        }
    }
}
