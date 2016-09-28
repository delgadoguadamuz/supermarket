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
        private DataTable tablaCustomers;
        private DataCustomers customerManager;

        public SupermarketUI()
        {
            InitializeComponent();

            tablaCustomers = new DataTable();

            tablaCustomers.Columns.Add("Id");
            tablaCustomers.Columns.Add("Firstname");
            tablaCustomers.Columns.Add("Lastname");
            tablaCustomers.Columns.Add("Address");
            tablaCustomers.Columns.Add("Telephone");

            customerManager = new DataCustomers();

        }

        public void loadCustomers()
        {

            tablaCustomers.Clear();
            List<Customer> allCustomers = customerManager.SelectAll();

            foreach( DataCustomers currentCustomer in allCustomers)
            {
               data

                row["Id"] = currentCustomer.customerId;

            }


        }

    }
}
