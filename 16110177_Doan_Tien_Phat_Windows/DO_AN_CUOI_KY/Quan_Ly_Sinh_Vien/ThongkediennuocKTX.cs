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
    public partial class ThongkediennuocKTX : Form
    {
        public ThongkediennuocKTX()
        {
            InitializeComponent();
        }
        QuanLyKTXSVEntitiesFinal1 QLKTX = new QuanLyKTXSVEntitiesFinal1();
        private void ThongkediennuocKTX_Load(object sender, EventArgs e)
        {
           
            var list = QLKTX.usp_Thongkediennuoc();
            DGVthongkedien1T.DataSource = list;
            int r = DGVthongkedien1T.CurrentCell.RowIndex;
            this.lbsonuoc1T.Text =
            DGVthongkedien1T.Rows[r].Cells[0].Value.ToString();
            this.lbTiennuoc1T.Text =
            DGVthongkedien1T.Rows[r].Cells[1].Value.ToString();
            this.lbsodien1T.Text =
            DGVthongkedien1T.Rows[r].Cells[2].Value.ToString();
            this.lbTiendien1T.Text =
            DGVthongkedien1T.Rows[r].Cells[3].Value.ToString();
            this.lbTongtien1T.Text =
            DGVthongkedien1T.Rows[r].Cells[4].Value.ToString();
        }
    }
}
