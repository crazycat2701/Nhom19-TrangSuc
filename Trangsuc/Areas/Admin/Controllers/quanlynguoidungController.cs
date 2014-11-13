using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trangsuc.Models;
using Trangsuc.ServiceReferenceNguoidung;
namespace Trangsuc.Areas.Admin.Controllers
{
    public class quanlynguoidungController : Controller
    {
        List<Nguoidung_DTO> danhsachnguoidung = new List<Nguoidung_DTO>();
        List<Nguoidung_DTO> danhsachnguoidungan = new List<Nguoidung_DTO>();
        ServiceNguoidungClient dbnguoidung = new ServiceNguoidungClient();
        List<Phanquyen_DTO> danhsachphanquyen = new List<Phanquyen_DTO>();
        int pagesize = 6;

        public void dsnguoidung()
        {
            danhsachnguoidung.Clear();
            danhsachnguoidung = dbnguoidung.GetAllNguoidung().Where(x => x.Useran == false).ToList();
        }
        public void dsnguoidungan()
        {
            danhsachnguoidungan.Clear();
            danhsachnguoidungan = dbnguoidung.GetAllNguoidung().Where(x => x.Useran == true).ToList();
        }
        public void dsphanquyen()
        {
            danhsachphanquyen.Clear();
            danhsachphanquyen = dbnguoidung.GetAllQuyen().ToList();
        }

        [ChildActionOnly]
        public ActionResult Menu()
        {
            dsphanquyen();
            return PartialView(danhsachphanquyen);
        }

        public ActionResult Index(int page = 1)
        {
            dsnguoidung();
            ViewBag.TotalPages = Math.Ceiling((double)danhsachnguoidung.Count / pagesize);
            return View(danhsachnguoidung.Skip((page - 1) * pagesize).Take(pagesize));
        }

        public ActionResult danhsachuser(int page = 1)
        {
            int mapq = int.Parse(Request.QueryString["phanquyen"].ToString());
            dsnguoidung();
            List<Nguoidung_DTO> danhsachuser = new List<Nguoidung_DTO>();
            foreach (Nguoidung_DTO nd in danhsachnguoidung)
            {
                if ((nd.Quyen.Maphanquyen == mapq))
                    danhsachuser.Add(nd);
            }
            ViewBag.TotalPages = Math.Ceiling((double)danhsachuser.Count / pagesize);
            ViewBag.phanquyen = mapq;
            return View(danhsachuser.Skip((page - 1) * pagesize).Take(pagesize));
        }

        [ChildActionOnly]
        public ActionResult timkiemnguoidung()
        {
            return PartialView();
        }

        public ActionResult nguoidungan(int page = 1)
        {
            dsnguoidungan();
            ViewBag.TotalPages = Math.Ceiling((double)danhsachnguoidungan.Count / pagesize);
            return View(danhsachnguoidungan.Skip((page - 1) * pagesize).Take(pagesize));
        }

        public ActionResult ketquatimkiem(int page = 1)
        {
            dsnguoidung();
            string id = Request.QueryString["chuoitk"];
            List<Nguoidung_DTO> kqtimkiem = new List<Nguoidung_DTO>();
            foreach (Nguoidung_DTO item in danhsachnguoidung)
            {
                if (item.Username.Contains(id))
                    kqtimkiem.Add(item);
                else if (item.Hoten.Contains(id))
                    kqtimkiem.Add(item);
            }
            ViewBag.Chuoi = id;
            ViewBag.KhongTimThay = "Không tìm thấy";
            ViewBag.TotalPages = Math.Ceiling((double)kqtimkiem.Count / pagesize);
            return View(kqtimkiem.Skip((page - 1) * pagesize).Take(pagesize));
        }

        //cho phép sửa mật khẩu,phân quyền, kích hoat hoặc khóa người dùng
        public ActionResult suathongtin()
        {
            string id = Request.QueryString["username"];
            Nguoidung_DTO nguoidungsua = dbnguoidung.GetNguoidungByUsername(id);
            List<SelectListItem> listPhanQuyen = new List<SelectListItem>();
            listPhanQuyen.Add(new SelectListItem { Text = nguoidungsua.Quyen.Quyen, Value = nguoidungsua.Quyen.Maphanquyen.ToString() });
            dsphanquyen();
            foreach (Phanquyen_DTO pq in danhsachphanquyen)
            {
                if (pq.Maphanquyen != nguoidungsua.Quyen.Maphanquyen)
                {
                    string mapq = pq.Maphanquyen.ToString();
                    string quyen = pq.Quyen.ToString();
                    listPhanQuyen.Add(new SelectListItem { Text = quyen, Value = mapq });
                }
            }

            ViewBag.listPhanQuyen = listPhanQuyen;
            return View(nguoidungsua);
        }


        [HttpPost]
        public ActionResult suathongtin(Nguoidung_DTO nguoidungsua, FormCollection form)
        {
            int maphanquyen = int.Parse(form["quyen"].ToString());
            nguoidungsua.Quyen = dbnguoidung.GetQuyen(maphanquyen);
            try
            {
                dbnguoidung.Update(nguoidungsua);
            }
            catch
            {
            }

            return RedirectToAction("Index", "quanlynguoidung");

        }

    }
}
