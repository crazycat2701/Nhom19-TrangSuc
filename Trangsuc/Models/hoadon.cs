using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data;
namespace Trangsuc.Models
{
    
    public class hoadonsua
    {
        public int mahoadon { get; set; }
        public string username { get; set; }
        public string tenkhachhang { get; set; }
        public string email { get; set; }
        public string sdt { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập địa chỉ giao hàng")]
        [Display(Name = "Địa chỉ giao hàng")]
        public string diachigiaohang { get; set; }
        public int tongtien { get; set; }
        public DateTime ngaydathang { get; set; }
        public string ghichu { get; set; }
        public string tinhtrang { get; set; }
    }
}