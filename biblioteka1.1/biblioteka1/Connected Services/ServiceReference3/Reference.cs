﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace biblioteka1.ServiceReference3 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfWypozyczeniaDoBazy")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Wypozyczenie", Namespace="http://schemas.datacontract.org/2004/07/WcfWypozyczeniaDoBazy")]
    [System.SerializableAttribute()]
    public partial class Wypozyczenie : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool czyAktualneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dataWypozyczyeniaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dataZwrotuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idKsiazkiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idUseraField;
        
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
        public bool czyAktualne {
            get {
                return this.czyAktualneField;
            }
            set {
                if ((this.czyAktualneField.Equals(value) != true)) {
                    this.czyAktualneField = value;
                    this.RaisePropertyChanged("czyAktualne");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime dataWypozyczyenia {
            get {
                return this.dataWypozyczyeniaField;
            }
            set {
                if ((this.dataWypozyczyeniaField.Equals(value) != true)) {
                    this.dataWypozyczyeniaField = value;
                    this.RaisePropertyChanged("dataWypozyczyenia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime dataZwrotu {
            get {
                return this.dataZwrotuField;
            }
            set {
                if ((this.dataZwrotuField.Equals(value) != true)) {
                    this.dataZwrotuField = value;
                    this.RaisePropertyChanged("dataZwrotu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idKsiazki {
            get {
                return this.idKsiazkiField;
            }
            set {
                if ((this.idKsiazkiField.Equals(value) != true)) {
                    this.idKsiazkiField = value;
                    this.RaisePropertyChanged("idKsiazki");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string idUsera {
            get {
                return this.idUseraField;
            }
            set {
                if ((object.ReferenceEquals(this.idUseraField, value) != true)) {
                    this.idUseraField = value;
                    this.RaisePropertyChanged("idUsera");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference3.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        biblioteka1.ServiceReference3.CompositeType GetDataUsingDataContract(biblioteka1.ServiceReference3.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<biblioteka1.ServiceReference3.CompositeType> GetDataUsingDataContractAsync(biblioteka1.ServiceReference3.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertWypozyczenie", ReplyAction="http://tempuri.org/IService1/InsertWypozyczenieResponse")]
        int InsertWypozyczenie(biblioteka1.ServiceReference3.Wypozyczenie w);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertWypozyczenie", ReplyAction="http://tempuri.org/IService1/InsertWypozyczenieResponse")]
        System.Threading.Tasks.Task<int> InsertWypozyczenieAsync(biblioteka1.ServiceReference3.Wypozyczenie w);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : biblioteka1.ServiceReference3.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<biblioteka1.ServiceReference3.IService1>, biblioteka1.ServiceReference3.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public biblioteka1.ServiceReference3.CompositeType GetDataUsingDataContract(biblioteka1.ServiceReference3.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<biblioteka1.ServiceReference3.CompositeType> GetDataUsingDataContractAsync(biblioteka1.ServiceReference3.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public int InsertWypozyczenie(biblioteka1.ServiceReference3.Wypozyczenie w) {
            return base.Channel.InsertWypozyczenie(w);
        }
        
        public System.Threading.Tasks.Task<int> InsertWypozyczenieAsync(biblioteka1.ServiceReference3.Wypozyczenie w) {
            return base.Channel.InsertWypozyczenieAsync(w);
        }
    }
}
