using ShopApp.Code;
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

namespace ShopApp
{
    public partial class frmDetailOrder : Form
    {
        public frmDetailOrder()
        {
            InitializeComponent();
        }

        string idOrder, idPersonel, idCustommer, total;

        private void LoadDataGridView()
        {
            SqlCommand cmd = Functions.RunProcedure("GetOrderProducts");
            cmd.Parameters.Add(new SqlParameter("@Id_order", idOrder));

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            dap.Fill(dt);
            dgvOrderProduct.AutoGenerateColumns = false;
            dgvOrderProduct.DataSource = dt;
            dgvOrderProduct.Refresh();
            cmd.Cancel();
        }

        private void frmDetailOrder_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            lbPersonelId.Text = idPersonel;
            lbSumMoney.Text = total;

            SqlCommand cmd = Functions.RunProcedure("GetUserId");
            cmd.Parameters.Add(new SqlParameter("@Id", idCustommer));
            cmd.ExecuteNonQuery();
            SqlDataReader data = cmd.ExecuteReader();
            data.Read();

            lbIdUser.Text = data["Id"].ToString();
            lbNameUser.Text = data["Name"].ToString();
            lbEmailUser.Text = data["Email"].ToString();
            lbPhoneUser.Text = data["Phone"].ToString();
            lbAddressUser.Text = data["Address"].ToString();
        }

        public void DataFormChill(string idOrder, string idPersonel, string idCustommer, string total)
        {
            this.idOrder = idOrder;
            this.idPersonel = idPersonel;
            this.idCustommer = idCustommer;
            this.total = total;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearchUsers_Click(object sender, EventArgs e)
        {
            
        }
    }
}
