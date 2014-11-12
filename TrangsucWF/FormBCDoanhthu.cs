using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace TrangsucWF
{
    public partial class FormBCDoanhthu : Form
    {
        List<ServiceReferenceHoadon.Chitiethoadon_DTO> listcthd;
        string Tungay; string Denngay; string tongtien;
        public FormBCDoanhthu(string _tungay, string _denngay, string _tongtien, List<ServiceReferenceHoadon.Chitiethoadon_DTO> _listcthd)
        {
            listcthd = _listcthd;
            Tungay = _tungay;
            Denngay = _denngay;
            tongtien = _tongtien;
            InitializeComponent();
        }

        private void FormBCDoanhthu_Load(object sender, EventArgs e)
        {
            //đổ ds dtượng cho report
            this.Chitiethoadon_DTOBindingSource.DataSource = listcthd;
            // set para
            if (listcthd.Count != 0)
            {
                ReportParameter ghichu = new ReportParameter("ghichu", " ");
                this.reportViewer1.LocalReport.SetParameters(ghichu);
            }
            else
            {
                ReportParameter ghichu = new ReportParameter("ghichu", "Ghi chú: Không có doanh thu trong thời gian này.");
                this.reportViewer1.LocalReport.SetParameters(ghichu);
            }
            ReportParameter cty = new ReportParameter("tencty", "Công ty Trang sức DEW");
            this.reportViewer1.LocalReport.SetParameters(cty);
            ReportParameter dc1 = new ReportParameter("diachi1", "Lầu 3, Cao ốc Empire State,");
            this.reportViewer1.LocalReport.SetParameters(dc1);
            ReportParameter dc2 = new ReportParameter("diachi2", "1 Đại lộ Nguyễn Văn Linh, P. Tân Phú, Q.7, TP.HCM");
            this.reportViewer1.LocalReport.SetParameters(dc2);
            ReportParameter dt = new ReportParameter("sodt", "Điện thoại: 01699460529");
            this.reportViewer1.LocalReport.SetParameters(dt);
            ReportParameter tenbc = new ReportParameter("tenbaocao", "BÁO CÁO DOANH THU BÁN HÀNG");
            this.reportViewer1.LocalReport.SetParameters(tenbc);
            ReportParameter tungay = new ReportParameter("tungay", "TỪ NGÀY " + Tungay + " ĐẾN NGÀY " + Denngay);
            this.reportViewer1.LocalReport.SetParameters(tungay);
            ReportParameter tien = new ReportParameter("tongtien", "TỔNG TIỀN: " + tongtien + " VNĐ");
            this.reportViewer1.LocalReport.SetParameters(tien);
            ReportParameter ngaylapphieu = new ReportParameter("ngaylapphieu", "___________, ngày " + DateTime.Today.ToString("dd/MM/yyyy"));
            this.reportViewer1.LocalReport.SetParameters(ngaylapphieu);
            ReportParameter nguoilapphieu = new ReportParameter("nguoilapphieu", "Người lập báo cáo");
            this.reportViewer1.LocalReport.SetParameters(nguoilapphieu);
            ReportParameter kiten = new ReportParameter("kiten", "(Ký, ghi rõ họ tên)");
            this.reportViewer1.LocalReport.SetParameters(kiten);
            this.reportViewer1.RefreshReport();
        }
    }
}
