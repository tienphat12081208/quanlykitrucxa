namespace Quan_Ly_Sinh_Vien
{
    partial class TimkiemSV_KTX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimkiemSV_KTX));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btTimkiemMSSV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.DGVSinhvien = new System.Windows.Forms.DataGridView();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPhong = new System.Windows.Forms.ComboBox();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tentruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSinhvien)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.btTimkiemMSSV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMSSV);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 99);
            this.panel1.TabIndex = 0;
            // 
            // btTimkiemMSSV
            // 
            this.btTimkiemMSSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimkiemMSSV.Image = ((System.Drawing.Image)(resources.GetObject("btTimkiemMSSV.Image")));
            this.btTimkiemMSSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimkiemMSSV.Location = new System.Drawing.Point(117, 52);
            this.btTimkiemMSSV.Name = "btTimkiemMSSV";
            this.btTimkiemMSSV.Size = new System.Drawing.Size(183, 31);
            this.btTimkiemMSSV.TabIndex = 8;
            this.btTimkiemMSSV.Text = "Tìm kiếm theo MSSV";
            this.btTimkiemMSSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimkiemMSSV.UseVisualStyleBackColor = true;
            this.btTimkiemMSSV.Click += new System.EventHandler(this.btTimkiemMSSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "MSSV:";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSSV.Location = new System.Drawing.Point(85, 16);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(146, 26);
            this.txtMSSV.TabIndex = 1;
            // 
            // DGVSinhvien
            // 
            this.DGVSinhvien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVSinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.Hoten,
            this.Ngaysinh,
            this.Tentruong,
            this.TenTP,
            this.Maphong,
            this.SoDT,
            this.Gioitinh});
            this.DGVSinhvien.Location = new System.Drawing.Point(10, 99);
            this.DGVSinhvien.Name = "DGVSinhvien";
            this.DGVSinhvien.Size = new System.Drawing.Size(778, 229);
            this.DGVSinhvien.TabIndex = 2;
            // 
            // btTimkiem
            // 
            this.btTimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btTimkiem.Image")));
            this.btTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimkiem.Location = new System.Drawing.Point(132, 53);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(210, 31);
            this.btTimkiem.TabIndex = 4;
            this.btTimkiem.Text = "Tìm Kiếm theo Mã phòng";
            this.btTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimkiem.UseVisualStyleBackColor = true;
            this.btTimkiem.Click += new System.EventHandler(this.btTimkiem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btTimkiem);
            this.panel2.Controls.Add(this.cbxPhong);
            this.panel2.Location = new System.Drawing.Point(419, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 95);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phòng:";
            // 
            // cbxPhong
            // 
            this.cbxPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPhong.FormattingEnabled = true;
            this.cbxPhong.Location = new System.Drawing.Point(87, 17);
            this.cbxPhong.Name = "cbxPhong";
            this.cbxPhong.Size = new System.Drawing.Size(157, 27);
            this.cbxPhong.TabIndex = 6;
            // 
            // MSSV
            // 
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            this.MSSV.Width = 80;
            // 
            // Hoten
            // 
            this.Hoten.DataPropertyName = "Hoten";
            this.Hoten.HeaderText = "Họ Tên";
            this.Hoten.Name = "Hoten";
            this.Hoten.Width = 130;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "Ngaysinh";
            this.Ngaysinh.HeaderText = "Ngày sinh";
            this.Ngaysinh.Name = "Ngaysinh";
            // 
            // Tentruong
            // 
            this.Tentruong.DataPropertyName = "Tentruong";
            this.Tentruong.HeaderText = "Tên trường ";
            this.Tentruong.Name = "Tentruong";
            this.Tentruong.Width = 150;
            // 
            // TenTP
            // 
            this.TenTP.DataPropertyName = "TenTP";
            this.TenTP.HeaderText = "Nơi sinh";
            this.TenTP.Name = "TenTP";
            this.TenTP.Width = 80;
            // 
            // Maphong
            // 
            this.Maphong.DataPropertyName = "Maphong";
            this.Maphong.HeaderText = "Mã Phòng";
            this.Maphong.Name = "Maphong";
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số điện thoại";
            this.SoDT.Name = "SoDT";
            // 
            // Gioitinh
            // 
            this.Gioitinh.DataPropertyName = "Gioitinh";
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.Name = "Gioitinh";
            // 
            // TimkiemSV_KTX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(802, 344);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DGVSinhvien);
            this.Controls.Add(this.panel1);
            this.Name = "TimkiemSV_KTX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm SV KTX";
            this.Load += new System.EventHandler(this.TimkiemSV_KTX_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSinhvien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.DataGridView DGVSinhvien;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.Button btTimkiemMSSV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tentruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
    }
}