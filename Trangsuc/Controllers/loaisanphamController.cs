using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trangsuc.ServiceReferenceSanpham;
namespace Trangsuc.Controllers
{
    public class loaisanphamController : Controller
    {
        List<Loaisanpham_DTO> danhsachloaisanpham = new List<Loaisanpham_DTO>();
        ServiceSanphamClient db = new ServiceSanphamClient();
        //
        // GET: /loaisanpham/

        public void dsloaisanpham()
        {
            danhsachloaisanpham.Clear();
            danhsachloaisanpham = db.GetAllLoaiSp().ToList<Loaisanpham_DTO>();
        }

        //menu danh muc sản phẩm
        [ChildActionOnly]
        public ActionResult Menu()
        {
            dsloaisanpham();
            return PartialView(danhsachloaisanpham);
        }
        //list box danh muc san pham trong tim kiem nang cao
        [ChildActionOnly]
        public ActionResult Menutimkiem()
        {
            dsloaisanpham();
            return PartialView(danhsachloaisanpham);
        }

    }
}
