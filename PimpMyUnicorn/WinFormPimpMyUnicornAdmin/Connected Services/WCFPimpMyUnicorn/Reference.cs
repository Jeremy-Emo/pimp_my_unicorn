﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinFormPimpMyUnicorn.WCFPimpMyUnicorn {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PartiesDTO", Namespace="http://schemas.datacontract.org/2004/07/WCFPimpMyUnicorn.DTO")]
    [System.SerializableAttribute()]
    public partial class PartiesDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ElementsDTO", Namespace="http://schemas.datacontract.org/2004/07/WCFPimpMyUnicorn.DTO")]
    [System.SerializableAttribute()]
    public partial class ElementsDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFPimpMyUnicorn.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateDatabase", ReplyAction="http://tempuri.org/IService1/UpdateDatabaseResponse")]
        bool UpdateDatabase(string[] queries);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateDatabase", ReplyAction="http://tempuri.org/IService1/UpdateDatabaseResponse")]
        System.Threading.Tasks.Task<bool> UpdateDatabaseAsync(string[] queries);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetParties", ReplyAction="http://tempuri.org/IService1/GetPartiesResponse")]
        WinFormPimpMyUnicorn.WCFPimpMyUnicorn.PartiesDTO[] GetParties();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetParties", ReplyAction="http://tempuri.org/IService1/GetPartiesResponse")]
        System.Threading.Tasks.Task<WinFormPimpMyUnicorn.WCFPimpMyUnicorn.PartiesDTO[]> GetPartiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetElements", ReplyAction="http://tempuri.org/IService1/GetElementsResponse")]
        WinFormPimpMyUnicorn.WCFPimpMyUnicorn.ElementsDTO[] GetElements();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetElements", ReplyAction="http://tempuri.org/IService1/GetElementsResponse")]
        System.Threading.Tasks.Task<WinFormPimpMyUnicorn.WCFPimpMyUnicorn.ElementsDTO[]> GetElementsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WinFormPimpMyUnicorn.WCFPimpMyUnicorn.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WinFormPimpMyUnicorn.WCFPimpMyUnicorn.IService1>, WinFormPimpMyUnicorn.WCFPimpMyUnicorn.IService1 {
        
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
        
        public bool UpdateDatabase(string[] queries) {
            return base.Channel.UpdateDatabase(queries);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateDatabaseAsync(string[] queries) {
            return base.Channel.UpdateDatabaseAsync(queries);
        }
        
        public WinFormPimpMyUnicorn.WCFPimpMyUnicorn.PartiesDTO[] GetParties() {
            return base.Channel.GetParties();
        }
        
        public System.Threading.Tasks.Task<WinFormPimpMyUnicorn.WCFPimpMyUnicorn.PartiesDTO[]> GetPartiesAsync() {
            return base.Channel.GetPartiesAsync();
        }
        
        public WinFormPimpMyUnicorn.WCFPimpMyUnicorn.ElementsDTO[] GetElements() {
            return base.Channel.GetElements();
        }
        
        public System.Threading.Tasks.Task<WinFormPimpMyUnicorn.WCFPimpMyUnicorn.ElementsDTO[]> GetElementsAsync() {
            return base.Channel.GetElementsAsync();
        }
    }
}
