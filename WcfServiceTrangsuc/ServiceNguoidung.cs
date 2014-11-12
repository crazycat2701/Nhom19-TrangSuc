using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceTrangsuc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceNguoidung" in both code and config file together.
    public class ServiceNguoidung : IServiceNguoidung
    {
        dewEntities db = new dewEntities();
         List<Nguoidung_DTO> lst_user = new List<Nguoidung_DTO>();
        public List<Nguoidung_DTO> GetAllNguoidung()
        {
            lst_user.Clear();
            var s = from x in db.nguoidungs select x;
            foreach (var i in s)
            {
                lst_user.Add(new Nguoidung_DTO
                            {
                                Username = i.username,
                                Hoten = i.hoten,
                                Pass = i.password,
                                Ngaysinh = i.ngaysinh,
                                Gioitinh = i.gioitinh,
                                Sdt = i.sdt,
                                Diachi = i.diachi,
                                Mail = i.email,
                                Useran = i.useran,
                               Quyen = GetQuyen(i.maphanquyen)
                            }
                            );
            }
            return lst_user;
        }

        public Phanquyen_DTO GetQuyen(int quyen)
        {
            Phanquyen_DTO pg = new Phanquyen_DTO();
            var s = db.phanquyens.Single(x => x.maphanquyen == quyen);
            pg.Maphanquyen = s.maphanquyen;
            pg.Quyen = s.quyen;
            return pg;
        }

        public Nguoidung_DTO GetNguoidungByUsername(string username)
        {
            Nguoidung_DTO nd = new Nguoidung_DTO();
            var s = db.nguoidungs.SingleOrDefault(x=> x.username.Equals(username));
            if (s != null)
            {
                
                nd.Username = s.username;
                nd.Hoten = s.hoten;
                nd.Pass = s.password;
                nd.Ngaysinh = s.ngaysinh;
                nd.Gioitinh = s.gioitinh;
                nd.Sdt = s.sdt;
                nd.Diachi = s.diachi;
                nd.Mail = s.email;
                nd.Quyen = GetQuyen(s.maphanquyen);
                nd.Useran = s.useran;
                return nd;
            }
            else
            {
                nd = null;
                return nd;
            }
        }


        public bool Insert(Nguoidung_DTO nd)
        {
            try
            {
                nguoidung _nd = new nguoidung();
                _nd.username = nd.Username;
                _nd.hoten = nd.Hoten;
                _nd.password = nd.Pass;
                _nd.ngaysinh = nd.Ngaysinh;
                _nd.gioitinh = nd.Gioitinh;
                _nd.sdt = nd.Sdt;
                _nd.diachi = nd.Diachi;
                _nd.email = nd.Mail;
                _nd.useran = false;
                _nd.maphanquyen = GetQuyen(1).Maphanquyen;
                db.nguoidungs.Add(_nd);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool Update(Nguoidung_DTO nd)
        {
            try
            {
                nguoidung _nd = db.nguoidungs.Single(x=> x.username.Equals(nd.Username));
                _nd.hoten = nd.Hoten;
                _nd.password = nd.Pass;
                _nd.sdt = nd.Sdt;
                _nd.diachi = nd.Diachi;
                _nd.email = nd.Mail;
               
                _nd.maphanquyen = nd.Quyen.Maphanquyen;
                _nd.useran = nd.Useran;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public List<Phanquyen_DTO> GetAllQuyen()
        {
            List<Phanquyen_DTO> lstpq = new List<Phanquyen_DTO>();
            List<phanquyen> _lstpq = db.phanquyens.ToList();
            foreach (var i in _lstpq)
            {
                lstpq.Add(new Phanquyen_DTO { Maphanquyen = i.maphanquyen, Quyen = i.quyen });
            }
            return lstpq;
        }
    }
}
