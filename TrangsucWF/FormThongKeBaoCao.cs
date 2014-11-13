using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrangsucWF.ServiceReferenceTonkho;
using TrangsucWF.ServiceReferenceSanpham;
using TrangsucWF.ServiceReferenceHoadon;
namespace TrangsucWF
{
    public partial class FormThongKeBaoCao : Form
    {
        ServiceHoadonClient dbhoadon = new ServiceHoadonClient();
        ServiceSanphamClient dbsanpham = new ServiceSanphamClient();
        ServiceTonkhoClient dbtonkho = new ServiceTonkhoClient();
        List<Tonkho_DTO> listtonkhotk = new List<Tonkho_DTO>();
        List<ServiceReferenceSanpham.Sanpham_DTO> listsp;
        List<ServiceReferenceSanpham.Loaisanpham_DTO> listloaisp;
        List<ServiceReferenceHoadon.Chitiethoadon_DTO> list_cthdtk = new List<ServiceReferenceHoadon.Chitiethoadon_DTO>();
        List<ServiceReferenceHoadon.Chitiethoadon_DTO> list_cthd_giao = new List<ServiceReferenceHoadon.Chitiethoadon_DTO>();
        public FormThongKeBaoCao()
        {
            InitializeComponent();
            listloaisp = dbsanpham.GetAllLoaiSp().ToList();
            cbb_loaisp.DataSource = listloaisp;
            cbb_loaisp.DisplayMember = "Tenloai";
            cbb_loaisp.ValueMember = "Maloai";
        }
        private void FormThongkeBaocao_Load(object sender, EventArgs e)
        {         
            dtpk_ngay.Value = DateTime.Now;
            timkiem();
            dt_tungaybc.Value = DateTime.Today.AddDays(-30);
            dt_denngaybc.Value = DateTime.Today;
            timkiembaocao();             
        }
        
        //Thống kê số lượng tồn kho       
        private void timkiem()
        {
            var listtonkho = dbtonkho.GetAllTonkho(cbb_loaisp.SelectedValue.ToString().Trim(), dtpk_ngay.Value);
            if (listtonkho == null)
            {
                gv_tonkho.AutoGenerateColumns = false;
                gv_tonkho.DataSource = null;
                MessageBox.Show(catma(cbb_masp.Text) + " chưa nhập hàng vào thời gian này!");
                listtonkhotk.Clear();
            }
            else
            {
                if (cbb_masp.Text.Contains("Tất cả"))
                {
                        listtonkhotk = listtonkho.ToList();                
                }
                else
                {
                        listtonkhotk = listtonkho.Where(s => s.Sptonkho.Masanpham.Contains(catma(cbb_masp.Text))).ToList();

                }
                gv_tonkho.AutoGenerateColumns = false;
                gv_tonkho.DataSource = listtonkhotk;
            }
        }
        private string catma(String masp)
        {
            string s = "";
            for (int i = 0; i < masp.Length; i++)
            {
                if (masp[i] != '-')
                    s += masp[i];
                else
                    break;
            }

            return s;
        }
        private void bt_thongke_Click(object sender, EventArgs e)
        {
            timkiem();
        }
        private void cbb_loaisp_SelectedChanged(object sender, EventArgs e)
        {
            listsp = dbsanpham.GetSpCungLoai(cbb_loaisp.SelectedValue.ToString()).ToList();
            cbb_masp.Items.Clear();
            cbb_masp.Items.Add("Tất cả");
            foreach (var item in listsp)
            {
                cbb_masp.Items.Add(item.Masanpham.Trim() + "---" + item.Tensanpham.Trim());
            }
            cbb_masp.SelectedItem = "Tất cả";
        }
        
        private void thoat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        //Báo cáo doanh thu theo ngày và loại sản phẩm hoặc theo sản phẩm
        private void timkiembaocao()
        {  
            list_cthd_giao.Clear();
            list_cthd_giao = dbhoadon.GetAllChitiet().Where(s => s.Hoadon.Trangthai.Trim().Contains("Đã giao")).ToList();
            int tongtien = 0;
            list_cthdtk.Clear();
            foreach (ServiceReferenceHoadon.Chitiethoadon_DTO cthd in list_cthd_giao)
            {
                if (cthd.Hoadon.Ngaygiaohang.Date >= dt_tungaybc.Value.Date && cthd.Hoadon.Ngaygiaohang.Date <= dt_denngaybc.Value.Date)
                { //THeo ngay
                    var check = list_cthdtk.FirstOrDefault(s => s.Masanpham.Contains(cthd.Masanpham));
                    if (check != null)
                    { //Theo san pham
                        tongtien = tongtien - int.Parse(check.Thanhtien);
                        check.Soluong = check.Soluong + cthd.Soluong;
                        check.Thanhtien = (check.Soluong * check.Giasanpham).ToString();
                        tongtien = tongtien  + int.Parse(check.Thanhtien);
                    }
                    else
                    {
                        list_cthdtk.Add(cthd);
                        tongtien += int.Parse(cthd.Thanhtien);
                    }
                }
            }
            
            gv_baocao.DataSource = null;
            gv_baocao.AutoGenerateColumns = false;
            gv_baocao.DataSource = list_cthdtk;
            string tien = tongtien.ToString("c");
            lb_tien.Text = tien.Substring(1, tien.LastIndexOf(".") - 1);
            
        }        
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }   
        private void btn_xembaocao_Click(object sender, EventArgs e)
        {
            timkiembaocao();
        }
        
        private void btn_InbaoCao_Click(object sender, EventArgs e)
        {
            FormBCDoanhthu frm = new FormBCDoanhthu(dt_tungaybc.Value.ToString("dd/MM/yyyy"), dt_denngaybc.Value.ToString("dd/MM/yyyy"), lb_tien.Text, list_cthdtk);
            frm.Show();
        }
        private void Inthongke_Click(object sender, EventArgs e)
        {
            FormBCTonKho frm = new FormBCTonKho(listtonkhotk, dtpk_ngay.Value.ToString("dd/MM/yyyy"), cbb_loaisp.Text,cbb_masp.Text);
            frm.Show();
        }
    }
}
