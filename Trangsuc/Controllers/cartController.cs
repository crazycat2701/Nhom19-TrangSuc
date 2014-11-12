using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trangsuc.Models;
using System.Text.RegularExpressions;
using Trangsuc.ServiceReferenceTonkho;
using System.Net.Mail;
using System.Net;
namespace Trangsuc.Controllers
{
    public class cartController : Controller
    {
        ServiceReferenceSanpham.ServiceSanphamClient db = new ServiceReferenceSanpham.ServiceSanphamClient();
        ServiceReferenceNguoidung.ServiceNguoidungClient dbnguoidung = new ServiceReferenceNguoidung.ServiceNguoidungClient();
        ServiceTonkhoClient dbtonkho = new ServiceTonkhoClient();
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        public RedirectToRouteResult giohangthem(string masanpham, string soluong = "1")
        {
            Tonkho_DTO tk = dbtonkho.Find(masanpham);
            if (tk.Soluong > 0)
            {
                if (IsNumber(soluong))
                {
                    if (int.Parse(soluong) <= tk.Soluong)
                    {
                        if (int.Parse(soluong) < 1)
                        {
                            var item = db.Find(masanpham);
                            GetCart().AddItem(item.Masanpham, item.Tensanpham, item.Giasanpham, 1);
                        }
                        else
                        {
                            var item = db.Find(masanpham);
                            GetCart().AddItem(item.Masanpham, item.Tensanpham, item.Giasanpham, int.Parse(soluong));
                        }
                    }
                    else
                    {
                        var item = db.Find(masanpham);
                        GetCart().AddItem(item.Masanpham, item.Tensanpham, item.Giasanpham, tk.Soluong);
                    }
                }
                else
                {
                    var item = db.Find(masanpham);
                    GetCart().AddItem(item.Masanpham, item.Tensanpham, item.Giasanpham, 1);
                }
                return RedirectToAction("Index");
            }
            else {
                return RedirectToAction("Index","Home");
            }
           
        }

        public RedirectToRouteResult giohangxoa(string masanpham)
        {
            GetCart().RemoveLine(masanpham);
            return RedirectToAction("Index");
        }

       
        public RedirectToRouteResult capnhatsoluong(string masanpham, string soluong)
        {
            Tonkho_DTO tk = dbtonkho.Find(masanpham);
            if (IsNumber(soluong))
            {            
                    if (int.Parse(soluong) <= tk.Soluong)
                    {
                        if (int.Parse(soluong) < 1)
                            GetCart().capnhatsoluong(masanpham, 1);
                        else
                            GetCart().capnhatsoluong(masanpham, int.Parse(soluong));
                    }
                    else
                    {  
                        GetCart().capnhatsoluong(masanpham, tk.Soluong); 
                    }
               
            }
            else
            {            
                    GetCart().capnhatsoluong(masanpham, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToRouteResult xoahet()
        {
            GetCart().Clear();
            return RedirectToAction("Index");
        }

        [ChildActionOnly]
        public ActionResult menugiohang()
        {
            return PartialView(GetCart());
        }
        //Gán session["Cart"] cho giỏ hàng
        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }

        [ChildActionOnly]
        public ActionResult footergiohang()
        {
            return PartialView();
        }


  
        public void ngaythangnam()
        {
            int nam = DateTime.Now.Year;
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
            for (int i = nam; i <= nam + 1; i++)
            {
                string j = i.ToString();
                namList.Add(new SelectListItem { Text = j, Value = j });
            }
            ViewBag.ngay = ngayList;
            ViewBag.thang = thangList;
            ViewBag.nam = namList;
        }
        public ActionResult thanhtoangiohang()
        {
            if (GetCart().Lines.Count() > 0)
            {              
                    string username = (string)Session["User"];
                    var tt = GetCart().thongtinkh(username);
                        ViewBag.username = tt.Hoten;
                        ViewBag.sdt = tt.Sdt;
                        ViewBag.email = tt.Mail;
                        ViewBag.diachi = tt.Diachi;
                        ngaythangnam();
                        return View(GetCart());
            }
            return RedirectToAction("index");
        }

        //thanh toán giỏ hàng rồi gửi mail chi tiết đơn hàng cho khách hàng
        [HttpPost]
        public ActionResult thanhtoangiohang(FormCollection f)
        {

            Cart cart = GetCart();
            string name = Session["User"].ToString();
            ServiceReferenceNguoidung.Nguoidung_DTO user = new ServiceReferenceNguoidung.Nguoidung_DTO();
            user = dbnguoidung.GetNguoidungByUsername(name);

            string Email = user.Mail.Trim();
            string chuoi = " GIỎ HÀNG CỦA QUÝ KHÁCH\n";

            foreach (var item in cart.Lines)
            {
                chuoi += "Mã SP: " + item.masp + "\tTên SP: " + item.tensp + "\tSố lượng: " + item.Quantity + "\tGiá SP: " + item.giasanpham + "\n";
            }
            chuoi += "Tổng tiền:" + cart.tongtien() + "VND\n";
            chuoi += "Cám ơn quý khách đã chọn sản phẩm của công ty. Chúng tôi sẽ liên hệ sớm với quý khách.";
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("trangsucviet05@gmail.com");
            msg.To.Add(Email);
            msg.Subject = "Trangsucviet: GIỎ HÀNG CỦA QUÝ KHÁCH TẠI Trangsucviet.com.vn";
            msg.Body = chuoi;

            //cấu hình mail smtp
            #region SMTP
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("trangsucviet05@gmail.com", "seminarnhom05");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.Send(msg);
            #endregion

            int ngay = int.Parse(f["ngay"]);
            int thang = int.Parse(f["thang"]);
            int nam = int.Parse(f["nam"]);              
            DateTime ngaygiaohang = new DateTime(nam, thang, ngay);
               
            //Lưu hóa đơn hàng xuống csdl
            GetCart().save((string)Session["User"], f["diachi"], ngaygiaohang, f["sdt"]);

            //xóa danh sách sản phẩm có trong giỏ hàng
            GetCart().Clear();
            return RedirectToAction("Index", "home");
        }

     
        public ViewResult Index()
        {
            return View(GetCart());
        }
    }
}
