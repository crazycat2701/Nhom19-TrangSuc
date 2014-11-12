using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceTrangsuc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicePhieuxuat" in both code and config file together.
    [ServiceContract]
    public interface IServicePhieuxuat
    {
        [OperationContract]
        List<Phieuxuat_DTO> GetAllphieuxuat();

        [OperationContract]
        List<Chitietphieuxuat_DTO> GetChitietByMa(string maphieuxuat);

        [OperationContract]
        Phieuxuat_DTO GetphieuxuatByMa(string maphieuxuat);

        [OperationContract]
        bool Insertphieuxuat(Phieuxuat_DTO px);

        [OperationContract]
        bool Updatephieuxuat(Phieuxuat_DTO px);

        [OperationContract]
        bool InsertChitiet(Chitietphieuxuat_DTO px);

        [OperationContract]
        bool UpdateChitiet(Chitietphieuxuat_DTO px);

        [OperationContract]
        bool DeleteChitiet(Chitietphieuxuat_DTO px);
    }

    [DataContract]
    public class Phieuxuat_DTO
    {
        string maphieuxuat;
        DateTime ngaylapphieu;
        string tennguoilap;
        string trangthai;
        int tongtien;
        [DataMember]
        public string Maphieuxuat
        {
            get { return maphieuxuat; }
            set { maphieuxuat = value; }
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
    public class Chitietphieuxuat_DTO
    {
        int id;
        Phieuxuat_DTO phieuxuat;
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
        public Phieuxuat_DTO Phieuxuat
        {
            get { return phieuxuat; }
            set { phieuxuat = value; }
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
