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
    public partial class QuanLyTaiKhoan_KTX : Form
    {
        public QuanLyTaiKhoan_KTX()
        {
            InitializeComponent();
        }
        QuanLyKTXSVEntitiesFinal1 QLKTX = new QuanLyKTXSVEntitiesFinal1();
        Dangnhap Dangnhap = new Dangnhap();
        int co = 0;
        void LoadData()
        {
            panel1.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btThem.Enabled = true;
            btLuu.Enabled = false;
            txtMatKhau.ResetText();
            txtTenDN.ResetText();
            txtTenDN.Enabled = true;
            DGVTaiKhoan.DataSource = QLKTX.usp_DS_Taikhoan();
        }
        private void QuanLyTaiKhoan_KTX_Load(object sender, EventArgs e)
        {

            LoadData();

        }

        
        private void btThem_Click(object sender, EventArgs e)
        {
            if (Dangnhap.KTDN == true)
            {
                panel1.Enabled = true;
                btXoa.Enabled = false;
                btSua.Enabled = false;
                btLuu.Enabled = true;
                txtTenDN.ResetText();
                txtMatKhau.ResetText();
                co = 1;
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

        private void btLuu_Click(object sender, EventArgs e)
        {
            
            if (co == 1)
            {
                QLKTX.usp_ThemTK(txtTenDN.Text.Trim(), txtMatKhau.Text.Trim());
                LoadData();
            }
            else if (co == 2)
            {
                btSua.Enabled = false;
                QLKTX.ups_CapnhatTK(txtTenDN.Text.Trim(), txtMatKhau.Text.Trim());
                LoadData();
            }
            co = 0;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (Dangnhap.KTDN == true)
            {
                panel1.Enabled = true;
                txtTenDN.Enabled = false;
                btThem.Enabled = false;
                btXoa.Enabled = false;
                btLuu.Enabled = true;
                co = 2;
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

        private void DGVTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenDN.DataBindings.Clear();
            txtTenDN.DataBindings.Add("Text", DGVTaiKhoan.DataSource, "username");
            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", DGVTaiKhoan.DataSource, "password");
            btSua.Enabled = true;
            btXoa.Enabled = true;

        }

        private void btHuybo_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (Dangnhap.KTDN == true)
            {
              
                QLKTX.ups_XoaTK(txtTenDN.Text.Trim());
                LoadData();
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
