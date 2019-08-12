namespace Quan_Ly_Sinh_Vien
{
    partial class ReportSVTheoP_KTX
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.usp_LocSVtheoPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyKTXSVDataSet = new Quan_Ly_Sinh_Vien.QuanLyKTXSVDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPhong = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usp_LocSVtheoPhongTableAdapter = new Quan_Ly_Sinh_Vien.QuanLyKTXSVDataSetTableAdapters.usp_LocSVtheoPhongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usp_LocSVtheoPhongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyKTXSVDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // usp_LocSVtheoPhongBindingSource
            // 
            this.usp_LocSVtheoPhongBindingSource.DataMember = "usp_LocSVtheoPhong";
            this.usp_LocSVtheoPhongBindingSource.DataSource = this.QuanLyKTXSVDataSet;
            // 
            // QuanLyKTXSVDataSet
            // 
            this.QuanLyKTXSVDataSet.DataSetName = "QuanLyKTXSVDataSet";
            this.QuanLyKTXSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxPhong);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 79);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phòng:";
            // 
            // cbxPhong
            // 
            this.cbxPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPhong.FormattingEnabled = true;
            this.cbxPhong.Location = new System.Drawing.Point(113, 26);
            this.cbxPhong.Name = "cbxPhong";
            this.cbxPhong.Size = new System.Drawing.Size(289, 27);
            this.cbxPhong.TabIndex = 0;
            this.cbxPhong.SelectedIndexChanged += new System.EventHandler(this.cbxPhong_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 352);
            this.panel2.TabIndex = 2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.usp_LocSVtheoPhongBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Quan_Ly_Sinh_Vien.ReportSVtheoPhong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(843, 352);
            this.reportViewer1.TabIndex = 0;
            // 
            // usp_LocSVtheoPhongTableAdapter
            // 
            this.usp_LocSVtheoPhongTableAdapter.ClearBeforeFill = true;
            // 
            // ReportSVTheoP_KTX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 476);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReportSVTheoP_KTX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportSVTheoP_KTX";
            this.Load += new System.EventHandler(this.ReportSVTheoP_KTX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usp_LocSVtheoPhongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyKTXSVDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cbxPhong;
        private System.Windows.Forms.BindingSource usp_LocSVtheoPhongBindingSource;
        private QuanLyKTXSVDataSet QuanLyKTXSVDataSet;
        private QuanLyKTXSVDataSetTableAdapters.usp_LocSVtheoPhongTableAdapter usp_LocSVtheoPhongTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}