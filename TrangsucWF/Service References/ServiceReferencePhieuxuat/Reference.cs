﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrangsucWF.ServiceReferencePhieuxuat {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Phieuxuat_DTO", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceTrangsuc")]
    [System.SerializableAttribute()]
    public partial class Phieuxuat_DTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaphieuxuatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime NgaylapphieuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TennguoilapField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TongtienField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TrangthaiField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Maphieuxuat {
            get {
                return this.MaphieuxuatField;
            }
            set {
                if ((object.ReferenceEquals(this.MaphieuxuatField, value) != true)) {
                    this.MaphieuxuatField = value;
                    this.RaisePropertyChanged("Maphieuxuat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Ngaylapphieu {
            get {
                return this.NgaylapphieuField;
            }
            set {
                if ((this.NgaylapphieuField.Equals(value) != true)) {
                    this.NgaylapphieuField = value;
                    this.RaisePropertyChanged("Ngaylapphieu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tennguoilap {
            get {
                return this.TennguoilapField;
            }
            set {
                if ((object.ReferenceEquals(this.TennguoilapField, value) != true)) {
                    this.TennguoilapField = value;
                    this.RaisePropertyChanged("Tennguoilap");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Tongtien {
            get {
                return this.TongtienField;
            }
            set {
                if ((this.TongtienField.Equals(value) != true)) {
                    this.TongtienField = value;
                    this.RaisePropertyChanged("Tongtien");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Trangthai {
            get {
                return this.TrangthaiField;
            }
            set {
                if ((object.ReferenceEquals(this.TrangthaiField, value) != true)) {
                    this.TrangthaiField = value;
                    this.RaisePropertyChanged("Trangthai");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Chitietphieuxuat_DTO", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceTrangsuc")]
    [System.SerializableAttribute()]
    public partial class Chitietphieuxuat_DTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MasanphamField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TrangsucWF.ServiceReferencePhieuxuat.Phieuxuat_DTO PhieuxuatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TrangsucWF.ServiceReferencePhieuxuat.Sanpham_DTO SanphamField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SoluongField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ThanhtienField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Masanpham {
            get {
                return this.MasanphamField;
            }
            set {
                if ((object.ReferenceEquals(this.MasanphamField, value) != true)) {
                    this.MasanphamField = value;
                    this.RaisePropertyChanged("Masanpham");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TrangsucWF.ServiceReferencePhieuxuat.Phieuxuat_DTO Phieuxuat {
            get {
                return this.PhieuxuatField;
            }
            set {
                if ((object.ReferenceEquals(this.PhieuxuatField, value) != true)) {
                    this.PhieuxuatField = value;
                    this.RaisePropertyChanged("Phieuxuat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TrangsucWF.ServiceReferencePhieuxuat.Sanpham_DTO Sanpham {
            get {
                return this.SanphamField;
            }
            set {
                if ((object.ReferenceEquals(this.SanphamField, value) != true)) {
                    this.SanphamField = value;
                    this.RaisePropertyChanged("Sanpham");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Soluong {
            get {
                return this.SoluongField;
            }
            set {
                if ((this.SoluongField.Equals(value) != true)) {
                    this.SoluongField = value;
                    this.RaisePropertyChanged("Soluong");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Thanhtien {
            get {
                return this.ThanhtienField;
            }
            set {
                if ((this.ThanhtienField.Equals(value) != true)) {
                    this.ThanhtienField = value;
                    this.RaisePropertyChanged("Thanhtien");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Sanpham_DTO", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceTrangsuc")]
    [System.SerializableAttribute()]
    public partial class Sanpham_DTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ChatlieuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GiasanphamField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HinhanhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TrangsucWF.ServiceReferencePhieuxuat.Loaisanpham_DTO LoaiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MasanphamField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SanphammoiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenloaiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TensanphamField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Chatlieu {
            get {
                return this.ChatlieuField;
            }
            set {
                if ((object.ReferenceEquals(this.ChatlieuField, value) != true)) {
                    this.ChatlieuField = value;
                    this.RaisePropertyChanged("Chatlieu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Giasanpham {
            get {
                return this.GiasanphamField;
            }
            set {
                if ((this.GiasanphamField.Equals(value) != true)) {
                    this.GiasanphamField = value;
                    this.RaisePropertyChanged("Giasanpham");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Hinhanh {
            get {
                return this.HinhanhField;
            }
            set {
                if ((object.ReferenceEquals(this.HinhanhField, value) != true)) {
                    this.HinhanhField = value;
                    this.RaisePropertyChanged("Hinhanh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TrangsucWF.ServiceReferencePhieuxuat.Loaisanpham_DTO Loai {
            get {
                return this.LoaiField;
            }
            set {
                if ((object.ReferenceEquals(this.LoaiField, value) != true)) {
                    this.LoaiField = value;
                    this.RaisePropertyChanged("Loai");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Masanpham {
            get {
                return this.MasanphamField;
            }
            set {
                if ((object.ReferenceEquals(this.MasanphamField, value) != true)) {
                    this.MasanphamField = value;
                    this.RaisePropertyChanged("Masanpham");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Sanphammoi {
            get {
                return this.SanphammoiField;
            }
            set {
                if ((this.SanphammoiField.Equals(value) != true)) {
                    this.SanphammoiField = value;
                    this.RaisePropertyChanged("Sanphammoi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tenloai {
            get {
                return this.TenloaiField;
            }
            set {
                if ((object.ReferenceEquals(this.TenloaiField, value) != true)) {
                    this.TenloaiField = value;
                    this.RaisePropertyChanged("Tenloai");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tensanpham {
            get {
                return this.TensanphamField;
            }
            set {
                if ((object.ReferenceEquals(this.TensanphamField, value) != true)) {
                    this.TensanphamField = value;
                    this.RaisePropertyChanged("Tensanpham");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Loaisanpham_DTO", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceTrangsuc")]
    [System.SerializableAttribute()]
    public partial class Loaisanpham_DTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaloaiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenloaiField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Maloai {
            get {
                return this.MaloaiField;
            }
            set {
                if ((object.ReferenceEquals(this.MaloaiField, value) != true)) {
                    this.MaloaiField = value;
                    this.RaisePropertyChanged("Maloai");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tenloai {
            get {
                return this.TenloaiField;
            }
            set {
                if ((object.ReferenceEquals(this.TenloaiField, value) != true)) {
                    this.TenloaiField = value;
                    this.RaisePropertyChanged("Tenloai");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferencePhieuxuat.IServicePhieuxuat")]
    public interface IServicePhieuxuat {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuxuat/GetAllphieuxuat", ReplyAction="http://tempuri.org/IServicePhieuxuat/GetAllphieuxuatResponse")]
        TrangsucWF.ServiceReferencePhieuxuat.Phieuxuat_DTO[] GetAllphieuxuat();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuxuat/GetChitietByMa", ReplyAction="http://tempuri.org/IServicePhieuxuat/GetChitietByMaResponse")]
        TrangsucWF.ServiceReferencePhieuxuat.Chitietphieuxuat_DTO[] GetChitietByMa(string maphieuxuat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuxuat/GetphieuxuatByMa", ReplyAction="http://tempuri.org/IServicePhieuxuat/GetphieuxuatByMaResponse")]
        TrangsucWF.ServiceReferencePhieuxuat.Phieuxuat_DTO GetphieuxuatByMa(string maphieuxuat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuxuat/Insertphieuxuat", ReplyAction="http://tempuri.org/IServicePhieuxuat/InsertphieuxuatResponse")]
        bool Insertphieuxuat(TrangsucWF.ServiceReferencePhieuxuat.Phieuxuat_DTO px);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuxuat/Updatephieuxuat", ReplyAction="http://tempuri.org/IServicePhieuxuat/UpdatephieuxuatResponse")]
        bool Updatephieuxuat(TrangsucWF.ServiceReferencePhieuxuat.Phieuxuat_DTO px);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuxuat/InsertChitiet", ReplyAction="http://tempuri.org/IServicePhieuxuat/InsertChitietResponse")]
        bool InsertChitiet(TrangsucWF.ServiceReferencePhieuxuat.Chitietphieuxuat_DTO px);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuxuat/UpdateChitiet", ReplyAction="http://tempuri.org/IServicePhieuxuat/UpdateChitietResponse")]
        bool UpdateChitiet(TrangsucWF.ServiceReferencePhieuxuat.Chitietphieuxuat_DTO px);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuxuat/DeleteChitiet", ReplyAction="http://tempuri.org/IServicePhieuxuat/DeleteChitietResponse")]
        bool DeleteChitiet(TrangsucWF.ServiceReferencePhieuxuat.Chitietphieuxuat_DTO px);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicePhieuxuatChannel : TrangsucWF.ServiceReferencePhieuxuat.IServicePhieuxuat, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicePhieuxuatClient : System.ServiceModel.ClientBase<TrangsucWF.ServiceReferencePhieuxuat.IServicePhieuxuat>, TrangsucWF.ServiceReferencePhieuxuat.IServicePhieuxuat {
        
        public ServicePhieuxuatClient() {
        }
        
        public ServicePhieuxuatClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicePhieuxuatClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePhieuxuatClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePhieuxuatClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TrangsucWF.ServiceReferencePhieuxuat.Phieuxuat_DTO[] GetAllphieuxuat() {
            return base.Channel.GetAllphieuxuat();
        }
        
        public TrangsucWF.ServiceReferencePhieuxuat.Chitietphieuxuat_DTO[] GetChitietByMa(string maphieuxuat) {
            return base.Channel.GetChitietByMa(maphieuxuat);
        }
        
        public TrangsucWF.ServiceReferencePhieuxuat.Phieuxuat_DTO GetphieuxuatByMa(string maphieuxuat) {
            return base.Channel.GetphieuxuatByMa(maphieuxuat);
        }
        
        public bool Insertphieuxuat(TrangsucWF.ServiceReferencePhieuxuat.Phieuxuat_DTO px) {
            return base.Channel.Insertphieuxuat(px);
        }
        
        public bool Updatephieuxuat(TrangsucWF.ServiceReferencePhieuxuat.Phieuxuat_DTO px) {
            return base.Channel.Updatephieuxuat(px);
        }
        
        public bool InsertChitiet(TrangsucWF.ServiceReferencePhieuxuat.Chitietphieuxuat_DTO px) {
            return base.Channel.InsertChitiet(px);
        }
        
        public bool UpdateChitiet(TrangsucWF.ServiceReferencePhieuxuat.Chitietphieuxuat_DTO px) {
            return base.Channel.UpdateChitiet(px);
        }
        
        public bool DeleteChitiet(TrangsucWF.ServiceReferencePhieuxuat.Chitietphieuxuat_DTO px) {
            return base.Channel.DeleteChitiet(px);
        }
    }
}