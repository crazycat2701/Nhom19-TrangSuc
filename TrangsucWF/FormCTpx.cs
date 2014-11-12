using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TrangsucWF.ServiceReferencePhieuxuat;
using TrangsucWF.ServiceReferenceSanpham;
namespace TrangsucWF
{
    public partial class FormCTpx : Form
    {
        ServiceReferenceTonkho.ServiceTonkhoClient dbtonkho = new ServiceReferenceTonkho.ServiceTonkhoClient();
        public delegate void DelegateA();
        public DelegateA Sender;
        Phieuxuat_DTO px = new Phieuxuat_DTO();
        List<ServiceReferenceSanpham.Sanpham_DTO> listsp;
        List<ServiceReferenceSanpham.Sanpham_DTO> listsptk = new List<ServiceReferenceSanpham.Sanpham_DTO>();
        ServiceSanphamClient dbsanpham = new ServiceSanphamClient();
        ServicePhieuxuatClient dbphieuxuat = new ServicePhieuxuatClient();
        List<Chitietphieuxuat_DTO> listctpx = new List<Chitietphieuxuat_DTO>();
        List<Chitietphieuxuat_DTO> listctpxxoa = new List<Chitietphieuxuat_DTO>();
        public FormCTpx()
        {
            InitializeComponent();
            listsp = dbsanpham.GetAllSp().ToList();
            gv_sanpham.AutoGenerateColumns = false;
            gv_sanpham.DataSource = listsp;
        }

