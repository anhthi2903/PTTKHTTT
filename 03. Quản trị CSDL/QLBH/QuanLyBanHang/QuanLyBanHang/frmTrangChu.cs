using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap nhaCungCap = new frmNhaCungCap();
            nhaCungCap.MdiParent = this;
            nhaCungCap.Show();
        }

        private void đơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmDonBanHang donBanHang = new frmDonBanHang();
            donBanHang.MdiParent = this;
            donBanHang.Show();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 khachHang = new Form1();
            khachHang.MdiParent = this;
            khachHang.Show();
        }

    }
}
