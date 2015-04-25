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
using System.Diagnostics;

namespace AdoConnectedDisconnected.ui
{
    public partial class Employee : Form
    {
        public List<lib.Employee> calisanlar = new List<lib.Employee>();
        public lib.Employee guncellenecekCalisan;
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // object skalerSonuc;
            string sqlKod;
            SqlConnection conn;
            SqlCommand sqlKomut;
            SqlDataReader kafa;


            try
            {
                conn = lib.dbObject.dbConnect("NORTHWND");
            }
            catch (Exception)
            {
                conn = lib.dbObject.dbConnect();
            }
            finally
            {
                Trace.WriteLine("Connected");
            }

            sqlKod = "SELECT * FROM EMPLOYEES";
            sqlKomut = new SqlCommand(
                cmdText: sqlKod,
                connection: conn
                );

            // skalerSonuc = sqlKomut.ExecuteScalar();
            kafa = sqlKomut.ExecuteReader();

            while (kafa.Read())
            {
                calisanlar.Add(
                    new lib.Employee()
                        {
                            id = (int)kafa["EmployeeID"],
                            ad = kafa["FirstName"].ToString(),
                            soyad = kafa["LastName"].ToString(),
                            dogumTarihi = (DateTime)kafa["BirthDate"],
                            sehir = kafa["City"].ToString(),
                            ulke = kafa["Country"].ToString()
                        }
                );
            }

            foreach (var c in calisanlar)
            {
                Trace.WriteLine(c);
                lstEmployees.DataSource = calisanlar;
                lstEmployees.DisplayMember = "TamAd";
                lstEmployees.ValueMember = "id";
            }

            uiYenile();
        }

        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            var x = (lib.Employee)lstEmployees.SelectedItem;
            guncellenecekCalisan = x;
            x.yerlestir(
                txtAd: txtAd,
                txtSoyad: txtSoyad,
                txtSehir: txtSehir,
                txtUlke: txtUlke,
                dtpDogumTarihi: dtpDogumTarihi,
                txtId: txtID
                );
            uiYenile();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtID.Value = 0;
            txtSoyad.Clear();
            txtSehir.Clear();
            txtUlke.Clear();
            dtpDogumTarihi.ResetText();
            guncellenecekCalisan = null;
            uiYenile();
        }

        private void uiYenile()
        {
            btnGuncelle.Enabled = !(guncellenecekCalisan == null);
            btnKaydet.Enabled = guncellenecekCalisan == null;
        }




    }
}
