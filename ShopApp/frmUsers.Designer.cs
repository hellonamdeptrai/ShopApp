
namespace ShopApp
{
    partial class frmUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttdong = new System.Windows.Forms.Button();
            this.bttxoa = new System.Windows.Forms.Button();
            this.bttsua = new System.Windows.Forms.Button();
            this.bttthem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbldienthoai = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblma = new System.Windows.Forms.Label();
            this.rbttgioitinhnu = new System.Windows.Forms.RadioButton();
            this.rbttgioitinhnam = new System.Windows.Forms.RadioButton();
            this.txtmausers = new System.Windows.Forms.TextBox();
            this.txttenuser = new System.Windows.Forms.TextBox();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btttimkiem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 507);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 123);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(577, 384);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách danh mục";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(16, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(557, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btttimkiem);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(577, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bttdong
            // 
            this.bttdong.Location = new System.Drawing.Point(7, 315);
            this.bttdong.Name = "bttdong";
            this.bttdong.Size = new System.Drawing.Size(99, 28);
            this.bttdong.TabIndex = 4;
            this.bttdong.Text = "&Đóng";
            this.bttdong.UseVisualStyleBackColor = true;
            // 
            // bttxoa
            // 
            this.bttxoa.Location = new System.Drawing.Point(152, 317);
            this.bttxoa.Name = "bttxoa";
            this.bttxoa.Size = new System.Drawing.Size(103, 26);
            this.bttxoa.TabIndex = 3;
            this.bttxoa.Text = "&Xóa";
            this.bttxoa.UseVisualStyleBackColor = true;
            // 
            // bttsua
            // 
            this.bttsua.Location = new System.Drawing.Point(7, 366);
            this.bttsua.Name = "bttsua";
            this.bttsua.Size = new System.Drawing.Size(99, 28);
            this.bttsua.TabIndex = 2;
            this.bttsua.Text = "&Sửa";
            this.bttsua.UseVisualStyleBackColor = true;
            // 
            // bttthem
            // 
            this.bttthem.Location = new System.Drawing.Point(155, 366);
            this.bttthem.Margin = new System.Windows.Forms.Padding(4);
            this.bttthem.Name = "bttthem";
            this.bttthem.Size = new System.Drawing.Size(100, 28);
            this.bttthem.TabIndex = 1;
            this.bttthem.Text = "&Thêm";
            this.bttthem.UseVisualStyleBackColor = true;
            this.bttthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(577, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.MaximumSize = new System.Drawing.Size(533, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(267, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 507);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bttthem);
            this.groupBox3.Controls.Add(this.bttsua);
            this.groupBox3.Controls.Add(this.bttxoa);
            this.groupBox3.Controls.Add(this.bttdong);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lbldienthoai);
            this.groupBox3.Controls.Add(this.lbldiachi);
            this.groupBox3.Controls.Add(this.lblhoten);
            this.groupBox3.Controls.Add(this.lblma);
            this.groupBox3.Controls.Add(this.rbttgioitinhnu);
            this.groupBox3.Controls.Add(this.rbttgioitinhnam);
            this.groupBox3.Controls.Add(this.txtmausers);
            this.groupBox3.Controls.Add(this.txttenuser);
            this.groupBox3.Controls.Add(this.txtdienthoai);
            this.groupBox3.Controls.Add(this.txtdiachi);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(267, 507);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giới tính:";
            // 
            // lbldienthoai
            // 
            this.lbldienthoai.AutoSize = true;
            this.lbldienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldienthoai.Location = new System.Drawing.Point(0, 208);
            this.lbldienthoai.Name = "lbldienthoai";
            this.lbldienthoai.Size = new System.Drawing.Size(87, 17);
            this.lbldienthoai.TabIndex = 9;
            this.lbldienthoai.Text = "Điện thoại:";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiachi.Location = new System.Drawing.Point(0, 154);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(63, 17);
            this.lbldiachi.TabIndex = 8;
            this.lbldiachi.Text = "Địa chỉ:";
            this.lbldiachi.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhoten.Location = new System.Drawing.Point(0, 105);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(61, 17);
            this.lblhoten.TabIndex = 7;
            this.lblhoten.Text = "Họ tên:";
            // 
            // lblma
            // 
            this.lblma.AutoSize = true;
            this.lblma.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblma.Location = new System.Drawing.Point(0, 50);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(34, 17);
            this.lblma.TabIndex = 6;
            this.lblma.Text = "Mã:";
            // 
            // rbttgioitinhnu
            // 
            this.rbttgioitinhnu.AutoSize = true;
            this.rbttgioitinhnu.Location = new System.Drawing.Point(188, 269);
            this.rbttgioitinhnu.Name = "rbttgioitinhnu";
            this.rbttgioitinhnu.Size = new System.Drawing.Size(47, 21);
            this.rbttgioitinhnu.TabIndex = 5;
            this.rbttgioitinhnu.TabStop = true;
            this.rbttgioitinhnu.Text = "Nữ";
            this.rbttgioitinhnu.UseVisualStyleBackColor = true;
            // 
            // rbttgioitinhnam
            // 
            this.rbttgioitinhnam.AutoSize = true;
            this.rbttgioitinhnam.Location = new System.Drawing.Point(104, 269);
            this.rbttgioitinhnam.Name = "rbttgioitinhnam";
            this.rbttgioitinhnam.Size = new System.Drawing.Size(58, 21);
            this.rbttgioitinhnam.TabIndex = 4;
            this.rbttgioitinhnam.TabStop = true;
            this.rbttgioitinhnam.Text = "Nam";
            this.rbttgioitinhnam.UseVisualStyleBackColor = true;
            // 
            // txtmausers
            // 
            this.txtmausers.Location = new System.Drawing.Point(100, 46);
            this.txtmausers.Name = "txtmausers";
            this.txtmausers.Size = new System.Drawing.Size(140, 22);
            this.txtmausers.TabIndex = 0;
            // 
            // txttenuser
            // 
            this.txttenuser.Location = new System.Drawing.Point(100, 101);
            this.txttenuser.Name = "txttenuser";
            this.txttenuser.Size = new System.Drawing.Size(140, 22);
            this.txttenuser.TabIndex = 1;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(100, 203);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(140, 22);
            this.txtdienthoai.TabIndex = 3;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(100, 150);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(140, 22);
            this.txtdiachi.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(567, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 507);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // btttimkiem
            // 
            this.btttimkiem.Location = new System.Drawing.Point(419, 67);
            this.btttimkiem.Name = "btttimkiem";
            this.btttimkiem.Size = new System.Drawing.Size(75, 23);
            this.btttimkiem.TabIndex = 0;
            this.btttimkiem.Text = "Tìm kiếm";
            this.btttimkiem.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 22);
            this.textBox1.TabIndex = 1;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 507);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUsers";
            this.Text = "frmCategories";
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bttthem;
        private System.Windows.Forms.TextBox txtmausers;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttenuser;
        private System.Windows.Forms.Button bttsua;
        private System.Windows.Forms.Button bttdong;
        private System.Windows.Forms.Button bttxoa;
        private System.Windows.Forms.Label lbldienthoai;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblma;
        private System.Windows.Forms.RadioButton rbttgioitinhnu;
        private System.Windows.Forms.RadioButton rbttgioitinhnam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btttimkiem;
    }
}