using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrangsucWF.ServiceReferencePhieuxuat;
namespace TrangsucWF
{
    public partial class FormQLPX : Form
    {
        List<Phieuxuat_DTO> listpx;
        List<Phieuxuat_DTO> listtkpx = new List<Phieuxuat_DTO>();
        ServiceReferenceTonkho.ServiceTonkhoClient dbtonkho = new ServiceReferenceTonkho.ServiceTonkhoClient();
        ServicePhieuxuatClient dbphieuxuat = new ServicePhieuxuatClient();
        public FormQLPX()
        {
            InitializeComponent();
            lb_maphieuxuat.Text = "";
        }

        private void FormQLPX_Load(object sender, EventArgs e)
        {
            List<string> trangthai = new List<string>();
            trangthai.Add("Mới lập");
            trangthai.Add("Đã xuất hàng");
            List<string> trangthai1 = new List<string>();
            trangthai1.Add("Tất cả");
            trangthai1.Add("Mới lập");
            trangthai1.Add("Đã xuất hàng");

            cbb_trangthai.DataSource = trangthai;
            cbb_trangthai1.DataSource = trangthai1;
            listpx = dbphieuxuat.GetAllphieuxuat().ToList();
            dtpk_tu.Value = DateTime.Today.AddDays(-30);
            timkiem();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timkiem()
        {
            listtkpx.Clear();
            foreach (Phieuxuat_DTO px in listpx)
            {
                if (cbb_trangthai1.Text.Contains("Tất cả") && px.Ngaylapphieu.Date >= dtpk_tu.Value.Date && px.Ngaylapphieu.Date <= dtpk_den.Value.Date)
                {
                    listtkpx.Add(px);
                }
                else
                {
                    if (px.Trangthai.Contains(cbb_trangthai1.Text) && px.Ngaylapphieu.Date >= dtpk_tu.Value.Date && px.Ngaylapphieu.Date <= dtpk_den.Value.Date)
                    {
                        listtkpx.Add(px);
                    }
                }
            }
            gv_phieuxuat.DataSource = null;
            gv_phieuxuat.AutoGenerateColumns = false;
            gv_phieuxuat.DataSource = listtkpx;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            timkiem();
        }

        private void gv_phieuxuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gv_phieuxuat.Columns["updatedetail"].Index)
            {
                if (listtkpx.Count != 0)
                {
                    Phieuxuat_DTO px = listtkpx[e.RowIndex];
                    FormCTpx ctpx = new FormCTpx(px);
                    ctpx.Sender = new FormCTpx.DelegateA(Get);
                    ctpx.ShowDialog();

                }

            }
        }
        private void Get()
        {
            gv_phieuxuat.DataSource = null;
            listpx = dbphieuxuat.GetAllphieuxuat().ToList();
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
                    Phieuxuat_DTO px = new Phieuxuat_DTO();
                    //tự sinh mã phiếu xuất
                    px.Maphieuxuat = "PX" + (dbphieuxuat.GetAllphieuxuat().Count() + 1);
                    px.Tennguoilap = txt_nguoilap.Text;
                    px.Ngaylapphieu = DateTime.Now;
                    px.Trangthai = "Mới lập";
                    dbphieuxuat.Insertphieuxuat(px);
                    listpx.Add(px);
                    timkiem();
                    lb_maphieuxuat.Text = "";
                    MessageBox.Show("Đã thêm phiếu xuất!");
                }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            bool check = true;
            Phieuxuat_DTO px = dbphieuxuat.GetphieuxuatByMa(lb_maphieuxuat.Text);       
                if (px.Trangthai.Contains("Đã xuất hàng"))
                {
                    MessageBox.Show("Phiếu xuất này không thể sửa!");
                    lb_maphieuxuat.Text = "";
                    txt_nguoilap.Text = "";
                    dtpk_ngaylap.Value = DateTime.Now.Date;
                    cbb_trangthai.SelectedItem = "Mới lập";
                }
                else 
                {
                    if (!String.IsNullOrEmpty(txt_nguoilap.Text))
                    {
                        if (dtpk_ngaylap.Value.Date >= px.Ngaylapphieu.Date && dtpk_ngaylap.Value.Date <= DateTime.Now)
                        {
                            if(cbb_trangthai.Text.Contains("Đã xuất hàng") && px.Tongtien ==0)
                            {
                                lb_maphieuxuat.Text = "";
                                txt_nguoilap.Text = "";
                                dtpk_ngaylap.Value = DateTime.Now;
                                cbb_trangthai.SelectedItem = "Mới lập";
                                MessageBox.Show("Phiếu xuất chưa được phép đổi trạng thái.");
                            }
                            else
                            {
                                px.Tennguoilap = txt_nguoilap.Text;
                                px.Ngaylapphieu = dtpk_ngaylap.Value.Date;
                                px.Trangthai = cbb_trangthai.Text;
                                dbphieuxuat.Updatephieuxuat(px);
                                if (px.Trangthai.Contains("Đã xuất hàng"))
                                {
                                    List<Chitietphieuxuat_DTO> listctpx = new List<Chitietphieuxuat_DTO>();
                                    listctpx = dbphieuxuat.GetChitietByMa(px.Maphieuxuat).ToList();

                                    foreach (Chitietphieuxuat_DTO item in listctpx)
                                    {
                                        ServiceReferenceTonkho.Chitietphieuxuat_DTO tk = new ServiceReferenceTonkho.Chitietphieuxuat_DTO();
                                        tk.Masanpham = item.Masanpham;
                                        tk.Soluong = item.Soluong;
                                        if (dbtonkho.XuatKho(tk))
                                        {
                                        }
                                        else
                                        {
                                            MessageBox.Show("xuat kho that bai");
                                            check = false;
                                        }
                                    }
                                    if (check == false)
                                    {
                                        px.Trangthai = "Mới lập";
                                        dbphieuxuat.Updatephieuxuat(px);
                                    }
                                }
                                var s = listpx.SingleOrDefault(x => x.Maphieuxuat.Equals(px.Maphieuxuat));
                                s.Tennguoilap = px.Tennguoilap;
                                s.Ngaylapphieu = px.Ngaylapphieu;
                                s.Trangthai = px.Trangthai;
                                timkiem();

                                lb_maphieuxuat.Text = "";
                                txt_nguoilap.Text = "";
                                dtpk_ngaylap.Value = DateTime.Now;
                                cbb_trangthai.SelectedItem = "Mới lập";
                                MessageBox.Show("Đã cập nhật phiếu nhập!");
                            }
                        }
                        else
                        {
                            lb_maphieuxuat.Text = "";
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

        private void gv_phieuxuat_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_phieuxuat.SelectedRows.Count > 0)
            {
                Phieuxuat_DTO px = (Phieuxuat_DTO)gv_phieuxuat.SelectedRows[0].DataBoundItem;
                lb_maphieuxuat.Text = px.Maphieuxuat.Trim();
                txt_nguoilap.Text = px.Tennguoilap;
                dtpk_ngaylap.Value = px.Ngaylapphieu.Date;
                cbb_trangthai.SelectedItem = px.Trangthai;
            }
        }
    }
}
