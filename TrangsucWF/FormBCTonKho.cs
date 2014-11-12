using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TrangsucWF.ServiceReferenceTonkho;
namespace TrangsucWF
{
    public partial class FormBCTonKho : Form
    {
        List<Tonkho_DTO> listtonkho;
        string ngay;
        string loai;
        string ma;
        public FormBCTonKho(List<Tonkho_DTO> _listtonkho, string _ngay, string _loai, string _ma)
        {
            listtonkho = _listtonkho;
            ngay = _ngay;
            loai = _loai;
            ma = _ma;
            InitializeComponent();
        }

        private void FormBCTonKho_Load(object sender, EventArgs e)
        {
            //add datasource để hiển thị danh sách lên file report
            this.Tonkho_DTOBindingSource.DataSource = listtonkho;
            if (listtonkho.Count > 0)
            {
                ReportParameter ghichu = new ReportParameter("ghichu", " ");
                this.reportViewer1.LocalReport.SetParameters(ghichu);
            }
            else
            {
                ReportParameter ghichu = new ReportParameter("ghichu", "Ghi chú: " + ma + " chưa nhập hàng vào thời gian này.");
                this.reportViewer1.LocalReport.SetParameters(ghichu);
            }
            //gán giá trị cho reportparameter
            ReportParameter cty = new ReportParameter("cty", "Công ty Trang sức DEW");
            //gán giá trị lên report viewer
            this.reportViewer1.LocalReport.SetParameters(cty);
            ReportParameter dc1 = new ReportParameter("dchi1", "Lầu 3, Cao ốc Empire State,");
            this.reportViewer1.LocalReport.SetParameters(dc1);
            ReportParameter dc2 = new ReportParameter("dchi2", "1 Đại lộ Nguyễn Văn Linh, P. Tân Phú, Q.7, TP.HCM");
            this.reportViewer1.LocalReport.SetParameters(dc2);
            ReportParameter dt = new ReportParameter("dt", "Điện thoại: 01699460529");
            this.reportViewer1.LocalReport.SetParameters(dt);
            ReportParameter tenbc = new ReportParameter("tenthongke", "THỐNG KÊ TỒN KHO");
            this.reportViewer1.LocalReport.SetParameters(tenbc);
            ReportParameter loaisp = new ReportParameter("loaisp", "LOẠI SẢN PHẨM: " + loai);
            this.reportViewer1.LocalReport.SetParameters(loaisp);
            ReportParameter tensp = new ReportParameter("tensp", "MÃ SẢN PHẨM: " + ma);
            this.reportViewer1.LocalReport.SetParameters(tensp);
            ReportParameter tungay = new ReportParameter("ngay", "TÍNH ĐẾN NGÀY " + ngay);
            this.reportViewer1.LocalReport.SetParameters(tungay);

            ReportParameter ngaylapphieu = new ReportParameter("ngaylap", "___________, ngày " + DateTime.Today.ToString("dd/MM/yyyy"));
            this.reportViewer1.LocalReport.SetParameters(ngaylapphieu);
            ReportParameter nguoilapphieu = new ReportParameter("nguoilap", "Người lập thống kê");
            this.reportViewer1.LocalReport.SetParameters(nguoilapphieu);
            ReportParameter kiten = new ReportParameter("kyten", "(Ký, ghi rõ họ tên)");
            this.reportViewer1.LocalReport.SetParameters(kiten);
            this.reportViewer1.RefreshReport();
        }
    }
}
