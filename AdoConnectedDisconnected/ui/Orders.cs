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
    public partial class Orders : Form
    {

        public SqlConnection conn = new SqlConnection();
        public SqlDataAdapter x_Employees;
        public DataTable dt_Employees = new DataTable();

        public SqlDataAdapter x_Orders;
        public DataTable dt_Orders = new DataTable();

        public SqlDataAdapter x_OD;
        public DataTable dt_OD = new DataTable();


        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            try
            {
                conn.ConnectionString = "server=.;database=northwind;integrated security=sspi;";
                conn.Open();
            }
            catch (Exception)
            {
                conn.ConnectionString = "server=.;database=northwnd;integrated security=sspi;";
                conn.Open();
            }

            dt_Employees.Columns.Add("EmployeeID", typeof(int));
            dt_Employees.Columns.Add("FirstName", typeof(string));
            dt_Employees.Columns.Add("LastName", typeof(string));
            dt_Employees.Columns.Add("FullName", typeof(string));

            dt_Orders.Columns.Add("OrderID", typeof(int));

            dt_OD.Columns.Add("ProductID", typeof(int));
            dt_OD.Columns.Add("ProductName", typeof(string));

            x_Employees = new SqlDataAdapter(
                selectCommandText: "SELECT EmployeeID, FirstName, LastName, CONCAT(LastName, ', ' , FirstName)[FullName] from Employees",
                selectConnection: conn
             );

            x_Employees.Fill(dataTable: dt_Employees);
            lstEmployees.DataSource = dt_Employees;


            lstEmployees.DisplayMember = "FullName";
            lstEmployees.ValueMember = "EmployeeID";

            lstOrders.DataSource = dt_Orders;
            lstOrders.DisplayMember = "OrderID";
            lstOrders.ValueMember = "OrderID";

            lstProducts.DataSource = dt_OD;
            lstProducts.DisplayMember = "ProductName";

        }

        private void Orders_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void lstEmployees_SelectedValueChanged(object sender, EventArgs e)
        {
            int EmployeeID = -1;

            try
            {
                EmployeeID = (int)lstEmployees.SelectedValue;
            }
            catch (Exception buzz)
            {
                uiError(buzz);
            }

            SqlCommand sql_getOrders = new SqlCommand();

            string komut;
            komut = "SELECT OrderID from Orders ";
            komut += "WHERE EmployeeID = @EmployeeID";

            x_Orders = new SqlDataAdapter(selectCommandText: komut, selectConnection: conn);
            dt_Orders.Clear();
            try
            {
                x_Orders.SelectCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            }
            catch (Exception)
            {

            }
            finally
            {
                x_Orders.Fill(dataTable: dt_Orders);
            }

        }

        private void lstOrders_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlCommand sql_getOrderDetails = new SqlCommand();
            int OrderID = -1;

            try
            {
                OrderID = (int)lstOrders.SelectedValue;
            }
            catch (Exception buzz)
            {
                uiError(buzz);
            }

            string komut;
            komut = "SELECT OD.ProductID, P.ProductName from [Order Details] OD ";
            komut += "JOIN Products P ON P.ProductID = OD.ProductID ";
            komut += "WHERE OrderID = @OrderID";

            x_OD = new SqlDataAdapter(selectCommandText: komut, selectConnection: conn);
            dt_OD.Clear();
            try
            {
                x_OD.SelectCommand.Parameters.AddWithValue("@OrderID", OrderID);
            }
            catch (Exception)
            {

            }
            finally
            {
                x_OD.Fill(dataTable: dt_OD);
            }
        }

        private static void uiError(Exception buzz)
        {
            System.Diagnostics.Trace.WriteLine(buzz.Message);
        }
    }
}
