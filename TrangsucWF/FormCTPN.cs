using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TrangsucWF.ServiceReferencePhieunhap;
using TrangsucWF.ServiceReferenceSanpham;
namespace TrangsucWF
{
    public partial class FormCTPN : Form
    {
        public delegate void DelegateA();
        public DelegateA Sender;
        Phieunhap_DTO pn = new Phieunhap_DTO();
        List<ServiceReferenceSanpham.Sanpham_DTO> listsp;
        List<ServiceReferenceSanpham.Sanpham_DTO> listsptk = new List<ServiceReferenceSanpham.Sanpham_DTO>();
        ServiceSanphamClient dbsanpham = new ServiceSanphamClient();
        ServicePhieunhapClient dbphieunhap = new ServicePhieunhapClient();
        List<Chitietphieunhap_DTO> listctpn = new List<Chitietphieunhap_DTO>();
        List<Chitietphieunhap_DTO> listctpnxoa = new List<Chitietphieunhap_DTO>();
        public FormCTPN()
        {
            InitializeComponent();
            listsp = dbsanpham.GetAllSp().ToList();
            gv_sanpham.AutoGenerateColumns = false;
            gv_sanpham.DataSource = listsp;
        }
        public FormCTPN(Phieunhap_DTO phieunhap)
            : this()
        {

            lb_maphieunhap.Text = phieunhap.Maphieunhap.Trim();
            pn = phieunhap;
            if (pn.Tongtien > 0)
            {    
                listctpn = dbphieunhap.GetChitietByMa(pn.Maphieunhap).ToList();
                gv_phieunhap.AutoGenerateColumns = false;
                gv_phieunhap.DataSource = listctpn;
            }
            if (pn.Trangthai.Contains("Đã nhập hàng"))
            {
                btn_save.Dispose();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (!pn.Trangthai.Contains("Đã nhập hàng"))
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
            if (!pn.Trangthai.Contains("Đã nhập hàng"))
            {
                if (IsNumber(txt_soluong.Text) && int.Parse(txt_soluong.Text) > 0)
                {
                    if (listsp.Where(s => s.Masanpham.Trim().ToLower().Contains(txt_masanpham.Text.Trim().ToLower())).ToList().Count > 0)
                    {
                        //kiểm tra sản phẩm có trong danh sách chi tiết hóa đon không
                        Chitietphieunhap_DTO check = listctpn.FirstOrDefault(s => s.Sanpham.Masanpham.Trim().ToLower().Contains(txt_masanpham.Text.Trim().ToLower()));
                        
                        if (check == null)
                        {
                            //Nếu không có thì thêm sản phẩm vào danh sách chi tiết
                            var sp = listsp.FirstOrDefault(s => s.Masanpham.Trim().Contains(txt_masanpham.Text.Trim()));
                            Chitietphieunhap_DTO ctpn = new Chitietphieunhap_DTO();
                            //Id = 2 là trạng thái sản phẩm mới được thêm vào
                            ctpn.ID = 2;
                            ctpn.Phieunhap = pn;
                            ctpn.Sanpham = new ServiceReferencePhieunhap.Sanpham_DTO
                            {
                                Masanpham = sp.Masanpham,
                                Tensanpham = sp.Tensanpham,
                                Chatlieu = sp.Chatlieu,
                                Giasanpham = sp.Giasanpham,
                                Hinhanh = sp.Hinhanh,
                                Sanphammoi = sp.Sanphammoi,
                                Loai = new ServiceReferencePhieunhap.Loaisanpham_DTO {Maloai = sp.Loai.Maloai,
                                                                                        Tenloai = sp.Loai.Tenloai }
                            };
                            ctpn.Soluong = int.Parse(txt_soluong.Text);
                            ctpn.Thanhtien = ctpn.Sanpham.Giasanpham * ctpn.Soluong;
                            ctpn.Masanpham = sp.Masanpham;
                            listctpn.Add(ctpn);
                            txt_masanpham.Text = "";
                            txt_soluong.Text = "";
                        }
                        else
                        {
                            //nếu có sản phẩm trong danh sach thì sản phẩm nếu là sản phẩm mới thì được chình sửa số lượng
                            if (check.ID == 2)
                            {
                                check.Soluong = int.Parse(txt_soluong.Text); txt_masanpham.Text = ""; txt_soluong.Text = "";
                            }
                            else
                            {//nếu không là sản phẩm mới thì sửa trạng thái ID =1 (trang thái sản phẩm được sửa) , sửa số lượng
                                check.ID = 1; check.Soluong = int.Parse(txt_soluong.Text); txt_masanpham.Text = ""; txt_soluong.Text = "";
                            }
                        }
                        gv_phieunhap.DataSource = null; ;
                        gv_phieunhap.AutoGenerateColumns = false;
                        gv_phieunhap.DataSource = listctpn;
                    }
                    else MessageBox.Show("Mã sản phẩm không hợp lệ");
                }
                else MessageBox.Show("Số lượng không hợp lệ");
            }
            else
                MessageBox.Show("Phiếu nhập không thể chỉnh sửa!");
        }

        private void gv_phieunhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gv_phieunhap.Columns["delete"].Index && listctpn.Count > 0)
            {
                if (!pn.Trangthai.Contains("Đã nhập hàng"))
                {
                    Chitietphieunhap_DTO ctpn = listctpn[e.RowIndex];
                    if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa " + ctpn.Sanpham.Masanpham + "?", "Hỏi", MessageBoxButtons.YesNo))
                    {
                        listctpn.Remove(ctpn);
                        gv_phieunhap.DataSource = null;
                        gv_phieunhap.AutoGenerateColumns = false;
                        gv_phieunhap.DataSource = listctpn;
                        listctpnxoa.Add(ctpn);
                    }
                }
                else MessageBox.Show("Phiếu nhập không thể chỉnh sửa!");

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!pn.Trangthai.Contains("Đã nhập hàng"))
            {
                pn.Tongtien = 0;
                foreach (var item in listctpn)
                {
                    if (item.ID == 2)
                    {
                        dbphieunhap.InsertChitiet(item);
                    }
                    else if (item.ID == 1)
                    { dbphieunhap.UpdateChitiet(item); }

                    pn.Tongtien = (pn.Tongtien + item.Thanhtien);
                }
                foreach (var item in listctpnxoa)
                {
                    dbphieunhap.DeleteChitiet(item);
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
                MessageBox.Show("Phiếu nhập không thể chỉnh sửa!");
            }
        }

        private void gv_phieunhap_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_phieunhap.SelectedRows.Count > 0 && listctpn.Count > 0)
            {
                Chitietphieunhap_DTO ctpn = (Chitietphieunhap_DTO)gv_phieunhap.SelectedRows[0].DataBoundItem;
                txt_masanpham.Text = ctpn.Sanpham.Masanpham.Trim();
                txt_soluong.Text = ctpn.Soluong.ToString();
            }
        }

        private void gv_sanpham_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_sanpham.SelectedRows.Count > 0)
            {
                ServiceReferenceSanpham.Sanpham_DTO sp = (ServiceReferenceSanpham.Sanpham_DTO)gv_sanpham.SelectedRows[0].DataBoundItem;
                txt_masanpham.Text = sp.Masanpham;
            }
        }
    }
}
