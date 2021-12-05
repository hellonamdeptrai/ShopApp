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
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            EnabledButton(false);
            EnabledTextBox(false);
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            DataSet ds = Code.Functions.GetData("GetCategories");
            dgvCategories.DataSource = ds.Tables[0];
            dgvCategories.Refresh();
        }

        private void EnabledButton(bool status)
        {
            btnCreate.Enabled = status;
            btnEdit.Enabled = status;
            btnDelete.Enabled = status;
        }

        private void EnabledTextBox(bool status)
        {
            txtName.Enabled = status;
            txtDescription.Enabled = status;
        }

        private void ResetTextBox()
        {
            lbId.Text = "...";
            txtName.Text = "";
            txtDescription.Text = "";
        }

        private void ResetError()
        {
            lbNameError.Text = "";
            lbDescriptionError.Text = "";
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != dgvCategories.RowCount-1)
            {
                MessageBox.Show(e.RowIndex +" - "+ dgvCategories.RowCount);
                DataGridViewRow dgvRow = dgvCategories.Rows[e.RowIndex];
                lbId.Text = dgvRow.Cells["Id"].Value.ToString();
                txtName.Text = dgvRow.Cells["Names"].Value.ToString();
                txtDescription.Text = dgvRow.Cells["Description"].Value.ToString();
                EnabledTextBox(true);
                btnAdd.Enabled = false;
                btnCreate.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Equals(""))
            {
                lbNameError.Text = "Tên danh mục không được để trống!";
                return;
            }
            else
            {
                lbNameError.Text = "";
            }
            
            if (txtDescription.Text.Trim().Equals(""))
            {
                lbDescriptionError.Text = "Mô tả không được để trống!";
                return;
            }
            else
            {
                lbDescriptionError.Text = "";
            }
            SqlCommand cmd = Code.Functions.RunProcedure("CreateCategories");

            cmd.Parameters.Add(new SqlParameter("@Name", txtName.Text));
            cmd.Parameters.Add(new SqlParameter("@Description", txtDescription.Text));
            cmd.Parameters.Add(new SqlParameter("@Date_created", DateTime.Now.Date.ToString("MM/dd/yyyy")));
            cmd.Parameters.Add(new SqlParameter("@Date_edit", DateTime.Now.Date.ToString("MM/dd/yyyy")));

            cmd.ExecuteNonQuery();
            LoadDataGridView();
            ResetTextBox();
            EnabledButton(false);
            EnabledTextBox(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Equals(""))
            {
                lbNameError.Text = "Tên danh mục không được để trống!";
                return;
            }
            else
            {
                lbNameError.Text = "";
            }

            if (txtDescription.Text.Trim().Equals(""))
            {
                lbDescriptionError.Text = "Mô tả không được để trống!";
                return;
            }
            else
            {
                lbDescriptionError.Text = "";
            }
            SqlCommand cmd = Code.Functions.RunProcedure("UpdateCategories");

            cmd.Parameters.Add(new SqlParameter("@Id", lbId.Text));
            cmd.Parameters.Add(new SqlParameter("@Name", txtName.Text));
            cmd.Parameters.Add(new SqlParameter("@Description", txtDescription.Text));
            cmd.Parameters.Add(new SqlParameter("@Date_edit", DateTime.Now.Date.ToString("MM/dd/yyyy")));

            cmd.ExecuteNonQuery();
            LoadDataGridView();
            ResetTextBox();
            EnabledButton(false);
            EnabledTextBox(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục '" + txtName.Text + "' không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand cmd = Code.Functions.RunProcedure("DeleteCategories");

                cmd.Parameters.Add(new SqlParameter("@Id", lbId.Text));

                cmd.ExecuteNonQuery();
                LoadDataGridView();
                ResetTextBox();
                EnabledButton(false);
                EnabledTextBox(false);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EnabledTextBox(true);
            btnCreate.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            ResetTextBox();
            ResetError();
            EnabledButton(false);
            EnabledTextBox(false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = "";
            
            SqlCommand cmd = Code.Functions.RunProcedure("SearchCategories");
            if (int.TryParse(txtSearch.Text, out int i))
            {
                search = txtSearch.Text;
            }
            cmd.Parameters.Add(new SqlParameter("@Id", search));
            cmd.Parameters.Add(new SqlParameter("@Name", txtSearch.Text));

            cmd.ExecuteNonQuery();

            DataSet ds = new DataSet();

            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            dap.Fill(ds);
            dgvCategories.DataSource = ds.Tables[0];
            dgvCategories.Refresh();
        }
    }
}
