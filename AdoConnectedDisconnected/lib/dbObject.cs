using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoConnectedDisconnected.lib
{
    public abstract class dbObject
    {
        public static SqlConnection conn;

        public void connect()
        {
            try
            {
                conn = dbConnect(db: "NORTHWND");
            }
            catch (Exception)
            {
                conn = dbConnect();
            }
            finally
            {
                System.Diagnostics.Trace.WriteLine("Connected");
            }
        }

        public static SqlConnection dbConnect(string db = "Northwind")
        {
            SqlConnection conn = new SqlConnection();
            string connStr = String.Format(
                arg0: db,
                format: @"server=.; database={0}; Integrated Security=sspi;"
                );

            conn.ConnectionString = connStr;
            conn.Open();
            return conn;
        }

        public void disconnect()
        {
            try
            {
                conn.Close();
            }
            catch (Exception e)
            {
                System.Diagnostics.Trace.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
                System.Diagnostics.Trace.WriteLine("Disconnected");
            }
        }

        public void guncelle()
        {
            throw new NotImplementedException();
        }

        public dbObject()
        {
            // connect();
        }

        ~dbObject()
        {
            try
            {
                disconnect();
            }
            catch (Exception)
            {

            }
        }
    }
}
