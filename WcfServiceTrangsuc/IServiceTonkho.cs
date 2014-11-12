using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace WcfServiceTrangsuc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceTonkho
    {

        // TODO: Add your service operations here
        [OperationContract]
        List<Tonkho_DTO> GetAllTonkho(string maloai,DateTime ngay);
        [OperationContract]
        Tonkho_DTO Find(string masp);
        //[OperationContract]
        //List<Tonkho_DTO> GetAllTonkhoByDay(DateTime ngay);
        [OperationContract]
        bool NhapKho(Chitietphieunhap_DTO ctpn);
        [OperationContract]
        bool XuatKho(Chitietphieuxuat_DTO ctpx);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.


    [DataContract]
    public class Tonkho_DTO
    {
        DateTime ngay;
        [DataMember]
        public DateTime Ngay
        {
            get { return ngay; }
            set { ngay = value; }
        }

        Sanpham_DTO sptonkho;
        [DataMember]
        public Sanpham_DTO Sptonkho
        {
            get { return sptonkho; }
            set { sptonkho = value; }
        }

        int soluong;
        [DataMember]
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        [DataMember]
        public string Masanpham
        {
            get { return sptonkho == null ? String.Empty : sptonkho.Masanpham; }
            set { }
        }
        [DataMember]
        public string Tensanpham
        {
            get { return sptonkho == null ? String.Empty : sptonkho.Tensanpham; }
            set { }
        }
    }
}
