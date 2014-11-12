using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trangsuc.Models;
using System.IO;
using Trangsuc.ServiceReferenceSanpham;
namespace Trangsuc.Areas.Admin.Controllers
{
    public class quanlysanphamController : Controller
    {
      
                public List<Sanpham_DTO> danhsachtatcasanpham = new List<Sanpham_DTO>();
                public List<Sanpham_DTO> danhsachsanpham = new List<Sanpham_DTO>();
                public List<Sanpham_DTO> danhsachsanphaman = new List<Sanpham_DTO>();
                ServiceSanphamClient dbsanpham = new ServiceSanphamClient();
                 int pagesize = 6;

                public void dstatcasanpham()
                {
                    danhsachtatcasanpham.Clear();
                    danhsachtatcasanpham = dbsanpham.GetAllSp().ToList();
                }

                List<Loaisanpham_DTO> danhsachloaisanpham = new List<Loaisanpham_DTO>();
                public void dsloaisanpham()
                {
                    danhsachloaisanpham.Clear();
                    danhsachloaisanpham = dbsanpham.GetAllLoaiSp().ToList();
                }
                [ChildActionOnly]
                public ActionResult Menu()
                {
                    dsloaisanpham();
                    return PartialView(danhsachloaisanpham);
                }

                public void ds_sanpham()
                {
                    dstatcasanpham();
                    danhsachsanpham = (from sp in danhsachtatcasanpham where sp.Sanphammoi == 1 select sp).ToList();
                }

                public void ds_sanpham_an()
                {
                    dstatcasanpham();
                    danhsachsanphaman = (from sp in danhsachtatcasanpham where sp.Sanphammoi == 0 select sp).ToList();
                }

                public ActionResult Index(int page=1)
                {
                    ds_sanpham();
                    ViewBag.TotalPages = Math.Ceiling((double)danhsachsanpham.Count / pagesize);
                    return View(danhsachsanpham.Skip((page - 1) * pagesize).Take(pagesize));
                }

                public ActionResult sanphaman(int page = 1)
                {
                    ds_sanpham_an();
                    ViewBag.TotalPages = Math.Ceiling((double)danhsachsanphaman.Count / pagesize);
                    return View(danhsachsanphaman.Skip((page - 1) * pagesize).Take(pagesize));
                }

                public ActionResult ketquatimkiem(int page=1)
                {
                    ds_sanpham();
                    string id = Request.QueryString["chuoitk"];
                    id = id.ToLower();
                    List<Sanpham_DTO> kqtimkiem = new List<Sanpham_DTO>();
                    foreach (var item in danhsachsanpham)
                    {
                        if (item.Tensanpham.ToLower().Contains(id) || item.Masanpham.Trim().ToLower().Contains(id))
                            kqtimkiem.Add(item);
                    }
                    ViewBag.Chuoi = id;
                    ViewBag.KhongTimThay = "Không tìm thấy";
                    ViewBag.TotalPages = Math.Ceiling((double)kqtimkiem.Count / pagesize);
                    return View(kqtimkiem.Skip((page - 1) * pagesize).Take(pagesize));
                }

                public ActionResult ketquatimkiemdanhmuc(string id, int page = 1)
                {
                    string chuoitk = Request.QueryString["chuoitk"];
                    chuoitk = chuoitk.ToLower();
                    List<Sanpham_DTO> kqtimkiem = new List<Sanpham_DTO>();
                    List<Sanpham_DTO> lstspcungloai = dbsanpham.GetSpCungLoai(id).Where(x=> x.Sanphammoi ==1).ToList();
                    foreach (Sanpham_DTO item in lstspcungloai)
                    {
                        if (item.Tensanpham.ToLower().Contains(chuoitk) || item.Masanpham.Trim().ToLower().Contains(chuoitk))
                        {
                            kqtimkiem.Add(item);
                        }
                    }
                    ViewBag.tenloai = lstspcungloai.First().Loai.Tenloai;
                    ViewBag.Chuoi = chuoitk;
                    ViewBag.KhongTimThay = "Không tìm thấy";
                    ViewBag.TotalPages = Math.Ceiling((double)kqtimkiem.Count / pagesize);
                    return View(kqtimkiem.Skip((page - 1) * pagesize).Take(pagesize));
                }

                //
                // GET: /Admin/quanlysanpham/Details/5

                public ActionResult danhmuc(string id, int page=1)
                {
                    List<Sanpham_DTO> dsspcungloai = dbsanpham.GetSpCungLoai(id).Where(x=> x.Sanphammoi == 1).ToList();
                    ViewBag.tenloai = dsspcungloai.First().Loai.Tenloai;
                    ViewBag.TotalPages = Math.Ceiling((double)dsspcungloai.Count / pagesize);
                    ViewBag.maloai = id;
                    return View(dsspcungloai.Skip((page - 1) * pagesize).Take(pagesize));

                }

                //
                // GET: /Admin/quanlysanpham/Create

