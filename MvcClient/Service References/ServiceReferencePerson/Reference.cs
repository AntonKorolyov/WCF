﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcClient.ServiceReferencePerson {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/WcfServicePersons")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Fname {
            get {
                return this.FnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FnameField, value) != true)) {
                    this.FnameField = value;
                    this.RaisePropertyChanged("Fname");
                }
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferencePerson.IServicePerson")]
    public interface IServicePerson {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePerson/GetPersons", ReplyAction="http://tempuri.org/IServicePerson/GetPersonsResponse")]
        MvcClient.ServiceReferencePerson.Person[] GetPersons();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePerson/GetPersons", ReplyAction="http://tempuri.org/IServicePerson/GetPersonsResponse")]
        System.Threading.Tasks.Task<MvcClient.ServiceReferencePerson.Person[]> GetPersonsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePerson/CreateNewPerson", ReplyAction="http://tempuri.org/IServicePerson/CreateNewPersonResponse")]
        void CreateNewPerson(MvcClient.ServiceReferencePerson.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePerson/CreateNewPerson", ReplyAction="http://tempuri.org/IServicePerson/CreateNewPersonResponse")]
        System.Threading.Tasks.Task CreateNewPersonAsync(MvcClient.ServiceReferencePerson.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePerson/DeletePerson", ReplyAction="http://tempuri.org/IServicePerson/DeletePersonResponse")]
        void DeletePerson(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePerson/DeletePerson", ReplyAction="http://tempuri.org/IServicePerson/DeletePersonResponse")]
        System.Threading.Tasks.Task DeletePersonAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePerson/UpdatePerson", ReplyAction="http://tempuri.org/IServicePerson/UpdatePersonResponse")]
        void UpdatePerson(MvcClient.ServiceReferencePerson.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePerson/UpdatePerson", ReplyAction="http://tempuri.org/IServicePerson/UpdatePersonResponse")]
        System.Threading.Tasks.Task UpdatePersonAsync(MvcClient.ServiceReferencePerson.Person person);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicePersonChannel : MvcClient.ServiceReferencePerson.IServicePerson, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicePersonClient : System.ServiceModel.ClientBase<MvcClient.ServiceReferencePerson.IServicePerson>, MvcClient.ServiceReferencePerson.IServicePerson {
        
        public ServicePersonClient() {
        }
        
        public ServicePersonClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicePersonClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePersonClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePersonClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MvcClient.ServiceReferencePerson.Person[] GetPersons() {
            return base.Channel.GetPersons();
        }
        
        public System.Threading.Tasks.Task<MvcClient.ServiceReferencePerson.Person[]> GetPersonsAsync() {
            return base.Channel.GetPersonsAsync();
        }
        
        public void CreateNewPerson(MvcClient.ServiceReferencePerson.Person person) {
            base.Channel.CreateNewPerson(person);
        }
        
        public System.Threading.Tasks.Task CreateNewPersonAsync(MvcClient.ServiceReferencePerson.Person person) {
            return base.Channel.CreateNewPersonAsync(person);
        }
        
        public void DeletePerson(int id) {
            base.Channel.DeletePerson(id);
        }
        
        public System.Threading.Tasks.Task DeletePersonAsync(int id) {
            return base.Channel.DeletePersonAsync(id);
        }
        
        public void UpdatePerson(MvcClient.ServiceReferencePerson.Person person) {
            base.Channel.UpdatePerson(person);
        }
        
        public System.Threading.Tasks.Task UpdatePersonAsync(MvcClient.ServiceReferencePerson.Person person) {
            return base.Channel.UpdatePersonAsync(person);
        }
    }
}
