using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sinh_Vien
{
    public partial class ReportSinhvien : Form
    {
        public ReportSinhvien()
        {
            InitializeComponent();
        }

        private void ReportSinhvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyKTXSVDataSet.Sinhvien' table. You can move, or remove it, as needed.
            this.SinhvienTableAdapter.Fill(this.QuanLyKTXSVDataSet.Sinhvien);

            this.reportViewer1.RefreshReport();
        }
    }
}
