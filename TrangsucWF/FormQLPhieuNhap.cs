using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrangsucWF.ServiceReferencePhieunhap;
namespace TrangsucWF
{
    public partial class FormQLPhieuNhap : Form
    {
        List<Phieunhap_DTO> listpn;
        List<Phieunhap_DTO> listtkpn = new List<Phieunhap_DTO>();
       ServiceReferenceTonkho.ServiceTonkhoClient dbtonkho = new ServiceReferenceTonkho.ServiceTonkhoClient();
        ServicePhieunhapClient dbphieunhap = new ServicePhieunhapClient();
        public FormQLPhieuNhap()
        {
            InitializeComponent();
            lb_maphieunhap.Text = "";
        }
        private void FormQLPhieuNhap_Load(object sender, EventArgs e)
        {          
            List<string> trangthai = new List<string>();
            trangthai.Add("Mới lập");
            trangthai.Add("Đã nhập hàng");
            List<string> trangthai1 = new List<string>();
            trangthai1.Add("Tất cả");
            trangthai1.Add("Mới lập");
            trangthai1.Add("Đã nhập hàng");

            cbb_trangthai.DataSource = trangthai;
            cbb_trangthai1.DataSource = trangthai1;
            listpn = dbphieunhap.GetAllPhieunhap().ToList();
            dtpk_tu.Value = DateTime.Today.AddDays(-30);
            timkiem();

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timkiem()
        {
            listtkpn.Clear();
            foreach (Phieunhap_DTO pn in listpn)
            {
                if (cbb_trangthai1.Text.Contains("Tất cả") && pn.Ngaylapphieu.Date >= dtpk_tu.Value.Date && pn.Ngaylapphieu.Date <= dtpk_den.Value.Date)
                {
                    listtkpn.Add(pn);
                }
                else
                {
                    if (pn.Trangthai.Contains(cbb_trangthai1.Text) && pn.Ngaylapphieu.Date >= dtpk_tu.Value.Date && pn.Ngaylapphieu.Date <= dtpk_den.Value.Date)
                    {
                        listtkpn.Add(pn);
                    }
                }
            }
            gv_phieunhap.DataSource = null;
            gv_phieunhap.AutoGenerateColumns = false;
            gv_phieunhap.DataSource = listtkpn;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            timkiem();
        }

        private void gv_phieunhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gv_phieunhap.Columns["updatedetail"].Index)
            {
                if (listtkpn.Count != 0)
                {
                    Phieunhap_DTO pn = listtkpn[e.RowIndex];
                    FormCTPN ctpn = new FormCTPN(pn);
                    ctpn.Sender = new FormCTPN.DelegateA(Get);
                    ctpn.ShowDialog();
                    
                }
                
            }
        }
        private void Get()
        {
            gv_phieunhap.DataSource = null;
            listpn = dbphieunhap.GetAllPhieunhap().ToList();
            timkiem();
        }
        private void bt_add_Click(object sender, EventArgs e)
        {
                if (txt_nguoilap.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên người lập phiếu!");
                }
                else
                {

                    Phieunhap_DTO pn = new Phieunhap_DTO();
                    pn.Maphieunhap = "PN"+(dbphieunhap.GetAllPhieunhap().Count() + 1);
                    pn.Tennguoilap = txt_nguoilap.Text;
                    pn.Ngaylapphieu = DateTime.Now.Date;
                    pn.Trangthai = "Mới lập";
                    dbphieunhap.InsertPhieunhap(pn);
                    listpn.Add(pn);
                    timkiem();
                    lb_maphieunhap.Text = "";
                    MessageBox.Show("Đã thêm phiếu nhập!");
                   
                }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            bool check = true;
            Phieunhap_DTO pn = dbphieunhap.GetPhieunhapByMa(lb_maphieunhap.Text);
           
                if (pn.Trangthai.Contains("Đã nhập hàng"))
                {
                    MessageBox.Show("Phiếu nhập này không thể sửa!");
                    lb_maphieunhap.Text = "";
                    txt_nguoilap.Text = "";
                    dtpk_ngaylap.Value = DateTime.Now;
                    cbb_trangthai.SelectedItem = "Mới lập";
                }
                else
                {
                    if (!String.IsNullOrEmpty(txt_nguoilap.Text))
                    {
                        if (dtpk_ngaylap.Value.Date >= pn.Ngaylapphieu.Date && dtpk_ngaylap.Value.Date <= DateTime.Now)
                        {
                            if (cbb_trangthai.Text == "Đã nhập hàng" && pn.Tongtien == 0)
                            {
                                MessageBox.Show("Phiếu nhập chưa được phép đổi trạng thái!");
                                lb_maphieunhap.Text = "";
                                txt_nguoilap.Text = "";
                                dtpk_ngaylap.Value = DateTime.Now;
                                cbb_trangthai.SelectedItem = "Mới lập";
                            }
                            else
                            {
                                pn.Tennguoilap = txt_nguoilap.Text;
                                pn.Ngaylapphieu = dtpk_ngaylap.Value.Date;
                                pn.Trangthai = cbb_trangthai.Text;
                                dbphieunhap.UpdatePhieunhap(pn);
                                if (pn.Trangthai.Contains("Đã nhập hàng"))
                                {
                                    List<Chitietphieunhap_DTO> listctpn = new List<Chitietphieunhap_DTO>();
                                    listctpn = dbphieunhap.GetChitietByMa(pn.Maphieunhap).ToList();

                                    foreach (Chitietphieunhap_DTO item in listctpn)
                                    {
                                        ServiceReferenceTonkho.Chitietphieunhap_DTO tk = new ServiceReferenceTonkho.Chitietphieunhap_DTO();
                                        tk.Masanpham = item.Masanpham;
                                        tk.Soluong = item.Soluong;
                                        if (dbtonkho.NhapKho(tk))
                                        {
                                        }
                                        else
                                        {
                                            MessageBox.Show("Nhap kho that bai");
                                            check = false;
                                        }
                                    }
                                    if (check == false)
                                    {
                                        pn.Trangthai = "Mới lập";
                                        dbphieunhap.UpdatePhieunhap(pn);
                                    }
                                }
                                var s = listpn.SingleOrDefault(x => x.Maphieunhap.Equals(pn.Maphieunhap));
                                s.Tennguoilap = pn.Tennguoilap;
                                s.Ngaylapphieu = pn.Ngaylapphieu;
                                s.Trangthai = pn.Trangthai;
                                timkiem();
                                lb_maphieunhap.Text = "";
                                txt_nguoilap.Text = "";
                                dtpk_ngaylap.Value = DateTime.Now;
                                cbb_trangthai.SelectedItem = "Mới lập";
                                MessageBox.Show("Đã cập nhật phiếu nhập!");
                            }
                        }
                        else
                        {
                            lb_maphieunhap.Text = "";
                            txt_nguoilap.Text = "";
                            dtpk_ngaylap.Value = DateTime.Now;
                            cbb_trangthai.SelectedItem = "Mới lập";
                            MessageBox.Show("Ngày lập không hợp lệ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập tên người lập!");
                    }
                }
        }

        private void gv_phieunhap_SelectionChanged(object sender, EventArgs e)
        {
           if (gv_phieunhap.SelectedRows.Count > 0)
            {
                Phieunhap_DTO pn = (Phieunhap_DTO)gv_phieunhap.SelectedRows[0].DataBoundItem;
                lb_maphieunhap.Text = pn.Maphieunhap.Trim();
                txt_nguoilap.Text = pn.Tennguoilap;
                dtpk_ngaylap.Value = pn.Ngaylapphieu.Date;
                cbb_trangthai.SelectedItem = pn.Trangthai;
            }
        }
    }
}
