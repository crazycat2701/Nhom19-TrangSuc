using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace WcfServiceTrangsuc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceSanpham : IServiceSanpham
    {
        dewEntities db = new dewEntities();
        List<Sanpham_DTO> listsp = new List<Sanpham_DTO>();
        public List<Sanpham_DTO> GetAllSp()
        {
            listsp.Clear();
            var s = from x in db.sanphams select x;
            foreach (var i in s)
            {
                 listsp.Add(
                     new Sanpham_DTO { 
                        Masanpham = i.masanpham, 
                        Tensanpham= i.tensanpham, 
                        Giasanpham= i.giasanpham,
                        Chatlieu=i.chatlieu, 
                        Sanphammoi= i.sanphammoi,
                        Hinhanh=i.hinhanh,
                        Loai = GetLoaisp(i.maloai) 
                                      }
                            );
                
            }
            return listsp;

        }

        public Loaisanpham_DTO GetLoaisp(string maloai)
        {
            Loaisanpham_DTO loaisp = new Loaisanpham_DTO();
            var _loaisp = db.loaisanphams.SingleOrDefault(x => x.maloai.Trim().Contains(maloai.Trim()));
            loaisp.Maloai = _loaisp.maloai;
            loaisp.Tenloai = _loaisp.tenloai;
            return loaisp;
        }

        public List<Loaisanpham_DTO> GetAllLoaiSp()
        {
            List<Loaisanpham_DTO> lsp = new List<Loaisanpham_DTO>();
            var _lsp = from x in db.loaisanphams select x;
            foreach (var i in _lsp)
            {
                lsp.Add(new Loaisanpham_DTO { Maloai = i.maloai, Tenloai = i.tenloai});
            }
            return lsp;
        }

        public List<Sanpham_DTO> GetSpBc()
        {
             GetAllSp();
            return listsp.Where(x => x.Giasanpham >= 10000000).ToList<Sanpham_DTO>();
        }

        public List<Sanpham_DTO> GetSpMoi()
        {
            GetAllSp();
            return listsp.Where(x => x.Sanphammoi == 1).ToList<Sanpham_DTO>();
        }

        public List<Sanpham_DTO> GetSpCungLoai(string maloai)
        {
            GetAllSp();
            return listsp.Where(x => x.Loai.Maloai.Trim().Contains(maloai.Trim())).ToList<Sanpham_DTO>();
        }


        public Sanpham_DTO Find(string masp)
        {
            Sanpham_DTO sp = new Sanpham_DTO();
            var _sp = db.sanphams.SingleOrDefault(x => x.masanpham.Trim().Contains(masp.Trim()));
            if (_sp != null)
            {

                sp.Masanpham = _sp.masanpham;
                sp.Tensanpham = _sp.tensanpham;
                sp.Giasanpham = _sp.giasanpham;
                sp.Hinhanh = _sp.hinhanh;
                sp.Sanphammoi = _sp.sanphammoi;
                sp.Chatlieu = _sp.chatlieu;
                sp.Loai = GetLoaisp(_sp.maloai);
            }
            else
            {
                sp = null;
            }
            return sp;
        }

        //Thêm sản phẩm đồng thời thêm số lượng sản phẩm bằng 0 vào tồn kho
        public bool Insert(Sanpham_DTO sanpham)
        {
            try
            {
                sanpham sp = new sanpham();
                sp.masanpham = sanpham.Masanpham;
                sp.tensanpham = sanpham.Tensanpham;
                sp.chatlieu = sanpham.Chatlieu;
                sp.giasanpham = sanpham.Giasanpham;
                sp.hinhanh = sanpham.Hinhanh;
                sp.maloai = sanpham.Loai.Maloai;
                sp.sanphammoi = 1;
                db.sanphams.Add(sp);
                tonkho tk= new tonkho();
                tk.ngay = DateTime.Now;
                tk.masanpham = sanpham.Masanpham;
                tk.soluong = 0;
                db.tonkhoes.Add(tk);
                db.SaveChanges();
                
                return true;
            }
            catch { return false; }
        }

        public bool Update(Sanpham_DTO sanpham)
        {
            try
            {
                sanpham sp = db.sanphams.Single(x => x.masanpham.Trim().Contains(sanpham.Masanpham.Trim()));
                sp.tensanpham = sanpham.Tensanpham;
                sp.giasanpham = sanpham.Giasanpham;
                sp.chatlieu = sanpham.Chatlieu;
                sp.hinhanh = sanpham.Hinhanh;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //chuyển sản phẩm vào danh sách sản phẩm ẩn
        public bool Delete(Sanpham_DTO sanpham)
        {
            try
            {
                sanpham sp = db.sanphams.Single(x => x.masanpham.Trim().Contains(sanpham.Masanpham.Trim()));
                sp.sanphammoi = 0;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //kích hoạt,chuyển sản phẩm vào danh sách hiển thị
        public bool Kichhoat(Sanpham_DTO sanpham)
        {
            try
            {
                sanpham sp = db.sanphams.Single(x => x.masanpham.Trim().Contains(sanpham.Masanpham.Trim()));
                sp.sanphammoi = 1;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
