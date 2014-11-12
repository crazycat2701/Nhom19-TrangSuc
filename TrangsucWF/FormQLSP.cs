using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrangsucWF.ServiceReferenceSanpham;

namespace TrangsucWF
{
    public partial class FormQLSP : Form
    {
 
        ServiceSanphamClient dbsanpham = new ServiceSanphamClient();
        List<Sanpham_DTO> listsp = new List<Sanpham_DTO>();
        List<Sanpham_DTO> listsptk = new List<Sanpham_DTO>();
        public List<Sanpham_DTO> dssanpham()
        {
            listsp=dbsanpham.GetAllSp().ToList();
            return listsp;
        }
        public FormQLSP()
        {
            InitializeComponent();
        }
        private void Load_hinh()
        {
            for (int i = 0; i < gv_product.Rows.Count; i++)
            {
                //Load hình ảnh
                DataGridViewRow row = gv_product.Rows[i];
                Sanpham_DTO sp = dbsanpham.Find(row.Cells["masanpham"].Value.ToString());
                row.Cells["hinhanh"].Value = Image.FromFile(@"..\..\..\Trangsuc\" + sp.Hinhanh).GetThumbnailImage(55, 55, null, IntPtr.Zero);
                row.Height = 60;

                //Load sản phẩm Hiện/Ẩn
                if (sp.Sanphammoi == 1)
                {
                    row.Cells["sanphammoi"].Value = true;
                }
                else row.Cells["sanphammoi"].Value = false;
            }
        }
        private void FormQLSP_Load(object sender, EventArgs e)
        {
            dssanpham();
            gv_product.AutoGenerateColumns = false;
            gv_product.DataSource = listsp;
            Load_hinh();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //tìm kiếm theo mã hoặc tên sản phẩm
        public void timkiem()
        {
            listsptk.Clear();

            foreach (Sanpham_DTO sp in listsp)
            {
                String nametolower = sp.Tensanpham.ToLower();
                String masptolower = sp.Masanpham.ToLower();
                if (nametolower.Contains(txt_find.Text.ToLower()) || masptolower.Contains(txt_find.Text.ToLower()))
                {
                    listsptk.Add(sp);
                }
            }
            gv_product.DataSource = null;
            gv_product.DataSource = listsptk;
            Load_hinh();
        }
        
        private void btn_find_Click(object sender, EventArgs e)
        {
            timkiem();
        }

        private void gv_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //kích hoạt sản phẩm hiện/ẩn
            if (e.ColumnIndex == gv_product.Columns["sanphammoi"].Index)
            {
                if (listsptk.Count != 0)
                {
                    Sanpham_DTO sp = listsptk[e.RowIndex];
                    if (sp.Sanphammoi == 0)
                    {
                        dbsanpham.Kichhoat(sp);
                        sp.Sanphammoi = 1;
                        DataGridViewRow row = gv_product.Rows[e.RowIndex];
                        row.Cells["sanphammoi"].Value = true;
                    }
                    else {
                        dbsanpham.Delete(sp);
                        sp.Sanphammoi = 0;
                        DataGridViewRow row = gv_product.Rows[e.RowIndex];
                        row.Cells["sanphammoi"].Value = false;
                    }
                }
                else {
                    Sanpham_DTO sp = listsp[e.RowIndex];
                    if (sp.Sanphammoi == 0)
                    {
                        dbsanpham.Kichhoat(sp);
                        sp.Sanphammoi = 1;
                        DataGridViewRow row = gv_product.Rows[e.RowIndex];
                        row.Cells["sanphammoi"].Value = true;
                    }
                    else
                    {
                        dbsanpham.Delete(sp);
                        sp.Sanphammoi = 0;
                        DataGridViewRow row = gv_product.Rows[e.RowIndex];
                        row.Cells["sanphammoi"].Value = false;
                    }
                }
            }
            if (e.ColumnIndex == gv_product.Columns["Edit"].Index)
            {
                if (listsptk.Count != 0)
                {
                    
                   Sanpham_DTO sp = listsptk[e.RowIndex];
                    FormSua frmSua = new FormSua(sp);
                    frmSua.Sender = new FormSua.DelegateA(GetTK);
                    frmSua.ShowDialog();
                }
                else
                {
                    Sanpham_DTO sp = listsp[e.RowIndex];
                    FormSua frmSua = new FormSua(sp);
                    frmSua.Sender = new FormSua.DelegateA(Get);
                    frmSua.ShowDialog();
                }
            }
        }
        //dùng để load dử liệu lại sau khi thêm hoặc sửa sản phẩm
        private void Get()
        {
            gv_product.DataSource = null;
            dssanpham();
            gv_product.DataSource = listsp;
            Load_hinh();
        }
        //dùng để load dử liệu lại sau khi thêm hoặc sửa sản phẩm
        private void GetTK()
        {
            dssanpham();
            timkiem();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            FormThemSP frmThem = new FormThemSP();
            //dùng để load dử liệu lại sau khi thêm hoặc sửa sản phẩm thông qua delegate sender bên formthemsp
            frmThem.Sender = new FormThemSP.DelegateA(Get);
            frmThem.ShowDialog();
        }

    }
}
