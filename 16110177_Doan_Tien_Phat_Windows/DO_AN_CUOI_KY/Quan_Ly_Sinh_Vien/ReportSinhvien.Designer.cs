namespace Quan_Ly_Sinh_Vien
{
    partial class ReportSinhvien
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SinhvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyKTXSVDataSet = new Quan_Ly_Sinh_Vien.QuanLyKTXSVDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SinhvienTableAdapter = new Quan_Ly_Sinh_Vien.QuanLyKTXSVDataSetTableAdapters.SinhvienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SinhvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyKTXSVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SinhvienBindingSource
            // 
            this.SinhvienBindingSource.DataMember = "Sinhvien";
            this.SinhvienBindingSource.DataSource = this.QuanLyKTXSVDataSet;
            // 
            // QuanLyKTXSVDataSet
            // 
            this.QuanLyKTXSVDataSet.DataSetName = "QuanLyKTXSVDataSet";
            this.QuanLyKTXSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.SinhvienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Quan_Ly_Sinh_Vien.Report_Sinhvien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this.reportViewer1.Size = new System.Drawing.Size(850, 481);
            this.reportViewer1.TabIndex = 0;
            // 
            // SinhvienTableAdapter
            // 
            this.SinhvienTableAdapter.ClearBeforeFill = true;
            // 
            // ReportSinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 481);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportSinhvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo DS sinh viên";
            this.Load += new System.EventHandler(this.ReportSinhvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SinhvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyKTXSVDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SinhvienBindingSource;
        private QuanLyKTXSVDataSet QuanLyKTXSVDataSet;
        private QuanLyKTXSVDataSetTableAdapters.SinhvienTableAdapter SinhvienTableAdapter;
    }
}