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
    public partial class Trangchu : Form
    {
        Dangnhap dangnhap = new Dangnhap();
        public Trangchu()
        {
            InitializeComponent();
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {
           
            
        }

        private void sữaThôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhongKTX phongKTX = new PhongKTX();
            phongKTX.ShowDialog();
        }

        private void thêmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinhvienKTX sinhvienKTX = new SinhvienKTX();
            sinhvienKTX.ShowDialog();
        }

        private void trườngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TruongKTX truongKTX = new TruongKTX();
            truongKTX.ShowDialog();
        }

        private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiPhongKTX loaiPhongKTX = new LoaiPhongKTX();
            loaiPhongKTX.ShowDialog();
        }

        private void phiếuĐiệnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieudiennuocKTX phieudiennuocKTX = new PhieudiennuocKTX();
            phieudiennuocKTX.ShowDialog();
        }

        private void thốngKêĐiệnNước1ThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dangnhap.KTDN == true)
            {
                ThongkediennuocKTX thongkediennuocKTX = new ThongkediennuocKTX();
                thongkediennuocKTX.ShowDialog();
            }
            
            else
            {
                
                    DialogResult h = MessageBox.Show
                    ("Bạn cần phải đăng nhập mới thực hiện thao tác này!!", "Thông Báo", MessageBoxButtons.OKCancel);
                    if (h == DialogResult.OK)
                    {
                        dangnhap.ShowDialog();
                    }
                
            }
        
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dangnhap.KTDN == false)
            {
                dangnhap.ShowDialog();
            }else
            {
                MessageBox.Show("Bạn đã đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dangnhap.KTDN == true)
            {
                Dangnhap.KTDN = false;
                Dangnhap.KTAD = false;
                MessageBox.Show("Đăng xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                DialogResult h = MessageBox.Show
                    ("Bạn cần phải đăng nhập mới thực hiện thao tác này!!", "Thông Báo", MessageBoxButtons.OKCancel);
                if (h == DialogResult.OK)
                {
                    dangnhap.ShowDialog();
                }

            }
            

        }

        private void điệnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhphoKTX thanhpho = new ThanhphoKTX();
            thanhpho.ShowDialog();
        }

        private void báoCáoDanhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportSinhvien reportSinhvien = new ReportSinhvien();
            reportSinhvien.ShowDialog();
        }

        private void báoCáoDanhSáchSinhViênTheoPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportSVTheoP_KTX reportSVTheoP_KTX = new ReportSVTheoP_KTX();
            reportSVTheoP_KTX.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (Dangnhap.KTAD == true)
            {
                QuanLyTaiKhoan_KTX quanLyTaiKhoan_KTX = new QuanLyTaiKhoan_KTX();
                quanLyTaiKhoan_KTX.ShowDialog();
            }

            else
            {

                MessageBox.Show("Chỉ có admin mới có quyền này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        
        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tìmKiếmDSSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimkiemSV_KTX timkiemSV_KTX = new TimkiemSV_KTX();
            timkiemSV_KTX.ShowDialog();
        }
    }
}
