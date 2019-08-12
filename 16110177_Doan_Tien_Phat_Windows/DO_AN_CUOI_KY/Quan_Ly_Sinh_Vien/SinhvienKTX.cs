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
    public partial class SinhvienKTX : Form
    {
        public SinhvienKTX()
        {
            InitializeComponent();
            cbxGioitinh.Items.Add("Nam");
            cbxGioitinh.Items.Add("Nữ");
        }
        QuanLyKTXSVEntitiesFinal1 QLKTX = new QuanLyKTXSVEntitiesFinal1();
        int co = 0;
        Dangnhap Dangnhap = new Dangnhap();
        void LoadData()
        {
            DGVSinhvien.DataSource = QLKTX.usp_DanhsachSV();

            cbxMaphong.DataSource = QLKTX.Phongs.ToList();
            cbxMaphong.DisplayMember = "Maphong";
            cbxMaphong.ValueMember = "Maphong";

            cbxNoisinh.DataSource = QLKTX.Thanhphoes.ToList();
            cbxNoisinh.DisplayMember = "TenTP";
            cbxNoisinh.ValueMember = "MaTP";

            cbxTruonghoc.DataSource = QLKTX.Truongs.ToList();
            cbxTruonghoc.DisplayMember = "Tentruong";
            cbxTruonghoc.ValueMember = "Matruong";

            

            txtMSSV.Enabled = true;
            txtHoten.ResetText();
            txtMSSV.ResetText();
            txtSoDT.ResetText();



            panel1.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btThem.Enabled = true;
            btLuu.Enabled = false;

        }

        private void SinhvienKTX_Load(object sender, EventArgs e)
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
                txtHoten.ResetText();
                txtMSSV.ResetText();
                txtSoDT.ResetText();
                co = 1;
            }
            else
            {
                if (Dangnhap.KTDN == false)
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
        bool EX = false;
        private void btLuu_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtMSSV.Text);
            int b = Convert.ToInt32(cbxNoisinh.SelectedValue.ToString());
            int c = Convert.ToInt32(cbxMaphong.SelectedValue.ToString());
            
            Sinhvien sinhvien = new Sinhvien();
            try
            {
                if (co == 1)
                {
                    QLKTX.usp_ThemSV(a, txtHoten.Text, cbxGioitinh.SelectedText.ToString(), cbxTruonghoc.SelectedValue.ToString(), Convert.ToDateTime(DateTimeNS.Value.ToString()), txtSoDT.Text, b, c);
                    LoadData();
                }
                else if (co == 2)
                {
                    btSua.Enabled = false;
                    QLKTX.ups_CapnhatSV(a, txtHoten.Text, cbxGioitinh.SelectedItem.ToString(), cbxTruonghoc.SelectedValue.ToString(), Convert.ToDateTime(DateTimeNS.Value.ToString()), txtSoDT.Text, b, c);
                    LoadData();
                }

             }
                 catch(Exception)
                     {
                            MessageBox.Show("  Phòng không còn chỗ!!\n Bạn vui lòng chọn phòng khác!! \n  Cảm ơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            EX = true;
                     }
           if(EX==true)
            {
                co = 1;
                EX = false;
            }else
            {
                co = 0;
               
            }

        }

        private void DGVSinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMSSV.DataBindings.Clear();
            txtMSSV.DataBindings.Add("Text", DGVSinhvien.DataSource, "MSSV");
            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("Text", DGVSinhvien.DataSource, "Hoten");
            DateTimeNS.DataBindings.Clear();
            DateTimeNS.DataBindings.Add("Value", DGVSinhvien.DataSource, "Ngaysinh");
            cbxTruonghoc.DataBindings.Clear();
            cbxTruonghoc.DataBindings.Add("Text", DGVSinhvien.DataSource, "Tentruong");
            cbxNoisinh.DataBindings.Clear();
            cbxNoisinh.DataBindings.Add("Text", DGVSinhvien.DataSource, "TenTP");
            cbxMaphong.DataBindings.Clear();
            cbxMaphong.DataBindings.Add("Text", DGVSinhvien.DataSource, "Maphong");
            txtSoDT.DataBindings.Clear();
            txtSoDT.DataBindings.Add("Text", DGVSinhvien.DataSource, "SoDT");
            cbxGioitinh.DataBindings.Clear();
            cbxGioitinh.DataBindings.Add("Text", DGVSinhvien.DataSource, "Gioitinh");

            btSua.Enabled = true;
            btXoa.Enabled = true;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (Dangnhap.KTDN == true)
            {
                panel1.Enabled = true;
            txtMSSV.Enabled = false;
            btThem.Enabled = false;
            btXoa.Enabled = false;
            btLuu.Enabled = true;
            co = 2;
            }
            else
            {
                if (Dangnhap.KTDN == false)
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

        private void btHuybo_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
        if (Dangnhap.KTDN == true)
        {
                int a = Convert.ToInt32(txtMSSV.Text);
            QLKTX.ups_XoaSV(a);
            txtHoten.ResetText();
            txtMSSV.ResetText();
            txtSoDT.ResetText();
            LoadData();
        }
            else
            {
                if (Dangnhap.KTDN == false)
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

        private void DGVSinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
