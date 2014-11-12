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
    public partial class FormSua : Form
    {
        ServiceSanphamClient dbsanpham = new ServiceSanphamClient();
        public delegate void DelegateA();
        public DelegateA Sender;
        Sanpham_DTO sp;
        public FormSua()
        {
            InitializeComponent();      
        }
      
        public FormSua(Sanpham_DTO _sp)
        {
            InitializeComponent();
            txt_hinhanh.Enabled = false;
            sp = _sp;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSua_Load(object sender, EventArgs e)
        {
            lb_maspham.Text = sp.Masanpham;
            lb_loaisp.Text = sp.Tenloai;
            txt_tensanpham.Text = sp.Tensanpham;
            txt_chatlieu.Text = sp.Chatlieu;
            txt_gia.Text = sp.Giasanpham.ToString();
            txt_hinhanh.Text = sp.Hinhanh;
            String path = @"..\..\..\Trangsuc\";
            picture1.Image = Image.FromFile(path+sp.Hinhanh);
           
            picture1.SizeMode = PictureBoxSizeMode.CenterImage;
            picture1.BorderStyle = BorderStyle.Fixed3D;
            picture1.SizeMode = PictureBoxSizeMode.StretchImage;
            picture1.Width = 149; // xét chiều rộng
            picture1.Height = 149; // xét chiều dài
                         
        }

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {           
            
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
                                    Sanpham_DTO sanpham = dbsanpham.Find(sp.Masanpham);
                                    sanpham.Tensanpham = txt_tensanpham.Text;
                                    sanpham.Chatlieu = txt_chatlieu.Text;
                                    sanpham.Giasanpham = int.Parse(txt_gia.Text);
                                    sanpham.Hinhanh = txt_hinhanh.Text;
                                    dbsanpham.Update(sanpham);
                                    if (sp.Hinhanh != txt_hinhanh.Text)
                                    {
                                        File.Copy(text[0], text[1]);
                                    }
                                    if (Sender != null)
                                    {
                                        Sender();
                                    }
                                    this.Close();
                                }
        }

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

        String[] text = new String[2];
        private void btn_browse_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog open = new OpenFileDialog();
            String h="Image/"+laytenloai(sp.Loai.Maloai)+"/";
            String path = @"..\..\..\Trangsuc\";
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
                    picture1.Image = Image.FromFile(open.FileName);                  
                    txt_hinhanh.Text = hinhanh;
                }
                

            }
            
        }
       
    }
}
