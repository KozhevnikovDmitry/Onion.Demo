﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Onion.Demo.Client.EmployeeService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeService.IEmployeeService")]
    public interface IEmployeeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/SelectAll", ReplyAction="http://tempuri.org/IEmployeeService/SelectAllResponse")]
        Onion.Demo.DM.Employee[] SelectAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/SelectStaff", ReplyAction="http://tempuri.org/IEmployeeService/SelectStaffResponse")]
        Onion.Demo.DM.Employee[] SelectStaff();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/Save", ReplyAction="http://tempuri.org/IEmployeeService/SaveResponse")]
        Onion.Demo.DM.Employee Save(Onion.Demo.DM.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/Remove", ReplyAction="http://tempuri.org/IEmployeeService/RemoveResponse")]
        void Remove(Onion.Demo.DM.Employee employee);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeServiceChannel : Onion.Demo.Client.EmployeeService.IEmployeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<Onion.Demo.Client.EmployeeService.IEmployeeService>, Onion.Demo.Client.EmployeeService.IEmployeeService {
        
        public EmployeeServiceClient() {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Onion.Demo.DM.Employee[] SelectAll() {
            return base.Channel.SelectAll();
        }
        
        public Onion.Demo.DM.Employee[] SelectStaff() {
            return base.Channel.SelectStaff();
        }
        
        public Onion.Demo.DM.Employee Save(Onion.Demo.DM.Employee employee) {
            return base.Channel.Save(employee);
        }
        
        public void Remove(Onion.Demo.DM.Employee employee) {
            base.Channel.Remove(employee);
        }
    }
}