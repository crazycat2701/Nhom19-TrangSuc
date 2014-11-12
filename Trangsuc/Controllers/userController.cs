using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trangsuc.ServiceReferenceNguoidung;
using Trangsuc.Models;
using System.Web.Security;
using System.Web.Routing;
using System.Net.Mail;
using System.Net;

namespace Trangsuc.Controllers
{
    public class userController : Controller
    {
        //
        // GET: /user/
        ServiceNguoidungClient dbnguoidung = new ServiceNguoidungClient();
        public List<Nguoidung_DTO> danhsachnguoidung = new List<Nguoidung_DTO>();
        public List<Nguoidung_DTO> danhsachnguoidungan = new List<Nguoidung_DTO>();

        public void dsnguoidung()
        {
            danhsachnguoidung.Clear();
            danhsachnguoidung = dbnguoidung.GetAllNguoidung().Where(x => x.Useran == false).ToList();
        }

        public bool kiemtranguoidung(Nguoidung_DTO nd)
        {
            Nguoidung_DTO kt = dbnguoidung.GetNguoidungByUsername(nd.Username);
            if (kt != null)
            {
                return false;
            }
            else return true;
        }

        public bool kiemtradangnhap(Nguoidung_DTO nd)
        {
            dsnguoidung();
            foreach (Nguoidung_DTO item in danhsachnguoidung)
            {
                if (item.Username.Equals(nd.Username) && item.Pass.Equals(nd.Pass))
                    return true;
            }
            return false;
        }

        public void dsnguoidungan()
        {
            danhsachnguoidungan.Clear();
            danhsachnguoidungan = dbnguoidung.GetAllNguoidung().Where(x => x.Useran == true).ToList();
        }
        public bool kiemtradangnhapan(Nguoidung_DTO nd)
        {
            dsnguoidungan();
            foreach (Nguoidung_DTO item in danhsachnguoidungan)
            {
                if (item.Username.Equals(nd.Username) && item.Pass.Equals(nd.Pass))
                    return true;
            }
            return false;
        }

        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DangNhap(dangnhap model, string returnUrl)
        {
            try
            {
                Nguoidung_DTO nd = new Nguoidung_DTO();
                nd.Username = model.username;
                nd.Pass = model.password;
                bool _remember = model.remember;
                bool userValid = kiemtradangnhap(nd);
                    if (userValid)
                    {
                        Session["User"] = nd.Username;
                        Session["Admin"] = null;
                        FormsAuthentication.SetAuthCookie(nd.Username,_remember);
                        if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                            && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                        {
                            return Redirect(returnUrl);
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home");
                        }        
                    }    
                    else
                    {
                        bool useranValid = kiemtradangnhapan(nd);
                        // nếu người dùng ẩn thì không cho đăng nhập
                        if (useranValid)
                        {
                            ModelState.AddModelError("", "Tài khoản đã bị khóa. Mọi thắc mắc vui lòng liên hệ ban quản trị.");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Sai tên hoặc mật khẩu đăng nhập");
                        }
                        return View();
                    }    
            }
            catch
            {
                return View();
            }
        }

        public ActionResult DangXuat()
        {
            Session["User"] = null;
            Session["Cart"] = null;
            return RedirectToAction("Index", "Home");
        }

        bool kiemtranamnhuan(int nam)
        {
            if (nam % 4 == 0 && nam % 100 != 0)
                return true;
            return false;
        }

        bool kiemtrangaysinh(int ngay, int thang, int nam)
        {
            int ngaynhuan = 0;
            if (thang == 2)
            {
                if (kiemtranamnhuan(nam))
                    ngaynhuan = 29;
                else
                    ngaynhuan = 28;
                if (ngay > ngaynhuan)
                {
                    return false;
                }
            }
            else
                if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
                    if (ngay > 30)
                        return false;
            return true;
        }

        public void ngaythangnam()
        {
            int namtu = DateTime.Now.Year - 65;
            int namden = DateTime.Now.Year - 16;
            List<SelectListItem> ngayList = new List<SelectListItem>();
            List<SelectListItem> thangList = new List<SelectListItem>();
            List<SelectListItem> namList = new List<SelectListItem>();
            for (int i = 1; i <= 31; i++)
            {
                string j = i.ToString();
                ngayList.Add(new SelectListItem { Text = j, Value = j });
            }
            for (int i = 1; i <= 12; i++)
            {
                string j = i.ToString();
                thangList.Add(new SelectListItem { Text = j, Value = j });
            }
            for (int i = namtu; i <= namden; i++)
            {
                string j = i.ToString();
                namList.Add(new SelectListItem { Text = j, Value = j });
            }
            ViewBag.ngay = ngayList;
            ViewBag.thang = thangList;
            ViewBag.nam = namList;
        }

