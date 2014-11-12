using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrangsucWF.ServiceReferenceHoadon;
using TrangsucWF.ServiceReferenceTonkho;
namespace TrangsucWF
{
    public partial class FormQLDH : Form
    {
        ServiceHoadonClient dbhoadon = new ServiceHoadonClient();
        ServiceTonkhoClient dbtonkho = new ServiceTonkhoClient();
        List<ServiceReferenceHoadon.Hoadon_DTO> listhd;
        List<ServiceReferenceHoadon.Hoadon_DTO> listhdtk = new List<ServiceReferenceHoadon.Hoadon_DTO>();
        List<ServiceReferenceHoadon.Chitiethoadon_DTO> listcthd;
        public FormQLDH()
        {
            InitializeComponent();
        }
        private void FormQLDH_Load(object sender, EventArgs e)
        {
            listhd = dbhoadon.GetAllHoadon().ToList();

            gv_hoadon.AutoGenerateColumns = false;
            //gv_hoadon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dtpk_tu.Value = DateTime.Today.AddDays(-30);
            List<string> trangthai2 = new List<string>();
             trangthai2.Add("Mới");
             trangthai2.Add("Đã giao");
             trangthai2.Add("Trả lại");
             trangthai2.Add("Hủy");
             List<string> trangthai1 = new List<string>();
             trangthai1.Add("Tất cả");
             trangthai1.Add("Mới");
             trangthai1.Add("Đã giao");
             trangthai1.Add("Trả lại");
             trangthai1.Add("Hủy");
            cbb_trangthai1.DataSource = trangthai1;         
            cbb_trangthai2.DataSource = trangthai2;
            timkiem();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Lưu thay đổi chưa vậy?", "Cảnh báo Thoát", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void timkiem()
        {
            listhdtk.Clear();
            foreach (ServiceReferenceHoadon.Hoadon_DTO hd in listhd)
            {
                if (cbb_trangthai1.Text == "Tất cả" && hd.Ngaymuahang.Date >= dtpk_tu.Value.Date && hd.Ngaymuahang.Date <= dtpk_den.Value.Date)
                    listhdtk.Add(hd);
                if (hd.Trangthai.Contains(cbb_trangthai1.Text) && hd.Ngaymuahang.Date >= dtpk_tu.Value.Date && hd.Ngaymuahang.Date <= dtpk_den.Value.Date)
                {
                    listhdtk.Add(hd);
                }
            }

            gv_hoadon.DataSource = null;
            gv_hoadon.DataSource = listhdtk;
        }
        private void btn_find_Click(object sender, EventArgs e)
        {
            timkiem();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (gv_hoadon.SelectedRows.Count > 0)
            {
                ServiceReferenceHoadon.Hoadon_DTO hdsua = (ServiceReferenceHoadon.Hoadon_DTO)gv_hoadon.SelectedRows[0].DataBoundItem;

                if (hdsua.Trangthai.Contains("Mới"))
                {
                    if (!String.IsNullOrEmpty(txt_diadiemgiaohang.Text))
                    {
                        hdsua.Id = 1;
                        hdsua.Trangthai = cbb_trangthai2.Text;
                        hdsua.Diadiemgiaohang = txt_diadiemgiaohang.Text;
                        hdsua.Ngaygiaohang = dtpk_ngaygiao.Value.Date;
                        timkiem();
                        lb_mahoadon.Text = "";
                        cbb_trangthai2.Text = "";
                        txt_diadiemgiaohang.Text = "";
                    }
                }
                else
                    {
                        MessageBox.Show("Đơn hàng không thể sửa!");
                        lb_mahoadon.Text = "";
                        cbb_trangthai2.Text = "";
                        txt_diadiemgiaohang.Text = "";
                    }
                
            }
            else
            {
                MessageBox.Show(" Bạn chưa chọn đơn hàng cần sửa");
            }
        }



        private void gv_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == gv_hoadon.Columns["detail"].Index)
                {
                    if (listhdtk.Count != 0)
                    {
                        ServiceReferenceHoadon.Hoadon_DTO hd = listhdtk[e.RowIndex];
                        listcthd = dbhoadon.GetChitietByMa(hd.Mahoadon).ToList();
                        FormCTHD cthd = new FormCTHD(listcthd);
                        cthd.ShowDialog();
                    }
                    else
                    {
                        ServiceReferenceHoadon.Hoadon_DTO hd = listhd[e.RowIndex];
                        listcthd = dbhoadon.GetChitietByMa(hd.Mahoadon).ToList();
                        FormCTHD cthd = new FormCTHD(listcthd);
                        cthd.ShowDialog();
                    }
                }
            }
            catch
            {
                MessageBox.Show(" Lỗi");

            }
        }

        private void gv_hoadon_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_hoadon.SelectedRows.Count > 0)
            {
                ServiceReferenceHoadon.Hoadon_DTO hd = (ServiceReferenceHoadon.Hoadon_DTO)gv_hoadon.SelectedRows[0].DataBoundItem;
                lb_mahoadon.Text = hd.Mahoadon.ToString();
                if (!hd.Trangthai.Contains("Mới"))
                {
                    txt_diadiemgiaohang.Enabled = false;                  
                    dtpk_ngaygiao.Enabled = false;
                    cbb_trangthai2.Enabled = false;
                }
                else
                {
                    txt_diadiemgiaohang.Enabled = true;
                    dtpk_ngaygiao.Enabled = true;
                    cbb_trangthai2.Enabled = true;
                    
                }
                dtpk_ngaygiao.Value = hd.Ngaygiaohang;
                txt_diadiemgiaohang.Text = hd.Diadiemgiaohang;
                cbb_trangthai2.SelectedItem = hd.Trangthai;
                
                
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            foreach (ServiceReferenceHoadon.Hoadon_DTO hd in listhd)
            {
                
                if (hd.Id == 1)
                {
                    if (dbhoadon.UpdateHoadon(hd))
                    {
                       hd.Id = 0;
                    }

                    // if (hd.Trangthai.Contains("Trả lại"))
                    //{
                    //    try
                    //    {
                    //        List<ServiceReferenceHoadon.Chitiethoadon_DTO> listcthd = new List<ServiceReferenceHoadon.Chitiethoadon_DTO>();
                    //        listcthd = dbhoadon.GetChitietByMa(hd.Mahoadon).ToList();
                    //        Tonkho_DTO tonkho = new Tonkho_DTO();

                    //        foreach (var item in listcthd)
                    //        {
                    //            ServiceReferenceTonkho.Chitietphieunhap_DTO _item = new ServiceReferenceTonkho.Chitietphieunhap_DTO();
                    //            _item.Masanpham = item.Masanpham;
                    //            _item.Soluong = item.Soluong;
                    //            dbtonkho.NhapKho(_item);
                    //        }
                    //        if (dbhoadon.UpdateHoadon(hd))
                    //        {
                    //            hd.Id = 0;
                    //        }
                    //    }
                    //    catch
                    //    {
                    //    }

                    //}
                    //else
                    //{
                    //    if (dbhoadon.UpdateHoadon(hd))
                    //    {
                    //        hd.Id = 0;
                    //    }
                    //}      
                    
                }
            }
            MessageBox.Show("Lưu thành công");
        }
    }
}
