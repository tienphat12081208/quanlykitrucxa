
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
    public partial class Dangnhap : Form
    {
        public static bool KTDN=false;
        public static bool KTAD = false;
        public Dangnhap()
        {
            InitializeComponent();
        }
        QuanLyKTXSVEntitiesFinal1 QLKTX = new  QuanLyKTXSVEntitiesFinal1();
        Taikhoan TK = new Taikhoan();
        private void Dangnhap_Load(object sender, EventArgs e)
        {
            Trangchu trangchu = new Trangchu();
          
          
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                var list = QLKTX.usp_KTDN_TK(txtTendangnhap.Text, txtMatkhau.Text);
                DGVTK.DataSource = list;
                int r = DGVTK.CurrentCell.RowIndex;
                string d = DGVTK.Rows[r].Cells[0].Value.ToString();
                if (d != "")
                {
                    MessageBox.Show(" Đăng nhập thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    KTDN = true;
                    if(txtTendangnhap.Text=="admin")
                    {
                        KTAD = true;
                    }
                    txtTendangnhap.ResetText();
                    txtMatkhau.ResetText();
                    this.Hide();
                    
                }
                
               
            }catch(Exception)
            {
                MessageBox.Show("Bạn vui lòng kiểm trả lại tài khoản và mật khẩu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }


            
            
        }

        
    }
}
