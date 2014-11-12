using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceTrangsuc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicePhieunhap" in both code and config file together.
    [ServiceContract]
    public interface IServicePhieunhap
    {
        [OperationContract]
        List<Phieunhap_DTO> GetAllPhieunhap();

        [OperationContract]
        List<Chitietphieunhap_DTO> GetChitietByMa(string maphieunhap);

        [OperationContract]
        Phieunhap_DTO GetPhieunhapByMa(string maphieunhap);

        [OperationContract]
        bool InsertPhieunhap(Phieunhap_DTO pn);

        [OperationContract]
        bool UpdatePhieunhap(Phieunhap_DTO pn);

        [OperationContract]
        bool InsertChitiet(Chitietphieunhap_DTO pn);

        [OperationContract]
        bool UpdateChitiet(Chitietphieunhap_DTO pn);

        [OperationContract]
        bool DeleteChitiet(Chitietphieunhap_DTO pn);
    }

    [DataContract]
    public class Phieunhap_DTO
    {
        string maphieunhap;
        DateTime ngaylapphieu;
        string tennguoilap;
        string trangthai;
        int tongtien;
        [DataMember]
        public string Maphieunhap
        {
            get { return maphieunhap; }
            set { maphieunhap = value; }
        }
       
        [DataMember]
        public DateTime Ngaylapphieu
        {
            get { return ngaylapphieu; }
            set { ngaylapphieu = value; }
        }
       
        [DataMember]
        public string Tennguoilap
        {
            get { return tennguoilap; }
            set { tennguoilap = value; }
        }
        [DataMember]
        public int Tongtien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
        [DataMember]
        public string Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
    }

    [DataContract]
    public class Chitietphieunhap_DTO
    {
        int id;
        Phieunhap_DTO phieunhap;
        Sanpham_DTO sanpham;
        int soluong;
        int thanhtien;
        [DataMember]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        [DataMember]
        public int Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
        [DataMember]
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        [DataMember]
        public Phieunhap_DTO Phieunhap
        {
            get { return phieunhap; }
            set { phieunhap = value; }
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
    }
}