        [HttpGet]
        public ActionResult DangKy()
        {
            ngaythangnam();
            return View();
        }

        [HttpPost]
        public ActionResult DangKy(dangky model, FormCollection form)
        {
            int gt = int.Parse(form["gioitinh"].ToString());
            int ngay = int.Parse(form["ngay"]);
            int thang = int.Parse(form["thang"]);
            int nam = int.Parse(form["nam"]);
            if (kiemtrangaysinh(ngay, thang, nam))
            {
                DateTime ns = new DateTime(nam, thang, ngay);
                try
                {
                    Nguoidung_DTO nd = new Nguoidung_DTO();
                    nd.Username = model.username;
                    nd.Pass = model.password;
                    nd.Hoten = model.hoten;
                    nd.Ngaysinh = ns;
                    nd.Sdt = model.sdt;
                    nd.Diachi = model.diachi;
                    nd.Mail = model.email;
                    nd.Gioitinh =  gt;
                    if (kiemtranguoidung(nd))
                    {
                       if(dbnguoidung.Insert(nd))
                       {
                            ViewBag.thanhcong = "Đăng ký thành công!";
                        }
                       else
                        {
                             
                            ViewBag.thanhcong = null;
                            ViewBag.thatbai = "Dang ky that bai";
                        }                       
                    }
                    else
                    {                      
                        ViewBag.thanhcong = null;
                        ViewBag.thatbai = "Tên đăng nhập đã tồn tại!";
                    }
                    ngaythangnam();
                    return View();
                }
                catch
                {
                    ngaythangnam();
                    ViewBag.thatbai = "Dang ky that bai tai catch";
                    return View();
                }
            }
            else
            {
                ngaythangnam();
                ViewBag.loi = "Ngày sinh không hợp lệ!";
                return View();
            }
        }


        public ActionResult SuaThongTin()
        {
            if (ModelState.IsValid)
            {
                if (Session["User"] == null)
                {
                    return View();
                }
                else
                {
                    string username = Session["User"].ToString();
                    Nguoidung_DTO nd = dbnguoidung.GetNguoidungByUsername(username);                  
                    suathongtin _sua = new suathongtin();
                    _sua.username = nd.Username;
                    _sua.hoten = nd.Hoten;
                    _sua.sdt = nd.Sdt;
                    _sua.email = nd.Mail;
                    _sua.password = null;
                    _sua.passwordcu = null;
                    _sua.xacnhanmatkhau = null;
                    return View(_sua);
                }
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult SuaThongTin(suathongtin nd_sua)
        {
            
            if (Session["User"].Equals(nd_sua.username))
            {
                if (nd_sua.password == null || !nd_sua.password.Equals(nd_sua.xacnhanmatkhau))
                {
                    ViewBag.saithongtin = "";
                    return View(nd_sua);
                }
                else
                {
                    Nguoidung_DTO _nd = new Nguoidung_DTO();
                    _nd.Username = nd_sua.username;
                    _nd.Pass = nd_sua.passwordcu;
                    bool userValid = kiemtradangnhap(_nd);
                    if (userValid)
                    {
                        Nguoidung_DTO _nd_sua = dbnguoidung.GetNguoidungByUsername(_nd.Username);                  
                                _nd_sua.Sdt = nd_sua.sdt;
                                _nd_sua.Mail = nd_sua.email;
                                _nd_sua.Pass = nd_sua.password;
                                dbnguoidung.Update(_nd_sua);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.saithongtin = "Mật khẩu cũ không hợp lệ";
                        return View(nd_sua);
                    }
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        // gủi mail mật khẩu cho khách hàng
        public ActionResult Quenmatkhau()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Quenmatkhau(FormCollection f)
        {
            string mail = f["mail"].ToString();
            ServiceReferenceNguoidung.Nguoidung_DTO user = new ServiceReferenceNguoidung.Nguoidung_DTO();
            user = dbnguoidung.GetAllNguoidung().SingleOrDefault(e=> e.Mail.Equals(mail));
            if(user !=null)
            {string Email = user.Mail.Trim();
            string chuoi = " TÀI KHOẢN VÀ MẬT KHẨU CỦA QUÝ KHÁCH:\n";
            chuoi += "Username: " + user.Username +"\n";
            chuoi += "Password: " + user.Pass + "\n";
            chuoi += "Chào quý khách.";
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("trangsucviet05@gmail.com");
            msg.To.Add(Email);
            msg.Subject = "Trangsucviet: Quên Mật Khẩu";
            msg.Body = chuoi;
            #region SMTP
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("trangsucviet05@gmail.com", "seminarnhom05");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.Send(msg);
            #endregion
            }
            return RedirectToAction("Index", "home");
        }
    }
}
