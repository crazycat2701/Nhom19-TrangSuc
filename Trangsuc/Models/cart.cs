using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trangsuc.ServiceReferenceNguoidung;
using Trangsuc.ServiceReferenceHoadon;
using Trangsuc.ServiceReferenceTonkho;
namespace Trangsuc.Models
{
    public class Cart
    {
        ServiceHoadonClient dbhoadon = new ServiceHoadonClient();
         ServiceNguoidungClient db = new ServiceNguoidungClient();
         ServiceTonkhoClient dbtonkho = new ServiceTonkhoClient();
        private List<CartLine> dssanpham = new List<CartLine>();
        public void AddItem(string Masp, string Tensp, int Giasanpham, int quantity)
        {
            CartLine line = dssanpham
            .Where(p => p.masp.Contains(Masp)).FirstOrDefault();
            if (line == null)
            {
                dssanpham.Add(new CartLine { masp = Masp, tensp = Tensp, giasanpham = Giasanpham, Quantity = quantity });
            }
            else
            {
                Tonkho_DTO tk = dbtonkho.Find(Masp);
                if (line.Quantity + quantity <= tk.Soluong)
                {
                    line.Quantity += quantity;
                }
                else line.Quantity = tk.Soluong;
            }
        }
        public void RemoveLine(string masp)
        {
            dssanpham.RemoveAll(l => l.masp.Contains(masp));
        }
        public decimal tongtien()
        {
            return dssanpham.Sum(e => e.giasanpham * e.Quantity);
        }
        public void capnhatsoluong(string masp, int soluong)
        {
            CartLine line = dssanpham.Where(p => p.masp.Contains(masp)).FirstOrDefault();
            line.Quantity = soluong;
        }
        public void Clear()
        {
            dssanpham.Clear();
        }
        public decimal tongsanpham()
        {
            return dssanpham.Sum(e => e.Quantity);
        }
        public IEnumerable<CartLine> Lines
        {
            get { return dssanpham; }
        }
        public ServiceReferenceNguoidung.Nguoidung_DTO thongtinkh(string username)
        {
            var result = db.GetNguoidungByUsername(username);
            return result;
        }

        public void save(string username, string diachi, DateTime ngaygiaohang,string sdt)
        {
            
            int i = dbhoadon.InsertHoadon(username,diachi,ngaygiaohang,sdt);
            if (i > 0)
            {
                savecthd(i);
            }

        }
        public void savecthd(int mahd)
        {
            foreach (var item in dssanpham)
            {
                dbhoadon.InsertChitiet(mahd,item.masp,item.Quantity,item.giasanpham);
            }
        }
       
    }
    public class CartLine
    {
        public string masp { get; set; }
        public string tensp { get; set; }
        public int giasanpham { get; set; }
        public int Quantity { get; set; }
    }

}
