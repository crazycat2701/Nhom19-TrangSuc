using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Trangsuc.Models;
using Trangsuc.ServiceReferenceAdmin;
namespace Trangsuc.Areas.Admin.Controllers
{
    public class dangnhapController : Controller
    {
        ServiceAdminClient db = new ServiceAdminClient();
        List<admin> danhsachadmin = new List<admin>();

        private void dsadmin()
        {
            danhsachadmin.Clear();
            danhsachadmin = db.GetAdmin().ToList() ;
        }

        public bool kiemtradangnhap(admin ad)
        {
            dsadmin();
            foreach (admin item in danhsachadmin)
            {
                if (item.username.Equals(ad.username) && item.password.Equals(ad.password))
                    return true;
            }
            return false;
        }
        
        public ActionResult Index()
        {
            return View();

        }

        //
        // POST: /Account/LogOn

        [HttpPost]
        public ActionResult Index(admindangnhap model, string returnUrl)
        {
            try
            {
                admin ad = new admin();
                ad.username = model.username;
                ad.password = model.password;
                bool _remember = model.remember;
                bool userValid = kiemtradangnhap(ad);
                if (userValid)
                {
                    Session["Admin"] = ad.username;
                    Session["User"] = null;
                    FormsAuthentication.SetAuthCookie(ad.username, _remember);
                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                        && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Index");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Sai tên hoặc mật khẩu đăng nhập");
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Thoat()
        {
            Session["Admin"] = null;
            return RedirectToAction("index", "dangnhap");
        }
    }
}