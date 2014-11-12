using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceTrangsuc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceNguoidung" in both code and config file together.
    [ServiceContract]
    public interface IServiceNguoidung
    {
        [OperationContract]
        List<Nguoidung_DTO> GetAllNguoidung();

        [OperationContract]
        Phanquyen_DTO GetQuyen(int quyen);

        [OperationContract]
        List<Phanquyen_DTO> GetAllQuyen();

        [OperationContract]
        Nguoidung_DTO GetNguoidungByUsername(string username);

        [OperationContract]
        bool Insert(Nguoidung_DTO nd);

        [OperationContract]
        bool Update(Nguoidung_DTO nd);
    }
    [DataContract]
    public class Nguoidung_DTO
    {
        string username;
        string hoten;
        string password;
      DateTime ngaysinh;
        int gioitinh;
        string sdt;
        string diachi;
        string email;
        bool useran;
        [DataMember]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        [DataMember]
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        [DataMember]
        public string Pass
        {
            get { return password; }
            set { password = value; }
        }
        [DataMember]
        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        [DataMember]
        public int Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        [DataMember]
        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        [DataMember]
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        [DataMember]
        public string Mail
        {
            get { return email; }
            set { email = value; }
        }
        [DataMember]
        public bool Useran
        {
            get { return useran; }
            set { useran = value; }
        }

        Phanquyen_DTO quyen;
        [DataMember]
        public Phanquyen_DTO Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }
    }

    [DataContract]
    public class Phanquyen_DTO
    {
        int maphanquyen;
        string quyen;
        [DataMember]
        public int Maphanquyen
        {
            get { return maphanquyen; }
            set { maphanquyen = value; }
        }
        [DataMember]
        public string Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }
    }

}
