using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trangsuc.ServiceReferenceSanpham;

namespace Trangsuc.Controllers
{
    public class HomeController : Controller
    {

        ServiceSanphamClient db = new ServiceSanphamClient();

      

        public ActionResult Index()
        {
            List<Sanpham_DTO> sanphamnoibat = new List<Sanpham_DTO>();
            sanphamnoibat = db.GetSpMoi().ToList<Sanpham_DTO>();
            return View(sanphamnoibat.Take(9));
        }

        public ActionResult TuyenDung()
        {
            return View();
        }

        public ActionResult GioiThieu()
        {
            return View();
        }

        public ActionResult TinTuc()
        {
            return View();
        }

        public ActionResult CuaHang()
        {
            return View();
        }

    }
}
