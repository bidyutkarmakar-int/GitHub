﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5420
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EPF.DAL;
namespace EPF.WebUI.EPF.Service {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EPF.Service.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateCustomer", ReplyAction="http://tempuri.org/IService1/CreateCustomerResponse")]
        Customer CreateCustomer(Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateCustomer", ReplyAction="http://tempuri.org/IService1/UpdateCustomerResponse")]
        bool UpdateCustomer(Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SelectCustomer", ReplyAction="http://tempuri.org/IService1/SelectCustomerResponse")]
        Customer[] SelectCustomer();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCustomer", ReplyAction="http://tempuri.org/IService1/DeleteCustomerResponse")]
        void DeleteCustomer(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCustomerDetails", ReplyAction="http://tempuri.org/IService1/GetCustomerDetailsResponse")]
        Customer GetCustomerDetails(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IService1Channel : EPF.Service.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<EPF.Service.IService1>, EPF.Service.IService1 {
        
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
        
        public Customer CreateCustomer(Customer customer) {
            return base.Channel.CreateCustomer(customer);
        }
        
        public bool UpdateCustomer(Customer customer) {
            return base.Channel.UpdateCustomer(customer);
        }
        
        public Customer[] SelectCustomer() {
            return base.Channel.SelectCustomer();
        }
        
        public void DeleteCustomer(int id) {
            base.Channel.DeleteCustomer(id);
        }
        
        public Customer GetCustomerDetails(int id) {
            return base.Channel.GetCustomerDetails(id);
        }
    }
}
