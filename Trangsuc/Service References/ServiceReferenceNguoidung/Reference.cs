﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trangsuc.ServiceReferenceNguoidung {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Nguoidung_DTO", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceTrangsuc")]
    [System.SerializableAttribute()]
    public partial class Nguoidung_DTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DiachiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GioitinhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HotenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime NgaysinhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PassField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Trangsuc.ServiceReferenceNguoidung.Phanquyen_DTO QuyenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SdtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool UseranField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public string Diachi {
            get {
                return this.DiachiField;
            }
            set {
                if ((object.ReferenceEquals(this.DiachiField, value) != true)) {
                    this.DiachiField = value;
                    this.RaisePropertyChanged("Diachi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Gioitinh {
            get {
                return this.GioitinhField;
            }
            set {
                if ((this.GioitinhField.Equals(value) != true)) {
                    this.GioitinhField = value;
                    this.RaisePropertyChanged("Gioitinh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Hoten {
            get {
                return this.HotenField;
            }
            set {
                if ((object.ReferenceEquals(this.HotenField, value) != true)) {
                    this.HotenField = value;
                    this.RaisePropertyChanged("Hoten");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mail {
            get {
                return this.MailField;
            }
            set {
                if ((object.ReferenceEquals(this.MailField, value) != true)) {
                    this.MailField = value;
                    this.RaisePropertyChanged("Mail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Ngaysinh {
            get {
                return this.NgaysinhField;
            }
            set {
                if ((this.NgaysinhField.Equals(value) != true)) {
                    this.NgaysinhField = value;
                    this.RaisePropertyChanged("Ngaysinh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pass {
            get {
                return this.PassField;
            }
            set {
                if ((object.ReferenceEquals(this.PassField, value) != true)) {
                    this.PassField = value;
                    this.RaisePropertyChanged("Pass");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Trangsuc.ServiceReferenceNguoidung.Phanquyen_DTO Quyen {
            get {
                return this.QuyenField;
            }
            set {
                if ((object.ReferenceEquals(this.QuyenField, value) != true)) {
                    this.QuyenField = value;
                    this.RaisePropertyChanged("Quyen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sdt {
            get {
                return this.SdtField;
            }
            set {
                if ((object.ReferenceEquals(this.SdtField, value) != true)) {
                    this.SdtField = value;
                    this.RaisePropertyChanged("Sdt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Useran {
            get {
                return this.UseranField;
            }
            set {
                if ((this.UseranField.Equals(value) != true)) {
                    this.UseranField = value;
                    this.RaisePropertyChanged("Useran");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Phanquyen_DTO", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceTrangsuc")]
    [System.SerializableAttribute()]
    public partial class Phanquyen_DTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaphanquyenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QuyenField;
        
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
        public int Maphanquyen {
            get {
                return this.MaphanquyenField;
            }
            set {
                if ((this.MaphanquyenField.Equals(value) != true)) {
                    this.MaphanquyenField = value;
                    this.RaisePropertyChanged("Maphanquyen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Quyen {
            get {
                return this.QuyenField;
            }
            set {
                if ((object.ReferenceEquals(this.QuyenField, value) != true)) {
                    this.QuyenField = value;
                    this.RaisePropertyChanged("Quyen");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceNguoidung.IServiceNguoidung")]
    public interface IServiceNguoidung {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNguoidung/GetAllNguoidung", ReplyAction="http://tempuri.org/IServiceNguoidung/GetAllNguoidungResponse")]
        Trangsuc.ServiceReferenceNguoidung.Nguoidung_DTO[] GetAllNguoidung();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNguoidung/GetQuyen", ReplyAction="http://tempuri.org/IServiceNguoidung/GetQuyenResponse")]
        Trangsuc.ServiceReferenceNguoidung.Phanquyen_DTO GetQuyen(int quyen);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNguoidung/GetAllQuyen", ReplyAction="http://tempuri.org/IServiceNguoidung/GetAllQuyenResponse")]
        Trangsuc.ServiceReferenceNguoidung.Phanquyen_DTO[] GetAllQuyen();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNguoidung/GetNguoidungByUsername", ReplyAction="http://tempuri.org/IServiceNguoidung/GetNguoidungByUsernameResponse")]
        Trangsuc.ServiceReferenceNguoidung.Nguoidung_DTO GetNguoidungByUsername(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNguoidung/Insert", ReplyAction="http://tempuri.org/IServiceNguoidung/InsertResponse")]
        bool Insert(Trangsuc.ServiceReferenceNguoidung.Nguoidung_DTO nd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNguoidung/Update", ReplyAction="http://tempuri.org/IServiceNguoidung/UpdateResponse")]
        bool Update(Trangsuc.ServiceReferenceNguoidung.Nguoidung_DTO nd);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceNguoidungChannel : Trangsuc.ServiceReferenceNguoidung.IServiceNguoidung, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceNguoidungClient : System.ServiceModel.ClientBase<Trangsuc.ServiceReferenceNguoidung.IServiceNguoidung>, Trangsuc.ServiceReferenceNguoidung.IServiceNguoidung {
        
        public ServiceNguoidungClient() {
        }
        
        public ServiceNguoidungClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceNguoidungClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceNguoidungClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceNguoidungClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Trangsuc.ServiceReferenceNguoidung.Nguoidung_DTO[] GetAllNguoidung() {
            return base.Channel.GetAllNguoidung();
        }
        
        public Trangsuc.ServiceReferenceNguoidung.Phanquyen_DTO GetQuyen(int quyen) {
            return base.Channel.GetQuyen(quyen);
        }
        
        public Trangsuc.ServiceReferenceNguoidung.Phanquyen_DTO[] GetAllQuyen() {
            return base.Channel.GetAllQuyen();
        }
        
        public Trangsuc.ServiceReferenceNguoidung.Nguoidung_DTO GetNguoidungByUsername(string username) {
            return base.Channel.GetNguoidungByUsername(username);
        }
        
        public bool Insert(Trangsuc.ServiceReferenceNguoidung.Nguoidung_DTO nd) {
            return base.Channel.Insert(nd);
        }
        
        public bool Update(Trangsuc.ServiceReferenceNguoidung.Nguoidung_DTO nd) {
            return base.Channel.Update(nd);
        }
    }
}
