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
using System.Web.Helpers;

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
            var _nd = danhsachnguoidung.SingleOrDefault(x=>x.Username.Equals(nd.Username));
            if (_nd != null)
            {
                var passmahoa =_nd.Pass;
                //kiem tra pass
                var check = Crypto.VerifyHashedPassword(passmahoa, nd.Pass);
                return check;
            }
            else return false;
        }

        public void dsnguoidungan()
        {
            danhsachnguoidungan.Clear();
            danhsachnguoidungan = dbnguoidung.GetAllNguoidung().Where(x => x.Useran == true).ToList();
        }
        public bool kiemtradangnhapan(Nguoidung_DTO nd)
        {
           
            dsnguoidungan();
            var _nd = danhsachnguoidungan.SingleOrDefault(x => x.Username.Equals(nd.Username));
            if (_nd != null)
            {
                var passmahoa = _nd.Pass;

                var check = Crypto.VerifyHashedPassword(passmahoa, nd.Pass);
                return check;
            }
            else return false;
        }

        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DangNhap(dangnhap model, string returnUrl)
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
                    //ma hoa password
                    var passmahoa = Crypto.HashPassword(model.password);
                    Nguoidung_DTO nd = new Nguoidung_DTO();
                    nd.Username = model.username;
                    nd.Pass = passmahoa;
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

        [HttpPost]
        public ActionResult SuaThongTin(suathongtin nd_sua)
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
                                _nd_sua.Pass = Crypto.HashPassword(nd_sua.password);
                                dbnguoidung.Update(_nd_sua);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.saithongtin = "Mật khẩu cũ không hợp lệ";
                        return View(nd_sua);
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
            {
                string passrd;
                Random rd = new Random();
                //biến passrd sẽ nhận có giá trị ngẫu nhiên trong khoảng 100000 đến 999999
                passrd = rd.Next(100000, 999999).ToString();  
                user.Pass = Crypto.HashPassword(passrd);
                if (dbnguoidung.Update(user))
                {
                    string Email = user.Mail.Trim();
                    string chuoi = " TÀI KHOẢN VÀ MẬT KHẨU CỦA QUÝ KHÁCH:\n";
                    chuoi += "Username: " + user.Username + "\n";
                    chuoi += "Password: " + passrd + "\n";
                    chuoi += "Quý khách hãy đăng nhập và đổi mật khẩu lại.Chào quý khách.";
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
            }
            return RedirectToAction("Index", "home");
        }
        //Lich su mua hang cho khach hang
        ServiceReferenceHoadon.ServiceHoadonClient dbhoadon = new ServiceReferenceHoadon.ServiceHoadonClient();
        int pagesize = 10;
        public ActionResult lichsumuahang(int page = 1)
        {   //Lay makh va kiem tra don hang trong db
            string makh = Session["User"].ToString();
            ViewBag.ma = makh;
            var hoadon = dbhoadon.GetAllHoadon().Where(s => s.Nguoidung.Username.Equals(makh)).ToList();
            if (hoadon.Count > 0)
            {
                ViewBag.TotalPages = Math.Ceiling((double)hoadon.ToList().Count / pagesize);
                return View(hoadon.Skip((page - 1) * pagesize).Take(pagesize));
            }
            else { ViewBag.Thongbao = "Bạn chưa có đơn hàng nào."; return View(); }

        }
        //Xem chi tiet hoa don va  tinh tong tien
        public ActionResult chitietmuahang(int mahoadon)
        {
            var item = dbhoadon.GetChitietByMa(mahoadon);
            List<ServiceReferenceHoadon.Chitiethoadon_DTO> danhsachcthd = dbhoadon.GetChitietByMa(mahoadon).ToList();
            ViewBag.mahd = mahoadon;
            ViewBag.tongtien = danhsachcthd.FirstOrDefault().Hoadon.Tongtien;
            return View(danhsachcthd);
        }
    }
}
