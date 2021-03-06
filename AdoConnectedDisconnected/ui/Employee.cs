﻿using System;
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
        public lib.Employee guncellenecekCalisan = null;
        public int guncellenecekCalisanID = -1;

        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // object skalerSonuc;
            uiDbCalisanlariGetir();
            uiYenile();
            uiCheck();

            lstEmployees.DataSource = calisanlar;
            lstEmployees.DisplayMember = "TamAd";
            lstEmployees.ValueMember = "id";

        }

        private void uiDbCalisanlariGetir()
        {
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

            calisanlar.Clear();
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

        }

        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            guncellenecekCalisanID = lstEmployees.SelectedIndex;


            if (lstEmployees.SelectedIndex > -1)
            {
                var x = calisanlar[guncellenecekCalisanID];
                guncellenecekCalisan = x;
                x.yerlestir(
                    txtAd: txtAd,
                    txtSoyad: txtSoyad,
                    txtSehir: txtSehir,
                    txtUlke: txtUlke,
                    dtpDogumTarihi: dtpDogumTarihi,
                    txtId: txtID
                    );
            }

            uiCheck();

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            uiTemizle();
            guncellenecekCalisan = null;
            uiCheck();
        }

        private void uiTemizle()
        {
            guncellenecekCalisan = null;
            txtAd.Clear();
            txtID.Value = 0;
            txtSoyad.Clear();
            txtSehir.Clear();
            txtUlke.Clear();
            dtpDogumTarihi.ResetText();
           // lstEmployees.SelectedIndex = -1;

        }

        private void uiYenile()
        {
            guncellenecekCalisan = null;
            uiListEmployees();
            uiCheck();
        }

        private void uiListEmployees()
        {
            lstEmployees.DataSource = null;
            lstEmployees.Items.Clear();
            lstEmployees.DataSource = calisanlar;
 
        }

        private void uiCheck()
        {
            btnGuncelle.Enabled = !(guncellenecekCalisan == null);
            btnSil.Enabled = !(guncellenecekCalisan == null);

            btnKaydet.Enabled = guncellenecekCalisan == null;
            btn2db.Enabled = lstEmployees.SelectedIndex > -1;
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            uiYeniCalisan().kaydet();
            uiDbCalisanlariGetir();

            uiTemizle();
            uiYenile();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            lib.Employee yeniCalisan = uiYeniCalisan();
            yeniCalisan.id = calisanlar[guncellenecekCalisanID].id;
            calisanlar[guncellenecekCalisanID] = yeniCalisan;

            uiTemizle();
            uiYenile();
        }

        private lib.Employee uiYeniCalisan()
        {
            return new lib.Employee()
            {
                ad = txtAd.Text,
                soyad = txtSoyad.Text,
                sehir = txtSehir.Text,
                ulke = txtUlke.Text,
                dogumTarihi = dtpDogumTarihi.Value,
                changed = true
            };
        }

        private void btn2db_Click(object sender, EventArgs e)
        {
            ((lib.Employee)lstEmployees.SelectedItem).guncelle();
            uiDbCalisanlariGetir();
            uiYenile();
        }

        private void btnAll2Db_Click(object sender, EventArgs e)
        {
            btnAll2Db.Enabled = false;
            foreach (var c in lstEmployees.Items)
            {
                 ((lib.Employee)c).guncelle();
            }
            uiYenile();
            uiDbCalisanlariGetir();

            btnAll2Db.Enabled = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ((lib.Employee)lstEmployees.SelectedItem).sil();
            uiDbCalisanlariGetir();

            guncellenecekCalisan = null;

            uiYenile();

            uiListEmployees();

            uiTemizle();
            uiCheck();
        }
    }
}
