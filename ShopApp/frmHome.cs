using System;
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
            OpenChildForm(new frmLogin(), sender);
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCategories(), sender);
        }
    }
}
