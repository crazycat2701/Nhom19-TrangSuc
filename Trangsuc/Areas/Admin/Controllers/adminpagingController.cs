using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trangsuc.Areas.Admin.Controllers
{
    public class adminpagingController : Controller
    {
        //
        // GET: /Admin/paging/

        [ChildActionOnly]
        public ActionResult Index(int page = 1, string currentpage = null, int totalpages = 1)
        {
            ViewBag.currentpage = currentpage;
            ViewBag.Page = page;
            ViewBag.TotalPages = totalpages;
            return PartialView();
        }
    }
}
