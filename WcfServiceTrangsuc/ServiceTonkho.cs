using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceTrangsuc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceTonkho : IServiceTonkho
    {
        dewEntities db = new dewEntities();
        ServiceSanpham sp = new ServiceSanpham();
        List<Tonkho_DTO> listtk = new List<Tonkho_DTO>();
        //Lấy danh sách tồn kho theo ngày và loại sản phẩm
        public List<Tonkho_DTO> GetAllTonkho(string maloai,DateTime ngay)
        {
            try
            {
                List<Sanpham_DTO> listsp = sp.GetSpCungLoai(maloai);
                foreach (var i in listsp)
                {
                    //sắp xếp danh sách tồn kho theo ngày rồi chọn sản phẩm đầu tiên thỏa điều kiện 
                    tonkho tk = db.tonkhoes.OrderByDescending(x => x.ngay).FirstOrDefault(x => x.ngay <= ngay &&
                        x.masanpham.Trim().Contains(i.Masanpham.Trim()) );
                    listtk.Add(new Tonkho_DTO { Ngay = tk.ngay, Soluong = tk.soluong,Sptonkho= sp.Find(tk.masanpham) });
                }
                return listtk;
            }
            catch { return null; }
        }

        //Tìm số lượng tồn kho của sản phẩm bất kỳ theo mã sản phẩm
        public Tonkho_DTO Find(string masp)
        {
            //tìm số lượng tồn kho mới nhất của sản phẩm
            tonkho tk = db.tonkhoes.OrderByDescending(x => x.ngay).FirstOrDefault(x => x.masanpham.Trim().Contains(masp.Trim()));
            Tonkho_DTO _tk = new Tonkho_DTO();
            _tk.Ngay = tk.ngay;
            _tk.Soluong = tk.soluong;
            _tk.Sptonkho = sp.Find(masp);
            return _tk;
        }

        //public List<Tonkho_DTO> GetAllTonkhoByDay(DateTime ngay)
        //{
        //    List<Sanpham_DTO> listsp = sp.GetAllSp();
        //    foreach (var i in listsp)
        //    {
        //        tonkho tk = db.tonkhoes.OrderByDescending(x => x.ngay).FirstOrDefault(x => x.masanpham.Trim().Contains(i.Masanpham.Trim())
        //            && x.ngay <= ngay);
        //       // listtk.Add(new Tonkho_DTO { Ngay = tk.ngay, Soluong = tk.soluong, Sptonkho = sp.Find(tk.masanpham) });
        //    }
        //    return listtk;
        //}

        //Nhập sản phẩm vào kho
        public bool NhapKho(Chitietphieunhap_DTO ctpn)
        {
            try
            {
                //tìm số lượng tồn kho mới nhất của sản phẩm trong chitietphieunhap
                tonkho tk = db.tonkhoes.OrderByDescending(x=>x.ngay).FirstOrDefault(x => x.masanpham.Trim().Contains(ctpn.Masanpham.Trim()));
                tonkho _tk = new tonkho();
                _tk.ngay = DateTime.Now;
                _tk.masanpham = tk.masanpham;
                _tk.soluong = tk.soluong + ctpn.Soluong;
                db.tonkhoes.Add(_tk);
                db.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        
        //Xuất kho
        public bool XuatKho(Chitietphieuxuat_DTO ctpx)
        {
            try
            {
                //tìm số lượng tồn kho mới nhất của sản phẩm trong chitiethoadon
                tonkho tk = db.tonkhoes.OrderByDescending(x => x.ngay).FirstOrDefault(x => x.masanpham.Trim().Contains(ctpx.Masanpham.Trim()));
                tonkho _tk = new tonkho();
                _tk.ngay = DateTime.Now;
                _tk.masanpham = tk.masanpham;
                _tk.soluong = tk.soluong - ctpx.Soluong;
                db.tonkhoes.Add(_tk);
                db.SaveChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
