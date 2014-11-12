using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace WcfServiceTrangsuc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceHoadon" in both code and config file together.
    public class ServiceHoadon : IServiceHoadon
    {
        ServiceSanpham sp = new ServiceSanpham();
        ServiceNguoidung nd = new ServiceNguoidung();
        dewEntities db = new dewEntities();
        List<Hoadon_DTO> lsthd = new List<Hoadon_DTO>();
 
        public List<Hoadon_DTO> GetAllHoadon()
        {
            lsthd.Clear();
            List<hoadon> _lsthd = db.hoadons.ToList();
            foreach (var i in _lsthd)
            {
                lsthd.Add(new Hoadon_DTO
                { 
                    Id = 0,
                    Mahoadon = i.mahoadon,
                    Nguoidung = nd.GetNguoidungByUsername(i.nguoidung.username),
                    Sdt = i.sdt,
                    Diadiemgiaohang = i.diadiemgiaohang,
                    Trangthai = i.trangthai,
                    Ngaymuahang = i.ngaymuahang,
                    Ngaygiaohang = i.ngaygiaohang,
                    Tongtien = GetTongTien(i.mahoadon)
                });
            }
            return lsthd;
        }
        public List<Chitiethoadon_DTO> GetChitietByMa(int mahoadon)
        {
            List<Chitiethoadon_DTO> lstcthd = new List<Chitiethoadon_DTO>();
            List<chitiethoadon> _lstcthd = db.chitiethoadons.Where(x => x.mahoadon == mahoadon).ToList();
            foreach (var i in _lstcthd)
            {
                lstcthd.Add(new Chitiethoadon_DTO { Hoadon = GetHoadonByMa(i.mahoadon), Sanpham = sp.Find(i.masanpham),Masanpham = i.masanpham, Soluong = i.soluong, Giasanpham = i.giasanpham});
            }
            return lstcthd;
        }

        public int InsertHoadon(string tendangnhap, string diadiemgiaohang,DateTime Ngaygiaohang,string sdt)
        {
            try
            {
                hoadon _hd = new hoadon();
                _hd.mahoadon = db.hoadons.Count() + 1;
                _hd.tendangnhap = tendangnhap;
                _hd.sdt = sdt;
                _hd.ngaymuahang = DateTime.Now;
                _hd.diadiemgiaohang = diadiemgiaohang;
                _hd.ngaygiaohang = Ngaygiaohang;
                _hd.trangthai = "Mới";

                db.hoadons.Add(_hd);
                db.SaveChanges();
                
                return _hd.mahoadon;
            }
            catch
            {
                return 0;
            }
        }
 
        public bool UpdateHoadon(Hoadon_DTO hd)
        {
            try
            {
                hoadon _hd = db.hoadons.SingleOrDefault(x=>x.mahoadon== hd.Mahoadon);
                _hd.diadiemgiaohang = hd.Diadiemgiaohang;
                _hd.trangthai = hd.Trangthai;
                _hd.ngaygiaohang = hd.Ngaygiaohang;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InsertChitiet(int mahd,string masp,int soluong,int giasanpham)
        {
            try
            {
                chitiethoadon _cthd = new chitiethoadon();
                    _cthd.mahoadon = mahd;
                    _cthd.masanpham = masp.Trim();
                    _cthd.soluong = soluong;
                    _cthd.giasanpham = giasanpham;
                    db.chitiethoadons.Add(_cthd);
                    db.SaveChanges();
                    return true;
            }
            catch
            {
                return false;
            }
        }

        public Hoadon_DTO GetHoadonByMa(int mahoadon)
        {
            Hoadon_DTO hd = new Hoadon_DTO();
            var s = db.hoadons.SingleOrDefault(x => x.mahoadon == mahoadon);
            if (s != null)
            {
                hd.Mahoadon = s.mahoadon;
                hd.Nguoidung = nd.GetNguoidungByUsername(s.nguoidung.username);
                hd.Sdt = s.sdt;
                hd.Ngaymuahang = s.ngaymuahang;
                hd.Ngaygiaohang = s.ngaygiaohang;
                hd.Trangthai = s.trangthai;
                hd.Diadiemgiaohang = s.diadiemgiaohang;
                hd.Tongtien = GetTongTien(s.mahoadon);
            }
            else
            {
                hd = null;   
            }
            return hd;
        }

        public int GetTongTien(int mahoadon)
        {
            int tongtien =0;
            var lst_cthd = db.chitiethoadons.Where(x => x.mahoadon == mahoadon).ToList();

            foreach(var i in lst_cthd)
            {
                tongtien = tongtien + (i.soluong * i.giasanpham);
            }
            return tongtien;
        }

        public List<Chitiethoadon_DTO> GetAllChitiet()
        {
            List<Chitiethoadon_DTO> lstcthd = new List<Chitiethoadon_DTO>();
            List<chitiethoadon> _lstcthd = db.chitiethoadons.ToList();
            foreach (var i in _lstcthd)
            {
                lstcthd.Add(new Chitiethoadon_DTO {Hoadon = GetHoadonByMa(i.mahoadon),Sanpham = sp.Find(i.masanpham),Soluong= i.soluong, Giasanpham = i.giasanpham ,Masanpham = i.masanpham});
            }
            return lstcthd;
        }
    }
}
