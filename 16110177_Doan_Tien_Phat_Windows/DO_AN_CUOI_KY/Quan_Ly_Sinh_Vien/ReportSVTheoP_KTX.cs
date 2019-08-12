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
    public partial class ReportSVTheoP_KTX : Form
    {
        public ReportSVTheoP_KTX()
        {
            InitializeComponent();
        }
        QuanLyKTXSVEntitiesFinal1 QLKTX = new QuanLyKTXSVEntitiesFinal1();
        
        private void ReportSVTheoP_KTX_Load(object sender, EventArgs e)
        {
            
            cbxPhong.DisplayMember = "Maphong";
            cbxPhong.ValueMember = "Maphong";
            cbxPhong.DataSource = QLKTX.Phongs.ToList();
        }

        

        private void cbxPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.usp_LocSVtheoPhongTableAdapter.Fill
               (this.QuanLyKTXSVDataSet.usp_LocSVtheoPhong, Convert.ToInt32(cbxPhong.SelectedValue.ToString()));
            this.reportViewer1.RefreshReport();

        }

        
    }
}
