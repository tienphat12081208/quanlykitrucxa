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
    public partial class PhieudiennuocKTX : Form
    {
        public PhieudiennuocKTX()
        {
            InitializeComponent();
        }
        QuanLyKTXSVEntitiesFinal1 QLKTX = new QuanLyKTXSVEntitiesFinal1();
        Dangnhap Dangnhap = new Dangnhap();
        void LoadData()
        {

            

            cbxPhong.DataSource = QLKTX.Phongs.ToList();
            cbxPhong.DisplayMember = "Maphong";
            cbxPhong.ValueMember = "Maphong";
            var list = QLKTX.Phieudathutiens.ToList();
            DGVPhieudiennuocdathu.DataSource = list;
            
           

        }
        
        private void PhieudiennuocKTX_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }

        

       

        private void btTinhtien_Click(object sender, EventArgs e)
        {
            int b = int.Parse(cbxPhong.SelectedValue.ToString());
            DGVPhieudiennuoc.DataSource = QLKTX.usp_Tiendiennuoc(b);

            int r = DGVPhieudiennuoc.CurrentCell.RowIndex;
            this.lbTiendien.Text =
            DGVPhieudiennuoc.Rows[r].Cells[0].Value.ToString();
            this.lbTiennuoc.Text =
            DGVPhieudiennuoc.Rows[r].Cells[1].Value.ToString();
            this.blTong.Text =
            DGVPhieudiennuoc.Rows[r].Cells[3].Value.ToString();
            this.lbsonuoc.Text =
            DGVPhieudiennuoc.Rows[r].Cells[4].Value.ToString();
            this.lbsodien.Text =
            DGVPhieudiennuoc.Rows[r].Cells[5].Value.ToString();

        }

        private void blTong_Click(object sender, EventArgs e)
        {

        }

        private void btInphieu_Click_1(object sender, EventArgs e)
        {
            if (Dangnhap.KTDN == true)
            {
                try
                {
                    QLKTX.usp_Themphieudathu(int.Parse(lbsonuoc.Text.Trim()), int.Parse(lbTiennuoc.Text), int.Parse(lbsodien.Text), int.Parse(lbTiendien.Text),
                    int.Parse(blTong.Text), int.Parse(cbxPhong.SelectedValue.ToString()));
                    LoadData();
                    MessageBox.Show("Phiếu đã được lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("  Phiếu đã được in!!\n Bạn vui lòng sửa lại số điện nước để thực hiện lại thao tác!! \n  Cảm ơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }

            }
            else
            {

                DialogResult h = MessageBox.Show
                ("Bạn cần phải đăng nhập mới thực hiện thao tác này!!", "Thông Báo", MessageBoxButtons.OKCancel);
                if (h == DialogResult.OK)
                {
                    Dangnhap.ShowDialog();
                }

            }
        }
    }
}
