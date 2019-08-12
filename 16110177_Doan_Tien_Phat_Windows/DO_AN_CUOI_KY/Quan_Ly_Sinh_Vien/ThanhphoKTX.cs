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
    public partial class ThanhphoKTX : Form
    {
        public ThanhphoKTX()
        {
            InitializeComponent();
        }
        QuanLyKTXSVEntitiesFinal1 QLKTX = new QuanLyKTXSVEntitiesFinal1();
        Dangnhap Dangnhap = new Dangnhap();
        int co = 1;
        void LoadData()
        {
            panel1.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btThem.Enabled = true;
            btLuu.Enabled = false;
            txtMaTP.ResetText();
            txtTenTP.ResetText();
            txtMaTP.Enabled = true;
            DGVThanhpho.DataSource = QLKTX.Thanhphoes.ToList();
        }

        private void ThanhphoKTX_Load(object sender, EventArgs e)
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
            txtMaTP.ResetText();
            txtTenTP.ResetText();
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
            int a = int.Parse(txtMaTP.Text);
            if (co == 1)
            {
                QLKTX.usp_ThemTP(a, txtTenTP.Text.Trim());
                LoadData();
            }
            else if (co == 2)
            {
                btSua.Enabled = false;
                QLKTX.ups_CapnhatTP(a, txtTenTP.Text.Trim());
                LoadData();
            }
            co = 0;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (Dangnhap.KTDN == true)
            {
                panel1.Enabled = true;
            txtMaTP.Enabled = false;
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

        private void DGVThanhpho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTP.DataBindings.Clear();
            txtMaTP.DataBindings.Add("Text", DGVThanhpho.DataSource, "MaTP");
            txtTenTP.DataBindings.Clear();
            txtTenTP.DataBindings.Add("Text", DGVThanhpho.DataSource, "TenTP");
            btSua.Enabled = true;
            btXoa.Enabled = true;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (Dangnhap.KTDN == true)
            {
                int a = int.Parse(txtMaTP.Text);
            QLKTX.ups_XoaTP(a);
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

        private void btHuybo_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
