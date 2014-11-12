using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceTrangsuc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceHoadon" in both code and config file together.
    [ServiceContract]
    public interface IServiceHoadon
    {
        [OperationContract]
        List<Hoadon_DTO> GetAllHoadon();

        [OperationContract]
        List<Chitiethoadon_DTO> GetChitietByMa(int mahoadon);

        [OperationContract]
        Hoadon_DTO GetHoadonByMa(int mahoadon);

        [OperationContract]
        int InsertHoadon(string tendangnhap, string diadiemgiaohang,DateTime ngaygiaohang,string sdt);

        [OperationContract]
        bool UpdateHoadon(Hoadon_DTO hd);

        [OperationContract]
        bool InsertChitiet(int mahoadon,string masanpham,int soluong,int giasanpham);

        [OperationContract]
        List<Chitiethoadon_DTO> GetAllChitiet();

    }

    [DataContract]
    public class Hoadon_DTO
    {
        int id;
        int mahoadon;
        DateTime ngaymuahang;
        string diadiemgiaohang;
        string trangthai;
        int tongtien;
        string sdt;
        DateTime ngaygiaohang;
        Nguoidung_DTO nguoidung;
        [DataMember]
        public int Mahoadon
        {
            get { return mahoadon;}
            set { mahoadon = value;}
        }
        [DataMember]
        public Nguoidung_DTO Nguoidung
        {
            get { return nguoidung; }
            set { nguoidung = value; }
        }
        [DataMember]
        public DateTime Ngaymuahang
        {
            get { return ngaymuahang;}
            set { ngaymuahang = value;}
        }
        [DataMember]
        public string Diadiemgiaohang
        {
            get { return diadiemgiaohang ;}
            set { diadiemgiaohang=value;}
        }
        [DataMember]
        public DateTime Ngaygiaohang
        {
            get { return ngaygiaohang;}
            set { ngaygiaohang = value;}
        }
        [DataMember]
        public string Trangthai
        {
            get { return trangthai;}
            set { trangthai = value;}
        }

        [DataMember]
        public int Tongtien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
        [DataMember]
        public string Tendangnhap
        {
            get
            {
                return nguoidung == null ? String.Empty : nguoidung.Username;
            }
            set { }
        }
        [DataMember]
        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }   
    }
    [DataContract]
    public class Chitiethoadon_DTO
    {
        Hoadon_DTO hoadon;
        Sanpham_DTO sanpham;
        int soluong;
        int giasanpham;
        [DataMember]
        public int Soluong 
        { 
            get { return soluong; } 
            set { soluong = value; } 
        }
        [DataMember]
        public Hoadon_DTO Hoadon
        {
            get { return hoadon; }
            set { hoadon = value; }
        }
        [DataMember]
        public Sanpham_DTO Sanpham
        {
            get { return sanpham; }
            set { sanpham = value; }
        }
        string masanpham;      
        [DataMember]
        public string Masanpham
        {
            get { return masanpham; }
            set { masanpham = value; }
        }
        [DataMember]
        public int Giasanpham
        {
            get { return giasanpham; }
            set { giasanpham = value; }
        }

        [DataMember]
        public string Tensanpham
        {
            get { return sanpham == null ? String.Empty : sanpham.Tensanpham; }
            set { }
        }
       
        [DataMember]
        public string Thanhtien
        {
            get { return sanpham == null ? String.Empty : (giasanpham * soluong).ToString(); }
            set { }
        }
        
    }

}
