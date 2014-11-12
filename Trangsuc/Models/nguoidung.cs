using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Data;

namespace Trangsuc.Models
{
   
    public class dangky
    {
        [Required(ErrorMessage = "Bạn chưa nhập tên đăng nhập")]
        [StringLength(40, ErrorMessage = "Độ dài {0} không quá 40 ký tự .")]
        [Display(Name = "Tên đăng nhập")]
        public string username { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập mật khẩu.")]
        [StringLength(100, ErrorMessage = "Độ dài {0} ít nhất {2} ký tự.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string password { get; set; }

        [Required(ErrorMessage = "Bạn chưa xác thực lại mật khẩu.")]
        [DataType(DataType.Password)]
        [Display(Name = "Nhập lại mật khẩu")]
        [Compare("password", ErrorMessage = "Mật khẩu xác nhận không đúng. Mời nhập lại.")]
        public string xacnhanmatkhau { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập họ và tên.")]
        [StringLength(40, ErrorMessage = "Độ dài {0} không quá 40 ký tự .")]
        [Display(Name = "Họ tên")]
        public string hoten { get; set; }

        [Display(Name = "Ngày sinh")]
        public DateTime ngaysinh { get; set; }

        [Display(Name = "Giới tính")]
        public bool gioitinh { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập số điện thoại.")]
        [RegularExpression(@"[0-9]+[0-9]", ErrorMessage = "Số điện thoại nhập chưa hợp lệ.")]
        [Display(Name = "Số điện thoại")]
        public string sdt { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập địa chỉ.")]
        [Display(Name = "Địa chỉ")]
        public string diachi { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập địa chỉ email.")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email nhập chưa hợp lệ.")]
        [Display(Name = "Địa chỉ email")]
        public string email { get; set; }
    }

    public class dangnhap
    {
        [Display(Name = "Tên truy cập")]
        public string username { get; set; }

        [Display(Name = "Mật khẩu")]
        public string password { get; set; }

        [Display(Name = "Ghi nhớ")]
        public bool remember { get; set; }
    }

    public class suathongtin
    {
        public string username { get; set; }
        public string hoten { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập số điện thoại.")]
        [RegularExpression(@"[0-9]+[0-9]", ErrorMessage = "Số điện thoại nhập chưa hợp lệ.")]
        [Display(Name = "Số điện thoại")]
        public string sdt { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập địa chỉ email.")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email nhập chưa hợp lệ.")]
        [Display(Name = "Địa chỉ email")]
        public string email { get; set; }
        
        [Required(ErrorMessage = "Bạn chưa nhập mật khẩu hiện tại.")]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu hiện tại")]
        public string passwordcu { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập mật khẩu.")]
        [StringLength(100, ErrorMessage = "Độ dài {0} ít nhất {2} ký tự.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu mới")]
        public string password { get; set; }

        [Required(ErrorMessage = "Bạn chưa xác thực lại mật khẩu.")]
        [DataType(DataType.Password)]
        [Display(Name = "Nhập lại mật khẩu mới")]
        [Compare("password", ErrorMessage = "Mật khẩu xác nhận không đúng.")]
        public string xacnhanmatkhau { get; set; }
    }
}