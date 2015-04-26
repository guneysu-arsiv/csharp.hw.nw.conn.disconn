using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoConnectedDisconnected.ui
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter;
            DataTable dt = new DataTable("Products");
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("UnitPrice", typeof(float));

            //dt.Rows.Add("Baklava", 30.0);
            //dt.Rows.Add("Baklava", 30.0);
            //dt.Rows.Add("Baklava", 30.0);
            //dt.Rows.Add("Baklava", 30.0);
            //dt.Rows.Add("Baklava", 30.0);

            try
            {
                adapter = new SqlDataAdapter(
                   selectCommandText: "select ProductName, UnitPrice from Products",
                   selectConnectionString: "server=.;database=northwnd;integrated security=sspi;");
            }
            catch (Exception)
            {
                adapter = new SqlDataAdapter(
                   selectCommandText: "select ProductName, UnitPrice from Products",
                   selectConnectionString: "server=.;database=northwind;integrated security=sspi;");
            }

            adapter.Fill(dataTable: dt);

            lstProducts.DataSource = dt;
            lstUnitPrices.DataSource = dt;

            lstProducts.DisplayMember = "ProductName";
            lstUnitPrices.DisplayMember = "UnitPrice";

        }
    }
}
