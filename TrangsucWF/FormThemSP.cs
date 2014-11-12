using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrangsucWF.ServiceReferenceSanpham;
using System.IO;
using System.Text.RegularExpressions;


namespace TrangsucWF
{
    public partial class FormThemSP : Form
    {
        ServiceSanphamClient dbsanpham = new ServiceSanphamClient();
        public delegate void DelegateA();
        public DelegateA Sender;
        public FormThemSP()
        {
            InitializeComponent();
            txt_hinhanh.Enabled = false;
        }
        //lấy tên folder chứa hình ảnh của từng loại sản phẩm
        public string laytenloai(string maloai)
        {
            string tenloai = null;
            if (maloai.Contains("BT"))
            {
                tenloai = "bongtai";
            }
            else if (maloai.Contains("DC"))
            {
                tenloai = "daychuyen";
            }
            else if (maloai.Contains("L"))
            {
                tenloai = "lac";
            }
            else if (maloai.Contains("M"))
            {
                tenloai = "matday";
            }
            else if (maloai.Contains("N"))
            {
                tenloai = "nhan";
            }
            else tenloai = "vong";
            return tenloai;
        }
        //dùng để chứa đường link hình ảnh
        String[] text = new String[2];
        //chọn hỉnh ảnh để thêm
        private void btn_chon_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            String h = "Image/" + laytenloai(cb_maloai.SelectedValue.ToString()) + "/";
            String path = @"..\..\..\Trangsuc\";
            //những file ảnh có thể mở
            open.Filter = "Hình ảnh *.jpg,*.jpeg,*.png,*.gif|*.jpg;*.jpeg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                String filename = Path.GetFileNameWithoutExtension(open.FileName);
                string extension = Path.GetExtension(open.FileName);
                if (File.Exists(path + h + filename + extension))
                {
                    MessageBox.Show("Hình bị trùng tên rồi!!!");
                }
                else
                {
                    text[0] = open.FileName;
                    String hinh = path + h + filename + extension;
                    text[1] = hinh;
                    String hinhanh = h + filename + extension;
                    //hiện hình ảnh lên
                    picture1.Image = Image.FromFile(text[0]);
                    picture1.SizeMode = PictureBoxSizeMode.CenterImage;
                    picture1.BorderStyle = BorderStyle.Fixed3D;
                    picture1.SizeMode = PictureBoxSizeMode.StretchImage;
                    picture1.Width = 149; 
                    picture1.Height = 149; 
                    txt_hinhanh.Text = hinhanh;
                }


            }
        }

        private void FormThemSP_Load(object sender, EventArgs e)
        {
            cb_maloai.DataSource = dbsanpham.GetAllLoaiSp();
            cb_maloai.DisplayMember = "Tenloai";
            cb_maloai.ValueMember = "Maloai";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            
            if (txt_masanpham.Text.Length == 0)
            {
                MessageBox.Show("Phải nhập mã sản phẩm!");
            }
            else
                if (dbsanpham.Find(txt_masanpham.Text)!=null)
                {
                    MessageBox.Show("Mã sản phẩm bị trùng, vui lòng nhập 1 mã khác!");
                }
                else
                if (txt_tensanpham.Text.Length == 0)
                {
                    MessageBox.Show("Phải nhập tên cho sản phẩm!");
                }
                else
                    if (txt_chatlieu.Text.Length == 0)
                    {
                        MessageBox.Show("Phải nhập chất liệu cho sản phẩm!");
                    }
                    else
                        if (txt_gia.Text.Length == 0)
                        {
                            MessageBox.Show("Phải nhập giá cho sản phẩm!");
                        }
                        else
                            if (!IsNumber(txt_gia.Text))
                            {
                                MessageBox.Show("Giá sản phẩm phải là số!");
                                txt_gia.Text = "";
                            }
                            else
                                if (txt_hinhanh.Text.Length == 0)
                                {
                                    MessageBox.Show("Phải chọn hình ảnh cho Sản phẩm!");
                                }
                                else
                                {
                                    Sanpham_DTO sp = new Sanpham_DTO();
                                    sp.Masanpham = txt_masanpham.Text;
                                    sp.Tensanpham = txt_tensanpham.Text;
                                    sp.Chatlieu = txt_chatlieu.Text;
                                    sp.Giasanpham = int.Parse(txt_gia.Text);
                                    sp.Hinhanh = txt_hinhanh.Text;
                                    sp.Loai = dbsanpham.GetLoaisp(cb_maloai.SelectedValue.ToString());
                                    dbsanpham.Insert(sp);
                                    //copy hình ảnh vào folder sản phẩm
                                    File.Copy(text[0], text[1]);
                                    if (Sender != null)
                                    {
                                        //cập nhật dữ liệu lại trong formqlsp
                                        Sender();
                                    }
                                    this.Close();
                                }

        }
    }
}
