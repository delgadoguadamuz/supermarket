using Context;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinInterface
{
    public partial class SupermarketUI : Form
    {
        private DataTable tableCustomers;
        private DataCustomers customerManager;

        public SupermarketUI()
        {
            InitializeComponent();

            tableCustomers = new DataTable();

            tableCustomers.Columns.Add("Id");
            tableCustomers.Columns.Add("Firstname");
            tableCustomers.Columns.Add("Lastname");
            tableCustomers.Columns.Add("Address");
            tableCustomers.Columns.Add("Telephone");

            customerManager = new DataCustomers();
            loadCustomers();
        }

        public void loadCustomers()
        {

            tableCustomers.Clear();
            List<Customer> allCustomers = customerManager.SelectAll();

            foreach (Customer currentCustomer in allCustomers)
            {
                DataRow row = tableCustomers.NewRow();

                row["Id"] = currentCustomer.CustomerId;
                row["Firstname"] = currentCustomer.FistName;
                row["Lastname"] = currentCustomer.LastName;
                row["Address"] = currentCustomer.Address;
                row["Telephone"] = currentCustomer.Telephone;

                tableCustomers.Rows.Add(row);

            }

            dgvCustomers.DataSource = tableCustomers;
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Address_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer objCustomer = new Customer();


            objCustomer.CustomerId = tbxCustomerId.Text != "" ? Convert.ToInt32(tbxCustomerId.Text) : 0;
            objCustomer.FistName = tbxFirtname.Text;
            objCustomer.LastName = tbxLastname.Text;
            objCustomer.Address = tbxAddress.Text;
            objCustomer.Telephone = Convert.ToInt32(tbxTelephone.Text);

            customerManager.Insert(objCustomer);
            loadCustomers();
            ClearCustomer();
        }

        public void ClearCustomer()
        {


            tbxFirtname.Text = string.Empty;
            tbxLastname.Text = string.Empty;
            tbxAddress.Text = string.Empty;
            tbxTelephone.Text = string.Empty;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearCustomer();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dgvCustomers.SelectedRows;

            DataGridViewRow row = rows[0];

            Customer customer = new Customer();
            customer.CustomerId = Convert.ToInt32(row.Cells["id"].Value);
            DataCustomers data = new DataCustomers();
            data.Delete(customer.CustomerId);

            loadCustomers();

        }

        private void dgvCustomers_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.Row.Selected)
            {
                DataRow row = tableCustomers.Rows[e.Row.Index];

                tbxFirtname.Text = Convert.ToString(row["Firstname"]);
                tbxCustomerId.Text = Convert.ToString(row["Id"]);
                tbxLastname.Text = Convert.ToString(row["Lastname"]);
                tbxAddress.Text = Convert.ToString(row["Address"]);
                tbxTelephone.Text = Convert.ToString(row["Telephone"]);
            }
        }
    }
}
