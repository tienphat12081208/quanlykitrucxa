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
    public partial class LoaiPhongKTX : Form
    {
        public LoaiPhongKTX()
        {
            InitializeComponent();
        }
        QuanLyKTXSVEntitiesFinal1 QLKTX = new QuanLyKTXSVEntitiesFinal1();
        int co = 0;
        Dangnhap Dangnhap = new Dangnhap();
        void LoadData()
        {
            panel1.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btThem.Enabled = true;
            btLuu.Enabled = false;

            DGVLoaiPhong.DataSource = QLKTX.usp_Danhsachphong();
            DGVLoaiPhong.Refresh();
            txtMaLP.ResetText();
            txtTenLP.ResetText();
            txtMaLP.Enabled = true;
            txtTiendien.ResetText();
            txtTiennuoc.ResetText();
        }
        private void LoaiPhongKTX_Load(object sender, EventArgs e)
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
            txtMaLP.ResetText();
            txtTenLP.ResetText();
            txtMaLP.Enabled = true;
            txtTiendien.ResetText();
            txtTiennuoc.ResetText();
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
           int a = int.Parse(txtTiendien.Text);
           int b = int.Parse(txtTiennuoc.Text);
            if (co == 1)
            {
                QLKTX.usp_ThemLP(txtMaLP.Text.Trim(), txtTenLP.Text.Trim(),a, b);
                LoadData();
            }
            else if (co == 2)
            {
                btSua.Enabled = false;
                QLKTX.ups_CapnhatLP(txtMaLP.Text.Trim(), txtTenLP.Text.Trim(), a, b);
                LoadData();
            }
            co = 0;
        }

        private void DGVLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLP.DataBindings.Clear();
            txtMaLP.DataBindings.Add("Text", DGVLoaiPhong.DataSource, "MaLP");
            txtTenLP.DataBindings.Clear();
            txtTenLP.DataBindings.Add("Text", DGVLoaiPhong.DataSource, "TenLP");
            txtTiendien.DataBindings.Clear();
            txtTiendien.DataBindings.Add("Text", DGVLoaiPhong.DataSource, "Tiendien");
            txtTiennuoc.DataBindings.Clear();
            txtTiennuoc.DataBindings.Add("Text", DGVLoaiPhong.DataSource, "Tiennuoc");
            btSua.Enabled = true;
            btXoa.Enabled = true;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (Dangnhap.KTDN == true)
            {
                panel1.Enabled = true;
            txtMaLP.Enabled = false;
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

        private void btHuybo_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (Dangnhap.KTDN == true)
            {
                QLKTX.ups_XoaLP(txtMaLP.Text);
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
