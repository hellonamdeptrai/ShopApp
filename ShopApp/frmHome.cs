﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form ChildForm, object btnSender)
        {
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(ChildForm);
            this.pnMain.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmProducts(), sender);
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCategories(), sender);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmUsers(), sender);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDefault(), sender);
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCarts(), sender);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAnalytics(), sender);
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            if (frmLogin.positionLogin.Equals("2"))
            {
                btnCategories.Enabled = false;
            }
            Code.Functions.Connect();
            OpenChildForm(new frmDefault(), sender);
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
