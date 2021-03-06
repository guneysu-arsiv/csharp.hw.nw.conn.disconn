﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoConnectedDisconnected
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void calisanEklemeGuncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ui.Employee() {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            }.Show();
        }

        private void urunlerDisconnectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ui.Products()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            }.Show();

        }

        private void siparisDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ui.Orders()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            }.Show();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            //new ui.Employee()
            //{
            //    MdiParent = this,
            //    WindowState = FormWindowState.Maximized
            //}.Show();
        }
    }
}
