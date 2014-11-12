using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceTrangsuc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicePhieunhap" in both code and config file together.
    public class ServicePhieunhap : IServicePhieunhap
    {
        ServiceSanpham sp = new ServiceSanpham();
        ServiceNguoidung nd = new ServiceNguoidung();
        dewEntities db = new dewEntities();
        List<Phieunhap_DTO> lstpn = new List<Phieunhap_DTO>();
        public List<Phieunhap_DTO> GetAllPhieunhap()
        {
            var x = (from s in db.phieunhaps select s).ToList();
            foreach (var i in x) 
            {
                lstpn.Add(new Phieunhap_DTO {Maphieunhap = i.maphieunhap, Ngaylapphieu = i.ngaylap,
                    Tennguoilap = i.tennguoilap,Trangthai = i.trangthai, Tongtien = GetTongTien(i.maphieunhap)});
            }
            return lstpn;
        }
        
        public List<Chitietphieunhap_DTO> GetChitietByMa(string maphieunhap)
        {
            List<Chitietphieunhap_DTO> lstctpn = new List<Chitietphieunhap_DTO>();
            List<chitietphieunhap> _lstctpn = (db.chitietphieunhaps.Where(x=> x.maphieunhap.Equals(maphieunhap))).ToList();
            foreach (var i in _lstctpn)
            {
                Sanpham_DTO _sanpham = sp.Find(i.masanpham);
                lstctpn.Add(new Chitietphieunhap_DTO { ID = 0,Phieunhap = GetPhieunhapByMa(i.maphieunhap), Sanpham = _sanpham  , Soluong = i.soluong ,
                                                       Thanhtien = (_sanpham.Giasanpham * i.soluong), Masanpham = i.masanpham});
            }
            return lstctpn;
        }

        public Phieunhap_DTO GetPhieunhapByMa(string maphieunhap)
        {
            Phieunhap_DTO pn = new Phieunhap_DTO();
            var s = db.phieunhaps.SingleOrDefault(x=> x.maphieunhap.Equals(maphieunhap));
            if (s != null)
            {
                pn.Maphieunhap = s.maphieunhap;       
                pn.Ngaylapphieu = s.ngaylap;             
                pn.Trangthai = s.trangthai;
                pn.Tennguoilap = s.tennguoilap;
                pn.Tongtien = GetTongTien(s.maphieunhap);
            }
            else
            {
                pn = null;
            }
            return pn;
        }

        private int GetTongTien(string maphieunhap)
        {
            int tongtien = 0;
            var lst_ctpn = db.chitietphieunhaps.Where(x => x.maphieunhap.Equals(maphieunhap)).ToList();

            foreach (var i in lst_ctpn)
            {
                tongtien = tongtien + (i.soluong * sp.Find(i.masanpham).Giasanpham);
            }
            return tongtien;
        }

        public bool InsertPhieunhap(Phieunhap_DTO pn)
        {
            try {
                phieunhap _pn = new phieunhap();
                _pn.maphieunhap = pn.Maphieunhap;
                _pn.tennguoilap = pn.Tennguoilap;
                _pn.ngaylap = pn.Ngaylapphieu;
                _pn.trangthai = pn.Trangthai;
                db.phieunhaps.Add(_pn);
                db.SaveChanges();
                    return true;
            }
            catch { 
                return false;
            }
        }

        public bool UpdatePhieunhap(Phieunhap_DTO pn)
        {
            try
            {
                phieunhap _pn = db.phieunhaps.SingleOrDefault(x=> x.maphieunhap.Equals(pn.Maphieunhap));
                _pn.tennguoilap = pn.Tennguoilap;
                _pn.ngaylap = pn.Ngaylapphieu;
                _pn.trangthai = pn.Trangthai;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InsertChitiet(Chitietphieunhap_DTO ctpn)
        {
            try
            {
                chitietphieunhap _ctpn = new chitietphieunhap();
                _ctpn.maphieunhap = ctpn.Phieunhap.Maphieunhap;
                _ctpn.masanpham = ctpn.Sanpham.Masanpham;
                _ctpn.soluong = ctpn.Soluong;
                db.chitietphieunhaps.Add(_ctpn);
                db.SaveChanges();
                return true;
            }
            catch { return false; }
        }


        public bool UpdateChitiet(Chitietphieunhap_DTO ctpn)
        {
            try
            {
                chitietphieunhap _ctpn = db.chitietphieunhaps.SingleOrDefault(x => x.maphieunhap.Equals(ctpn.Phieunhap.Maphieunhap)
                                                                           && x.masanpham.Trim().Contains(ctpn.Masanpham.Trim()));
                _ctpn.soluong = ctpn.Soluong;
                db.SaveChanges();
                return true;
            }
            catch { return false; }
        }


        public bool DeleteChitiet(Chitietphieunhap_DTO ctpn)
        {
            try {
                chitietphieunhap _ctpn = db.chitietphieunhaps.SingleOrDefault(x => x.maphieunhap.Equals(ctpn.Phieunhap.Maphieunhap)
                                                                           && x.masanpham.Trim().Contains(ctpn.Masanpham.Trim()));
                db.chitietphieunhaps.Remove(_ctpn);
                db.SaveChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
