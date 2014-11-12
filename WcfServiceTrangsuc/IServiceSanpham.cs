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
    public interface IServiceSanpham
    {
        [OperationContract]
        List<Sanpham_DTO> GetAllSp();

        [OperationContract]
        List<Loaisanpham_DTO> GetAllLoaiSp();

        [OperationContract]
        Loaisanpham_DTO GetLoaisp(string maloai);

        [OperationContract]
        List<Sanpham_DTO> GetSpBc();

        [OperationContract]
        List<Sanpham_DTO> GetSpMoi();

        [OperationContract]
        List<Sanpham_DTO> GetSpCungLoai(string maloai);

        [OperationContract]
        Sanpham_DTO Find(string masp);

        [OperationContract]
        bool Insert(Sanpham_DTO sanpham);

        [OperationContract]
        bool Update(Sanpham_DTO sanpham);

        [OperationContract]
        bool Delete(Sanpham_DTO sanpham);
        [OperationContract]
        bool Kichhoat(Sanpham_DTO sanpham);
        // TODO: Add your service operations here
    }

 
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Sanpham_DTO
    {
        String masanpham;
        String tensanpham;
        String chatlieu;
        int giasanpham;
        int sanphammoi;
        Loaisanpham_DTO loai;
        [DataMember]
        public String Masanpham
        {
            get { return masanpham; }
            set { masanpham = value; }
        }
        [DataMember]
        public String Tensanpham
        {
            get { return tensanpham; }
            set { tensanpham = value; }
        }
        [DataMember]
        public String Chatlieu
        {
            get { return chatlieu; }
            set { chatlieu = value; }
        }
        [DataMember]
        public int Giasanpham
        {
            get { return giasanpham; }
            set { giasanpham = value; }
        }

        [DataMember]
        public int Sanphammoi
        {
            get { return sanphammoi; }
            set { sanphammoi = value; }
        }
        String hinhanh;
        [DataMember]
        public String Hinhanh
        {
            get { return hinhanh; }
            set { hinhanh = value; }
        }
        [DataMember]
        public Loaisanpham_DTO Loai
        {
            get { return loai; }
            set { loai = value; }
        }
        [DataMember]
        public string Tenloai
        {
            get { return loai == null ? String.Empty : loai.Tenloai; }
            set { }
        }

    }

    [DataContract]
    public class Loaisanpham_DTO
    {
        String maloai;
        [DataMember]
        public String Maloai
        {
            get { return maloai; }
            set { maloai = value; }
        }
        String tenloai;
        [DataMember]
        public String Tenloai
        {
            get { return tenloai; }
            set { tenloai = value; }
        }
    }

    
}