                private bool kiemtrasanpham(sanphamthem sp)
                {
                    if(dbsanpham.Find(sp.masanpham)!= null)
                            return false;
                    return true;
                }

               
                public void loaisanpham()
                {
                    List<SelectListItem> loaispList = new List<SelectListItem>();
                    dsloaisanpham();
                    foreach (Loaisanpham_DTO lsp in danhsachloaisanpham)
                    {
                        string maloai = lsp.Maloai.ToString();
                        string tenloai = lsp.Tenloai.ToString();
                        loaispList.Add(new SelectListItem { Text = tenloai, Value = maloai });
                    }
                    ViewBag.loaispList = loaispList;
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
                        tenloai ="daychuyen";
                    }
                    else if (maloai.Contains("L"))
                    {
                        tenloai ="lac";
                    }
                    else if (maloai.Contains("M"))
                    {
                        tenloai ="matday";
                    }
                    else if (maloai.Contains("N"))
                    {
                        tenloai ="nhan";
                    }
                    else tenloai ="vong";
                    return tenloai;
                }

                
                [HttpGet]
                public ActionResult themsanpham()
                {
                    loaisanpham();
                    return View();
                }

              
                //
                // POST: /Admin/quanlysanpham/Create

                [HttpPost]
                public ActionResult themsanpham(HttpPostedFileBase file,sanphamthem sanphammoi, FormCollection form)
                {
                    if (ModelState.IsValid)
                    {
                        sanphammoi.maloai = form["loai"];
                        if (kiemtrasanpham(sanphammoi))
                        {
                            if (file != null && file.ContentLength > 0)
                            {
                                Sanpham_DTO sp = new Sanpham_DTO();
                                sp.Masanpham = sanphammoi.masanpham;
                                sp.Tensanpham = sanphammoi.tensanpham;
                                sp.Giasanpham = sanphammoi.giasanpham;
                                sp.Chatlieu = sanphammoi.chatlieu;
                                sp.Loai = dbsanpham.GetLoaisp(sanphammoi.maloai);
                                string hinhanh = file.FileName.ToString();
                                string tenloai = laytenloai(sanphammoi.maloai);
                                string url = "image/" + tenloai + "/" + hinhanh;
                                //extract only the fielname
                                var fileName = Path.GetFileName(file.FileName);
                                // store the file inside ~/App_Data/uploads folder
                                var path = Path.Combine(Server.MapPath("~/image/" + tenloai + "/"), fileName);
                                file.SaveAs(path);
                                sp.Hinhanh = url;
                                dbsanpham.Insert(sp);
                                return RedirectToAction("Index", "quanlysanpham");
                            }
                            else
                            {
                                loaisanpham();
                                ViewBag.hinhanh = "Chưa chọn hình ảnh";
                                return View();
                            }
                        }
                        else
                        {
                            loaisanpham();
                            ViewBag.thatbai = "Trùng mã sản phẩm";
                            return View();
                        }
                    }
                    loaisanpham();
                    return View(sanphammoi);
                }
        
 
                public ActionResult suathongtin()
                {
                    string id = Request.QueryString["masp"];
                    Sanpham_DTO sanphamsua = dbsanpham.Find(id);
                    sanphamsua sp = new sanphamsua();
                    sp.masanpham = sanphamsua.Masanpham;
                    sp.tensanpham = sanphamsua.Tensanpham;
                    sp.giasanpham = sanphamsua.Giasanpham;
                    sp.chatlieu = sanphamsua.Chatlieu;
                    sp.sanphammoi = sanphamsua.Sanphammoi;
                    sp.maloai = sanphamsua.Loai.Maloai;
                    ViewBag.tenloai = sanphamsua.Loai.Tenloai;
                    sp.hinhanh = sanphamsua.Hinhanh;
                    return View(sp);
                }


                [HttpPost]
                public ActionResult suathongtin(HttpPostedFileBase file, sanphamsua sanpham, FormCollection form)
                {

                    if(ModelState.IsValid)
                    {
                        string url;
                        Sanpham_DTO sp = new Sanpham_DTO();
                        sp.Masanpham = sanpham.masanpham;
                        sp.Tensanpham = sanpham.tensanpham;
                        sp.Giasanpham = sanpham.giasanpham;
                        sp.Chatlieu = sanpham.chatlieu;
                        sp.Loai = dbsanpham.GetLoaisp(sanpham.maloai);
                        string check = form["Tinhtrangsanpham"];
                        if (check == "Mới")
                        {
                            sp.Sanphammoi = 1;
                        }
                        else { sp.Sanphammoi = 0; }
                        if (file != null && file.ContentLength > 0)
                        {
                            string tenloai = laytenloai(sanpham.maloai);
                            string hinhanh = file.FileName.ToString();
                            url = "image/" + tenloai + "/" + hinhanh;
                            var fileName = Path.GetFileName(file.FileName);
                            var path = Path.Combine(Server.MapPath("~/image/" + tenloai + "/"), fileName);
                            file.SaveAs(path);
                        }
                        else
                        {
                            var result = dbsanpham.Find(sanpham.masanpham);
                            url = result.Hinhanh.ToString();
                        }

                        sp.Hinhanh = url;
                        dbsanpham.Update(sp);
                        return RedirectToAction("Index", "quanlysanpham");
                    }
                    else
                    {
                        ViewBag.tenloai = dbsanpham.GetLoaisp(sanpham.maloai).Tenloai;
                        return View(sanpham);
                    }
                }

                //
                // GET: /Admin/quanlysanpham/Delete/5

                public ActionResult xoasanpham()
                {
                    string id = Request.QueryString["masp"];
 
                    Sanpham_DTO sp = dbsanpham.Find(id);
                    dbsanpham.Delete(sp);
                    return RedirectToAction("Index", "quanlysanpham");
                }

                public ActionResult kichhoatsp()
                {
                    string id = Request.QueryString["masp"];
                    Sanpham_DTO sp = dbsanpham.Find(id);
                    dbsanpham.Kichhoat(sp);
                    return RedirectToAction("Index", "quanlysanpham");
                }
    }
}
