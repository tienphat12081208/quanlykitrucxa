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
    public partial class PhongKTX : Form
    {
        public PhongKTX()
        {
            InitializeComponent();
        }
      
        QuanLyKTXSVEntitiesFinal1 QLKTX = new QuanLyKTXSVEntitiesFinal1();
        Dangnhap Dangnhap = new Dangnhap();
        int co = 0;
        
        void LoadData()
        {
            DGVPhong.Refresh();
            DGVPhong.DataSource = QLKTX.usp_DSPhong();

            cbxLP.DataSource = QLKTX.Loaiphongs.ToList();
            cbxLP.DisplayMember = "TenLP";
            cbxLP.ValueMember = "MaLP";
            txtMaphong.Enabled = true;
           


            panel1.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btThem.Enabled = true;
           
            btLuu.Enabled = false;
        }
        private void PhongKTX_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        
    
        private void DGVPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = DGVPhong.CurrentCell.RowIndex;
            this.txtMaphong.Text =
            DGVPhong.Rows[r].Cells[0].Value.ToString();
            this.txtToanha.Text =
            DGVPhong.Rows[r].Cells[1].Value.ToString();
            this.txtSodien.Text =
            DGVPhong.Rows[r].Cells[2].Value.ToString();
            this.txtSonuoc.Text =
            DGVPhong.Rows[r].Cells[3].Value.ToString();
            this.cbxLP.Text =
            DGVPhong.Rows[r].Cells[4].Value.ToString();
            btSua.Enabled = true;
            btXoa.Enabled = true;
           
        }

       

        private void btHuybo_Click(object sender, EventArgs e)
        {
            
            LoadData();
        }

       

        private void btThem_Click_1(object sender, EventArgs e)
        {
            if (Dangnhap.KTDN == true)
            {
                panel1.Enabled = true;
                btXoa.Enabled = false;
                btSua.Enabled = false;
                btLuu.Enabled = true;
                txtMaphong.ResetText();
                txtSodien.ResetText();
                txtToanha.ResetText();
                txtSonuoc.ResetText();

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

        private void btXoa_Click_1(object sender, EventArgs e)
        {
            if (Dangnhap.KTDN == true)
            {
                int a = Convert.ToInt32(txtMaphong.Text);
                QLKTX.ups_XoaPhong(a);
                txtMaphong.ResetText();
                txtSodien.ResetText();
                txtToanha.ResetText();
                txtSonuoc.ResetText();

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

        private void btSua_Click_1(object sender, EventArgs e)
        {
            if (Dangnhap.KTDN == true)
            {
                panel1.Enabled = true;
                txtMaphong.Enabled = false;
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

        private void btLuu_Click_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtMaphong.Text);
            int b = Convert.ToInt32(txtSodien.Text);
            int c = Convert.ToInt32(txtSonuoc.Text);
            int r = DGVPhong.CurrentCell.RowIndex;
            int d = Convert.ToInt32(DGVPhong.Rows[r].Cells[2].Value.ToString());
            int f = Convert.ToInt32(DGVPhong.Rows[r].Cells[3].Value.ToString());


            if (co == 1)
            {
                QLKTX.usp_TheuPhong(a, txtToanha.Text, b, c, cbxLP.SelectedValue.ToString());
                LoadData();
            }
            else if (co == 2)
            {

                btSua.Enabled = false;
                if (d != b || f != c || d != b && f != c)
                {
                    QLKTX.ups_XoaPhieuthutien(a);
                }
                QLKTX.ups_CapnhatPhong(a, txtToanha.Text, b, c, cbxLP.SelectedValue.ToString());
                LoadData();
            }
            co = 0;
        }

        private void btHuybo_Click_1(object sender, EventArgs e)
        {
            txtMaphong.ResetText();
            txtSodien.ResetText();
            txtToanha.ResetText();
            txtSonuoc.ResetText();

            LoadData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
