using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceTrangsuc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicePhieuxuat" in both code and config file together.
    public class ServicePhieuxuat : IServicePhieuxuat
    {
        ServiceSanpham sp = new ServiceSanpham();
        ServiceNguoidung nd = new ServiceNguoidung();
        dewEntities db = new dewEntities();
        List<Phieuxuat_DTO> lstpx = new List<Phieuxuat_DTO>();
        public List<Phieuxuat_DTO> GetAllphieuxuat()
        {
            var x = (from s in db.phieuxuats select s).ToList();
            foreach (var i in x)
            {
                lstpx.Add(new Phieuxuat_DTO
                {
                    Maphieuxuat = i.maphieuxuat,
                    Ngaylapphieu = i.ngaylap,
                    Tennguoilap = i.tennguoilap,
                    Trangthai = i.trangthai,
                    Tongtien = GetTongTien(i.maphieuxuat)
                });
            }
            return lstpx;
        }

        public List<Chitietphieuxuat_DTO> GetChitietByMa(string maphieuxuat)
        {
            List<Chitietphieuxuat_DTO> lstctpx = new List<Chitietphieuxuat_DTO>();
            List<chitietphieuxuat> _lstctpx = (db.chitietphieuxuats.Where(x => x.maphieuxuat.Equals(maphieuxuat))).ToList();
            foreach (var i in _lstctpx)
            {
                Sanpham_DTO _sanpham = sp.Find(i.masanpham);
                lstctpx.Add(new Chitietphieuxuat_DTO
                {
                    ID = 0,
                    Phieuxuat = GetphieuxuatByMa(i.maphieuxuat),
                    Sanpham = _sanpham,
                    Soluong = i.soluong,
                    Thanhtien = (_sanpham.Giasanpham * i.soluong),
                    Masanpham = i.masanpham
                });
            }
            return lstctpx;
        }

        public Phieuxuat_DTO GetphieuxuatByMa(string maphieuxuat)
        {
            Phieuxuat_DTO px = new Phieuxuat_DTO();
            var s = db.phieuxuats.SingleOrDefault(x => x.maphieuxuat.Equals(maphieuxuat));
            if (s != null)
            {
                px.Maphieuxuat = s.maphieuxuat;
                px.Ngaylapphieu = s.ngaylap;
                px.Trangthai = s.trangthai;
                px.Tennguoilap = s.tennguoilap;
                px.Tongtien = GetTongTien(s.maphieuxuat);
            }
            else
            {
                px = null;
            }
            return px;
        }

        private int GetTongTien(string maphieuxuat)
        {
            int tongtien = 0;
            var lst_ctpx = db.chitietphieuxuats.Where(x => x.maphieuxuat.Equals(maphieuxuat)).ToList();

            foreach (var i in lst_ctpx)
            {
                tongtien = tongtien + (i.soluong * sp.Find(i.masanpham).Giasanpham);
            }
            return tongtien;
        }

        public bool Insertphieuxuat(Phieuxuat_DTO px)
        {
            try
            {
                phieuxuat _px = new phieuxuat();
                _px.maphieuxuat = px.Maphieuxuat;
                _px.tennguoilap = px.Tennguoilap;
                _px.ngaylap = px.Ngaylapphieu;
                _px.trangthai = px.Trangthai;
                db.phieuxuats.Add(_px);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Updatephieuxuat(Phieuxuat_DTO px)
        {
            try
            {
                phieuxuat _px = db.phieuxuats.SingleOrDefault(x => x.maphieuxuat.Equals(px.Maphieuxuat));
                _px.tennguoilap = px.Tennguoilap;
                _px.ngaylap = px.Ngaylapphieu;
                _px.trangthai = px.Trangthai;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InsertChitiet(Chitietphieuxuat_DTO ctpx)
        {
            try
            {
                chitietphieuxuat _ctpx = new chitietphieuxuat();
                _ctpx.maphieuxuat = ctpx.Phieuxuat.Maphieuxuat;
                _ctpx.masanpham = ctpx.Sanpham.Masanpham;
                _ctpx.soluong = ctpx.Soluong;
                db.chitietphieuxuats.Add(_ctpx);
                db.SaveChanges();
                return true;
            }
            catch { return false; }
        }


        public bool UpdateChitiet(Chitietphieuxuat_DTO ctpx)
        {
            try
            {
                chitietphieuxuat _ctpx = db.chitietphieuxuats.SingleOrDefault(x => x.maphieuxuat.Equals(ctpx.Phieuxuat.Maphieuxuat)
                                                                           && x.masanpham.Trim().Contains(ctpx.Masanpham.Trim()));
                _ctpx.soluong = ctpx.Soluong;
                db.SaveChanges();
                return true;
            }
            catch { return false; }
        }


        public bool DeleteChitiet(Chitietphieuxuat_DTO ctpx)
        {
            try
            {
                chitietphieuxuat _ctpx = db.chitietphieuxuats.SingleOrDefault(x => x.maphieuxuat.Equals(ctpx.Phieuxuat.Maphieuxuat)
                                                                           && x.masanpham.Trim().Contains(ctpx.Masanpham.Trim()));
                db.chitietphieuxuats.Remove(_ctpx);
                db.SaveChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
