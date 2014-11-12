using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Trangsuc.Models
{
    
        public class admindangnhap
        {
            [Display(Name = "Tên truy cập")]
            public string username { get; set; }

            [Display(Name = "Mật khấu")]
            public string password { get; set; }

            [Display(Name = "Ghi nhớ")]
            public bool remember { get; set; }
        }
}