         public FormCTpx(Phieuxuat_DTO phieuxuat)
            : this()
        {

            lb_maphieuxuat.Text = phieuxuat.Maphieuxuat.Trim();
            px = phieuxuat;
            if (px.Tongtien > 0)
            {    
                listctpx = dbphieuxuat.GetChitietByMa(px.Maphieuxuat).ToList();
                gv_phieuxuat.AutoGenerateColumns = false;
                gv_phieuxuat.DataSource = listctpx;
            }
            if (px.Trangthai.Contains("Đã nhập hàng"))
            {
                btn_save.Dispose();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (!px.Trangthai.Contains("Đã nhập hàng"))
            {
                if (MessageBox.Show("Lưu sản phẩm chưa mà thoát đó?", "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else this.Close();
        }
        public void timkiem()
        {
            listsptk.Clear();

            foreach (ServiceReferenceSanpham.Sanpham_DTO sp in listsp)
            {
                String nametolower = sp.Tensanpham.ToLower().Trim();
                String masptolower = sp.Masanpham.ToLower().Trim();
                if (nametolower.Contains(txt_find.Text.ToLower()) || masptolower.Contains(txt_find.Text.ToLower()))
                {
                    listsptk.Add(sp);
                }
            }
            gv_sanpham.DataSource = null;
            gv_sanpham.DataSource = listsptk;
        }

        private void txt_find_TextChanged(object sender, EventArgs e)
        {
            timkiem();
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!px.Trangthai.Contains("Đã xuất hàng"))
            {
                if (IsNumber(txt_soluong.Text) && int.Parse(txt_soluong.Text) > 0)
                {
                    if (dbsanpham.Find(txt_masanpham.Text)!=null)
                    {
                        if (int.Parse(txt_soluong.Text) > 0 && int.Parse(txt_soluong.Text) <= dbtonkho.Find(txt_masanpham.Text).Soluong)
                        {
                            Chitietphieuxuat_DTO check = listctpx.FirstOrDefault(s => s.Sanpham.Masanpham.Trim().ToLower().Contains(txt_masanpham.Text.Trim().ToLower()));
                            if (check == null)
                            {
                                var sp = listsp.FirstOrDefault(s => s.Masanpham.Trim().Contains(txt_masanpham.Text.Trim()));
                                Chitietphieuxuat_DTO ctpx = new Chitietphieuxuat_DTO();
                                ctpx.ID = 2;
                                ctpx.Phieuxuat = px;
                                ctpx.Sanpham = new ServiceReferencePhieuxuat.Sanpham_DTO
                                {
                                    Masanpham = sp.Masanpham,
                                    Tensanpham = sp.Tensanpham,
                                    Chatlieu = sp.Chatlieu,
                                    Giasanpham = sp.Giasanpham,
                                    Hinhanh = sp.Hinhanh,
                                    Sanphammoi = sp.Sanphammoi,
                                    Loai = new ServiceReferencePhieuxuat.Loaisanpham_DTO
                                    {
                                        Maloai = sp.Loai.Maloai,
                                        Tenloai = sp.Loai.Tenloai
                                    }
                                };
                                ctpx.Soluong = int.Parse(txt_soluong.Text);
                                ctpx.Thanhtien = ctpx.Sanpham.Giasanpham * ctpx.Soluong;
                                ctpx.Masanpham = sp.Masanpham;
                                listctpx.Add(ctpx);
                                txt_masanpham.Text = "";
                                txt_soluong.Text = "";
                            }
                            else
                            {
                                if (check.ID == 2)
                                {
                                    check.Soluong = int.Parse(txt_soluong.Text); txt_masanpham.Text = ""; txt_soluong.Text = "";
                                }
                                else
                                {
                                    check.ID = 1; check.Soluong = int.Parse(txt_soluong.Text); txt_masanpham.Text = ""; txt_soluong.Text = "";
                                }
                            }
                            gv_phieuxuat.DataSource = null; ;
                            gv_phieuxuat.AutoGenerateColumns = false;
                            gv_phieuxuat.DataSource = listctpx;
                        }
                        else
                        {
                            MessageBox.Show("Kho không đủ số lượng");
                            txt_soluong.Text = "";
                        }
                    }
                    else MessageBox.Show("Mã sản phẩm không hợp lệ");
                }
                else MessageBox.Show("Số lượng không hợp lệ");
            }
            else
                MessageBox.Show("Phiếu xuất này không thể chỉnh sửa!");
        }

        private void gv_phieuxuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gv_phieuxuat.Columns["delete"].Index && listctpx.Count > 0)
            {
                if (!px.Trangthai.Contains("Đã xuất hàng"))
                {
                    Chitietphieuxuat_DTO ctpx = listctpx[e.RowIndex];
                    if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa " + ctpx.Sanpham.Masanpham + "?", "Hỏi", MessageBoxButtons.YesNo))
                    {
                        listctpx.Remove(ctpx);
                        gv_phieuxuat.DataSource = null;
                        gv_phieuxuat.AutoGenerateColumns = false;
                        gv_phieuxuat.DataSource = listctpx;
                        listctpxxoa.Add(ctpx);
                    }
                }
                else MessageBox.Show("Phiếu xuất này không thể chỉnh sửa!");

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!px.Trangthai.Contains("Đã xuất hàng"))
            {
                px.Tongtien = 0;
                foreach (var item in listctpx)
                {
                    if (item.ID == 2)
                    {
                        dbphieuxuat.InsertChitiet(item);
                    }
                    else if (item.ID == 1)
                    { dbphieuxuat.UpdateChitiet(item); }

                    px.Tongtien = (px.Tongtien + item.Thanhtien);
                }
                foreach (var item in listctpxxoa)
                {
                    dbphieuxuat.DeleteChitiet(item);
                }
                MessageBox.Show("Lưu thành công");
                if (Sender != null)
                {
                    Sender();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Phiếu xuất này không thể chỉnh sửa!");
            }
        }

        private void gv_phieuxuat_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_phieuxuat.SelectedRows.Count > 0 && listctpx.Count > 0)
            {
                Chitietphieuxuat_DTO ctpx = (Chitietphieuxuat_DTO)gv_phieuxuat.SelectedRows[0].DataBoundItem;
                txt_masanpham.Text = ctpx.Sanpham.Masanpham.Trim();
                txt_soluong.Text = ctpx.Soluong.ToString();
                lb_tonkho.Text = dbtonkho.Find(txt_masanpham.Text).Soluong.ToString();
            }
        }

        private void gv_sanpham_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_sanpham.SelectedRows.Count > 0)
            {
                ServiceReferenceSanpham.Sanpham_DTO sp = (ServiceReferenceSanpham.Sanpham_DTO)gv_sanpham.SelectedRows[0].DataBoundItem;
                txt_masanpham.Text = sp.Masanpham;
                lb_tonkho.Text = dbtonkho.Find(txt_masanpham.Text).Soluong.ToString();
            }
        }
    }
}
