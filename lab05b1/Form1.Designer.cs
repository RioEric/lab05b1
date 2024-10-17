namespace lab05b1
{
    partial class Form1
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
            this.txtmsv = new System.Windows.Forms.TextBox();
            this.txtht = new System.Windows.Forms.TextBox();
            this.grbsv = new System.Windows.Forms.GroupBox();
            this.bttsua = new System.Windows.Forms.Button();
            this.bttxoa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdtb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picturesv = new System.Windows.Forms.PictureBox();
            this.cbbkhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvsv = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbcn = new System.Windows.Forms.CheckBox();
            this.bttaddpicture = new System.Windows.Forms.Button();
            this.grbsv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturesv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmsv
            // 
            this.txtmsv.Location = new System.Drawing.Point(122, 36);
            this.txtmsv.Name = "txtmsv";
            this.txtmsv.Size = new System.Drawing.Size(192, 22);
            this.txtmsv.TabIndex = 0;
            // 
            // txtht
            // 
            this.txtht.Location = new System.Drawing.Point(122, 92);
            this.txtht.Name = "txtht";
            this.txtht.Size = new System.Drawing.Size(192, 22);
            this.txtht.TabIndex = 1;
            // 
            // grbsv
            // 
            this.grbsv.Controls.Add(this.bttaddpicture);
            this.grbsv.Controls.Add(this.bttsua);
            this.grbsv.Controls.Add(this.bttxoa);
            this.grbsv.Controls.Add(this.label6);
            this.grbsv.Controls.Add(this.txtdtb);
            this.grbsv.Controls.Add(this.label5);
            this.grbsv.Controls.Add(this.label4);
            this.grbsv.Controls.Add(this.label3);
            this.grbsv.Controls.Add(this.label2);
            this.grbsv.Controls.Add(this.picturesv);
            this.grbsv.Controls.Add(this.cbbkhoa);
            this.grbsv.Controls.Add(this.txtmsv);
            this.grbsv.Controls.Add(this.txtht);
            this.grbsv.Location = new System.Drawing.Point(12, 91);
            this.grbsv.Name = "grbsv";
            this.grbsv.Size = new System.Drawing.Size(341, 383);
            this.grbsv.TabIndex = 2;
            this.grbsv.TabStop = false;
            this.grbsv.Text = "Thông Tinh Sinh Viên";
            // 
            // bttsua
            // 
            this.bttsua.Location = new System.Drawing.Point(75, 332);
            this.bttsua.Name = "bttsua";
            this.bttsua.Size = new System.Drawing.Size(75, 23);
            this.bttsua.TabIndex = 11;
            this.bttsua.Text = "thêm";
            this.bttsua.UseVisualStyleBackColor = true;
            this.bttsua.Click += new System.EventHandler(this.bttsua_Click);
            // 
            // bttxoa
            // 
            this.bttxoa.Location = new System.Drawing.Point(195, 332);
            this.bttxoa.Name = "bttxoa";
            this.bttxoa.Size = new System.Drawing.Size(75, 23);
            this.bttxoa.TabIndex = 10;
            this.bttxoa.Text = "xóa";
            this.bttxoa.UseVisualStyleBackColor = true;
            this.bttxoa.Click += new System.EventHandler(this.bttxoa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ảnh Đại Diện";
            // 
            // txtdtb
            // 
            this.txtdtb.Location = new System.Drawing.Point(122, 188);
            this.txtdtb.Name = "txtdtb";
            this.txtdtb.Size = new System.Drawing.Size(192, 22);
            this.txtdtb.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Điểm Trung Bình";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ho Ten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // picturesv
            // 
            this.picturesv.Location = new System.Drawing.Point(122, 238);
            this.picturesv.Name = "picturesv";
            this.picturesv.Size = new System.Drawing.Size(165, 88);
            this.picturesv.TabIndex = 3;
            this.picturesv.TabStop = false;
            // 
            // cbbkhoa
            // 
            this.cbbkhoa.FormattingEnabled = true;
            this.cbbkhoa.Items.AddRange(new object[] {
            "Công Nghệ Thông Tin",
            "Ngôn Ngữ ANH",
            "Quản Trị Kinh Doanh"});
            this.cbbkhoa.Location = new System.Drawing.Point(122, 146);
            this.cbbkhoa.Name = "cbbkhoa";
            this.cbbkhoa.Size = new System.Drawing.Size(192, 24);
            this.cbbkhoa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(284, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản Lý Sinh Viên";
            // 
            // dgvsv
            // 
            this.dgvsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.HOTEN,
            this.Khoa,
            this.DTB,
            this.ChuyenNganh});
            this.dgvsv.Location = new System.Drawing.Point(415, 91);
            this.dgvsv.Name = "dgvsv";
            this.dgvsv.RowHeadersWidth = 51;
            this.dgvsv.RowTemplate.Height = 24;
            this.dgvsv.Size = new System.Drawing.Size(675, 383);
            this.dgvsv.TabIndex = 4;
            this.dgvsv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.MinimumWidth = 6;
            this.MSSV.Name = "MSSV";
            this.MSSV.Width = 125;
            // 
            // HOTEN
            // 
            this.HOTEN.HeaderText = "Họ Tên";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Width = 125;
            // 
            // Khoa
            // 
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.MinimumWidth = 6;
            this.Khoa.Name = "Khoa";
            this.Khoa.Width = 125;
            // 
            // DTB
            // 
            this.DTB.HeaderText = "DTB";
            this.DTB.MinimumWidth = 6;
            this.DTB.Name = "DTB";
            this.DTB.Width = 125;
            // 
            // ChuyenNganh
            // 
            this.ChuyenNganh.HeaderText = "Chuyên Ngành";
            this.ChuyenNganh.MinimumWidth = 6;
            this.ChuyenNganh.Name = "ChuyenNganh";
            this.ChuyenNganh.Width = 125;
            // 
            // cbcn
            // 
            this.cbcn.AutoSize = true;
            this.cbcn.Location = new System.Drawing.Point(924, 65);
            this.cbcn.Name = "cbcn";
            this.cbcn.Size = new System.Drawing.Size(166, 20);
            this.cbcn.TabIndex = 5;
            this.cbcn.Text = "Chưa ĐK chuyên ngành";
            this.cbcn.UseVisualStyleBackColor = true;
            this.cbcn.CheckedChanged += new System.EventHandler(this.cbcn_CheckedChanged);
            // 
            // bttaddpicture
            // 
            this.bttaddpicture.Location = new System.Drawing.Point(293, 226);
            this.bttaddpicture.Name = "bttaddpicture";
            this.bttaddpicture.Size = new System.Drawing.Size(75, 23);
            this.bttaddpicture.TabIndex = 12;
            this.bttaddpicture.Text = "...";
            this.bttaddpicture.UseVisualStyleBackColor = true;
            this.bttaddpicture.Click += new System.EventHandler(this.bttaddpicture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 486);
            this.Controls.Add(this.cbcn);
            this.Controls.Add(this.dgvsv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbsv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbsv.ResumeLayout(false);
            this.grbsv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturesv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmsv;
        private System.Windows.Forms.TextBox txtht;
        private System.Windows.Forms.GroupBox grbsv;
        private System.Windows.Forms.PictureBox picturesv;
        private System.Windows.Forms.ComboBox cbbkhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdtb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttsua;
        private System.Windows.Forms.Button bttxoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvsv;
        private System.Windows.Forms.CheckBox cbcn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuyenNganh;
        private System.Windows.Forms.Button bttaddpicture;
    }
}

