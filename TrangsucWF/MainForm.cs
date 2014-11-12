using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrangsucWF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_QLNH_Click(object sender, EventArgs e)
        {
            FormQLPhieuNhap qlpn = new FormQLPhieuNhap();
            qlpn.Show();
        }

        private void btn_QLdonhang_Click(object sender, EventArgs e)
        {
            FormQLDH qldh = new FormQLDH();
            qldh.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btn_thongkebaocao_Click(object sender, EventArgs e)
        {
            FormThongKeBaoCao tkbc = new FormThongKeBaoCao();
            tkbc.Show();
        }

        private void btn_qlsp_Click(object sender, EventArgs e)
        {
            FormQLSP qlsp = new FormQLSP();
            qlsp.Show();
        }

        private void btnqlpx_Click(object sender, EventArgs e)
        {
            FormQLPX qlpx = new FormQLPX();
            qlpx.Show();
        }
    }
}
