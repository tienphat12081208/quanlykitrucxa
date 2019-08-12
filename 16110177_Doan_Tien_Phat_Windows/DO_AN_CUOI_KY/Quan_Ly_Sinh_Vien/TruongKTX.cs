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
    public partial class TruongKTX : Form
    {
        public TruongKTX()
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
            txtMatruong.ResetText();
            txtTentruong.ResetText();
            DGVTruong.DataSource = QLKTX.usp_DanhsachSV();
        }
        private void TruongKTX_Load(object sender, EventArgs e)
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
            txtMatruong.ResetText();
            txtTentruong.ResetText();
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
                QLKTX.usp_ThemTruong(txtMatruong.Text, txtTentruong.Text);
                LoadData();
            }
            else if (co == 2)
            {
                btSua.Enabled = false;
                QLKTX.ups_CapnhatTruong(txtMatruong.Text, txtTentruong.Text);
                LoadData();
            }
            co = 0;
        }

        private void DGVTruong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMatruong.DataBindings.Clear();
            txtMatruong.DataBindings.Add("Text", DGVTruong.DataSource, "Matruong");
            txtTentruong.DataBindings.Clear();
            txtTentruong.DataBindings.Add("Text", DGVTruong.DataSource, "Tentruong");
            btSua.Enabled = true;
            btXoa.Enabled = true;

        }

        private void btSua_Click(object sender, EventArgs e)
        {

            if (Dangnhap.KTDN == true)
            {
                panel1.Enabled = true;
            txtMatruong.Enabled = false;
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
                QLKTX.ups_XoaTruong(txtMatruong.Text.Trim());
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
