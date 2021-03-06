﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoConnectedDisconnected.lib
{
    public class Employee : dbObject
    {
        public bool changed = false;
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public DateTime dogumTarihi { get; set; }
        public string sehir { get; set; }
        public string ulke { get; set; }

        public void yerlestir(
            TextBox txtAd,
            TextBox txtSoyad,
            TextBox txtUlke,
            TextBox txtSehir,
            DateTimePicker dtpDogumTarihi,
            NumericUpDown txtId = null
            )
            
        {
            txtAd.Text = ad;
            txtSoyad.Text = soyad;
            txtSehir.Text = sehir;
            txtUlke.Text = ulke;
            dtpDogumTarihi.Value = dogumTarihi;
            txtId.Value = id;
            txtId.Enabled = false;
        }
        public void kaydet()
        {
            base.connect();
            SqlCommand komut;
            string sqlKod;

            sqlKod = @"INSERT INTO Employees ";
            sqlKod += "(FirstName, LastName, City, Country, BirthDate) ";
            sqlKod += " VALUES (@Ad, @Soyad, @Sehir, @Ulke, @DogumTarihi)";
            komut = parametreler(sqlKod);
            komut.ExecuteScalar();

            base.disconnect();
        }

        public void sil()
        {
            base.connect();
            SqlCommand komut;
            
            string sqlKod;
            sqlKod = @"DELETE FROM Employees WHERE EmployeeID = @ID";
            komut = new SqlCommand(cmdText: sqlKod, connection: conn);
            komut.Parameters.AddWithValue("@ID", id);
            komut.ExecuteScalar();
            base.disconnect();

        }
        public void guncelle()
        {
            base.connect();
            SqlCommand komut;
            string sqlKod;

            sqlKod = @"UPDATE Employees ";
            sqlKod += "SET FirstName = @Ad, ";
            sqlKod += "LastName = @Soyad, ";
            sqlKod += "City = @Sehir, ";
            sqlKod += "Country = @Ulke, ";
            sqlKod += "BirthDate = @DogumTarihi ";
            sqlKod += " WHERE EmployeeID = @ID ; ";

            komut = parametreler(sqlKod);

            try
            {
                komut.ExecuteScalar();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message,"Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            changed = false;

            base.disconnect();
            
        }

        private SqlCommand parametreler(string sqlKod)
        {
            SqlCommand komut;
            komut = new SqlCommand(cmdText: sqlKod, connection: conn);
            komut.Parameters.AddWithValue("@Ad", ad);
            komut.Parameters.AddWithValue("@Soyad", soyad);
            komut.Parameters.AddWithValue("@Sehir", sehir);
            komut.Parameters.AddWithValue("@Ulke", ulke);
            komut.Parameters.AddWithValue("@ID", id);
            komut.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
            return komut;
        }

        public override string ToString()
        {
            //return String.Format(
            //    "{0} | {1} {2}, {3}-{4}",
            //    id, ad, soyad, ulke, sehir
            //    );
            return TamAd;
        }

        public string TamAd
        {
            get {
                var e = String.Format("{1}, {0}", ad, soyad);
                if (changed){
                    e += " [*]";
                }
                return e;

            }
        }

    }
}
