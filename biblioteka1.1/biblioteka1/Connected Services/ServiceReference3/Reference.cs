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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference3.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WcfWypozyczeniaDoBazy.CompositeType GetDataUsingDataContract(WcfWypozyczeniaDoBazy.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WcfWypozyczeniaDoBazy.CompositeType> GetDataUsingDataContractAsync(WcfWypozyczeniaDoBazy.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertWypozyczenie", ReplyAction="http://tempuri.org/IService1/InsertWypozyczenieResponse")]
        int InsertWypozyczenie(WcfWypozyczeniaDoBazy.Wypozyczenie w);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertWypozyczenie", ReplyAction="http://tempuri.org/IService1/InsertWypozyczenieResponse")]
        System.Threading.Tasks.Task<int> InsertWypozyczenieAsync(WcfWypozyczeniaDoBazy.Wypozyczenie w);
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
        
        public WcfWypozyczeniaDoBazy.CompositeType GetDataUsingDataContract(WcfWypozyczeniaDoBazy.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WcfWypozyczeniaDoBazy.CompositeType> GetDataUsingDataContractAsync(WcfWypozyczeniaDoBazy.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public int InsertWypozyczenie(WcfWypozyczeniaDoBazy.Wypozyczenie w) {
            return base.Channel.InsertWypozyczenie(w);
        }
        
        public System.Threading.Tasks.Task<int> InsertWypozyczenieAsync(WcfWypozyczeniaDoBazy.Wypozyczenie w) {
            return base.Channel.InsertWypozyczenieAsync(w);
        }
    }
}
