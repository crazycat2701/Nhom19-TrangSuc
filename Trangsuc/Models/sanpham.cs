using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Trangsuc.Models
{
    //Validation cho trang them san pham
    public class sanphamthem
    {
        [Required(ErrorMessage = "Bạn chưa nhập mã sản phẩm")]
        [Display(Name = "Mã sản phẩm")]
        public string masanpham { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập tên sản phẩm")]
        [Display(Name = "Tên sản phẩm")]
        public string tensanpham { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập chất liệu sản phẩm")]
        [Display(Name = "Chất liệu")]
        public string chatlieu { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập giá sản phẩm")]
        [RegularExpression(@"[0-9]+[0-9]", ErrorMessage = "Giá sản phẩm chưa hợp lệ.")]
        [Display(Name = "Giá sản phẩm")]
        public int giasanpham { get; set; }

        public string hinhanh { get; set; }
        public string maloai { get; set; }

    }
    //Validation cho trang sua san pham
    public class sanphamsua
    {
        public string masanpham { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập tên sản phẩm")]
        [Display(Name = "Tên sản phẩm")]
        public string tensanpham { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập chất liệu sản phẩm")]
        [Display(Name = "Chất liệu")]
        public string chatlieu { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập giá sản phẩm")]
        [RegularExpression(@"[0-9]+[0-9]" + ".00", ErrorMessage = "Giá sản phẩm chưa hợp lệ.")]
        [Display(Name = "Giá sản phẩm")]
        public int giasanpham { get; set; }

        
        [Display(Name = "Hình ảnh")]
        public string hinhanh { get; set; }
        public int sanphammoi { get; set; }
        public string maloai { get; set; }
    }
}