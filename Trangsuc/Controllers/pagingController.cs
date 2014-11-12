using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trangsuc.Controllers
{
    public class pagingController : Controller
    {
        //
        // GET: /paging/
        [ChildActionOnly]
        public ActionResult Index(int page=1,string currentpage=null,int totalpages=1)
        {   //dia chi trang hien tai
            ViewBag.currentpage = currentpage;
            //trang hien tai
            ViewBag.Page = page;
            //tong so trang
            ViewBag.TotalPages = totalpages;
            return PartialView();
        }

    }
}
