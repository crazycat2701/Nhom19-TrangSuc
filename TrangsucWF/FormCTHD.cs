using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrangsucWF.ServiceReferenceHoadon;
namespace TrangsucWF
{
    public partial class FormCTHD : Form
    {
        List<Chitiethoadon_DTO> listcthd;
        public FormCTHD(List<Chitiethoadon_DTO> _listcthd)
        {
            InitializeComponent();
            listcthd = _listcthd;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormCTHD_Load(object sender, EventArgs e)
        {
            gv_ctsp.AutoGenerateColumns = false;
            gv_ctsp.DataSource = listcthd;
            var hd = listcthd.FirstOrDefault();
            lb_mahoadon.Text = hd.Hoadon.Mahoadon.ToString();
            lb_trangthai.Text = hd.Hoadon.Trangthai;
            lb_tendangnhap.Text = hd.Hoadon.Nguoidung.Username;
            lb_ngaymuahang.Text = hd.Hoadon.Ngaymuahang.ToShortDateString();
            lb_sdt.Text = hd.Hoadon.Sdt;
            lb_diadiemgiaohang.Text = hd.Hoadon.Diadiemgiaohang;
            lb_ngaygiao.Text = hd.Hoadon.Ngaygiaohang.ToShortDateString();          
            lb_tongtien.Text = hd.Hoadon.Tongtien.ToString();
        }
    }
}
