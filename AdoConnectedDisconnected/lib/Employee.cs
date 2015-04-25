using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoConnectedDisconnected.lib
{
    class Employee : dbObject
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public DateTime dogumTarihi { get; set; }
        public string memleket { get; set; }
        public string ulke { get; set; }


        //public void guncelle()
        //{
        //    System.Windows.Forms.MessageBox.Show("Employee");
        //}
    }
}
