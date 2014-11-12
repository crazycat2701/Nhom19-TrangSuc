using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trangsuc.ServiceReferenceSanpham;
using System.Text.RegularExpressions;
using Trangsuc.ServiceReferenceTonkho;
namespace Trangsuc.Controllers
{ 
    public class sanphamController : Controller
    {
        public List<ServiceReferenceSanpham.Sanpham_DTO> danhsachsanpham = new List<ServiceReferenceSanpham.Sanpham_DTO>();

        ServiceTonkhoClient dbtonkho = new ServiceTonkhoClient();
        ServiceSanphamClient db = new ServiceSanphamClient();
        
        int pagesize = 6;
        public void dssanpham()
        {
            danhsachsanpham.Clear();
            danhsachsanpham = db.GetAllSp().Where(x => x.Sanphammoi == 1).ToList<ServiceReferenceSanpham.Sanpham_DTO>();
        }
        
       
        //
        // GET: /sanpham/Details/5

        public ActionResult chitietsanpham()
        {
            ServiceReferenceSanpham.Sanpham_DTO chitietsanpham = new ServiceReferenceSanpham.Sanpham_DTO();
            string masp = Request.QueryString["masp"];
            Tonkho_DTO tk = dbtonkho.Find(masp);
            ViewBag.Tonkho = tk.Soluong;
            chitietsanpham = db.Find(masp);
            if (chitietsanpham == null) return HttpNotFound();
            return View(chitietsanpham);
        }
        //san pham cùng loại hiện trong trang chi tiết sản phẩm
        [ChildActionOnly]
        public ActionResult sanphamcungloai(int page=1)
        {
            dssanpham();
            string masp = Request.QueryString["masp"];
            List<ServiceReferenceSanpham.Sanpham_DTO> sanphamcungloai = new List<ServiceReferenceSanpham.Sanpham_DTO>();
            ServiceReferenceSanpham.Sanpham_DTO sp = new ServiceReferenceSanpham.Sanpham_DTO();
            sp = danhsachsanpham.Single(x => x.Masanpham.Contains(masp));
            sanphamcungloai = db.GetSpCungLoai(sp.Loai.Maloai).Where(x=> x.Sanphammoi ==1).ToList();
            int _pagesize = 3;
            ViewBag.masp = masp;
            ViewBag.TotalPages = Math.Ceiling((double)sanphamcungloai.Count / _pagesize);
            return PartialView(sanphamcungloai.Skip((page - 1) * _pagesize).Take(_pagesize));
        }

        [ChildActionOnly]
        public ActionResult spbanchay()
        {

            List<ServiceReferenceSanpham.Sanpham_DTO> sanphambanchay = new List<ServiceReferenceSanpham.Sanpham_DTO>();
            sanphambanchay = db.GetSpBc().Where(x => x.Sanphammoi == 1).ToList();
            return PartialView(sanphambanchay);
        }
        //danh sach sản phẩm khi nhan vào danh mục sản phẩm
        public ActionResult DanhMuc(int page =1)
        {

            string maloai = Request.QueryString["maloai"];
            List<ServiceReferenceSanpham.Sanpham_DTO> sanpham = db.GetSpCungLoai(maloai).Where(x=>x.Sanphammoi ==1).ToList();
            ViewBag.tenloai = sanpham.FirstOrDefault().Tenloai;
            ViewBag.TotalPages = Math.Ceiling((double)sanpham.Count / pagesize);
            ViewBag.maloai = maloai;
            return View(sanpham.Skip((page - 1) * pagesize).Take(pagesize));

        }
        //có thể tìm kiếm theo mã hoặc tên sản phẩm
        public ActionResult TimKiem(int page=1)
        {
            dssanpham();
            string id = Request.QueryString["chuoitk"];
            id = id.ToLower();
            List<ServiceReferenceSanpham.Sanpham_DTO> kqtimkiem = new List<ServiceReferenceSanpham.Sanpham_DTO>();
            foreach (ServiceReferenceSanpham.Sanpham_DTO item in danhsachsanpham)
            {
                if (item.Tensanpham.ToLower().Contains(id) || item.Masanpham.Trim().ToLower().Contains(id))
                    kqtimkiem.Add(item);
            }
            ViewBag.Chuoi = id;
            ViewBag.KhongTimThay = "Không tìm thấy";
            ViewBag.TotalPages = Math.Ceiling((double)kqtimkiem.Count / pagesize);
            return View(kqtimkiem.Skip((page - 1) * pagesize).Take(pagesize));
        }

        //public bool IsNumber(string pText)
        //{
        //    Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
        //    return regex.IsMatch(pText);
        //}

        public ActionResult TimKiemNangCao(int page = 1)
        {
            dssanpham();
            string loaihang = Request.QueryString["loaihang"];
            string tensp = Request.QueryString["tensp"];
            tensp = tensp.ToLower();
            string giatu = Request.QueryString["giatu"];
            string den = Request.QueryString["den"];
            int _giatu = int.Parse(giatu);
            int _giaden = int.Parse(den);
            if (loaihang.Equals("tatca"))
            {
                loaihang = "";
            }
            if (tensp.Equals("tên sản phẩm"))
            {
                tensp = "";
            }
            List<ServiceReferenceSanpham.Sanpham_DTO> kqtimkiem = danhsachsanpham;
            if (!String.IsNullOrEmpty(loaihang))
            {
                kqtimkiem = kqtimkiem.Where(t => t.Loai.Maloai.Contains(loaihang)).ToList();
            }
            if (!String.IsNullOrEmpty(tensp))
            {
                kqtimkiem = kqtimkiem.Where(t => t.Tensanpham.ToLower().Contains(tensp)).ToList();
            }
            kqtimkiem = kqtimkiem.Where(t => (t.Giasanpham >= _giatu && t.Giasanpham <= _giaden)).ToList();
            ViewBag.KhongTimThay = "Không tìm thấy các sản phẩm thỏa điều kiện";

            //ViewBag dùng cho phân trang
            ViewBag.loaihang = loaihang;
            ViewBag.tensp = tensp;
            ViewBag.giatu = giatu;
            ViewBag.giaden = den;
            //tông số trang
            ViewBag.TotalPages = Math.Ceiling((double)kqtimkiem.Count / pagesize);
            //pagesize số sản phẩm hiện trong 1 trang
            return View(kqtimkiem.Skip((page - 1) * pagesize).Take(pagesize));
        }
        
        //khung tim kiếm cơ bản và nâng cao
        [ChildActionOnly]
        public ActionResult KhungTimKiem()
        {
            return PartialView();
        }
    }
}