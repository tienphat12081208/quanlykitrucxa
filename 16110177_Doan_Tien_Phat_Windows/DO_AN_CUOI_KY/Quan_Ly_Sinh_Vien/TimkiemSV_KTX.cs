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
    public partial class TimkiemSV_KTX : Form
    {
        public TimkiemSV_KTX()
        {
            InitializeComponent();
        }
        QuanLyKTXSVEntitiesFinal1 QLSVKTX = new QuanLyKTXSVEntitiesFinal1();
        private void TimkiemSV_KTX_Load(object sender, EventArgs e)
        {
            cbxPhong.DataSource = QLSVKTX.Phongs.ToList();
            cbxPhong.DisplayMember = "Maphong";
            cbxPhong.ValueMember = "Maphong";
           
        }

        private void cbxPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            

        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            int a = int.Parse(cbxPhong.SelectedValue.ToString());
            DGVSinhvien.DataSource = QLSVKTX.usp_LocSVtheoPhong(a);
        }

        private void btTimkiemMSSV_Click(object sender, EventArgs e)
        {   try
            {
                int a = int.Parse(txtMSSV.Text);
                DGVSinhvien.DataSource = QLSVKTX.usp_LocDSSVtheoMSSV(a);
            }catch
            {
                MessageBox.Show("Vui lòng nhập lại MSSV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
