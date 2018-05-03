﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PanelBatik.MailServis {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MailServis.IMail")]
    public interface IMail {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMail/GetPassword", ReplyAction="http://tempuri.org/IMail/GetPasswordResponse")]
        string GetPassword();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMail/GetPassword", ReplyAction="http://tempuri.org/IMail/GetPasswordResponse")]
        System.Threading.Tasks.Task<string> GetPasswordAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMail/SendMail", ReplyAction="http://tempuri.org/IMail/SendMailResponse")]
        void SendMail(string psw, string mail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMail/SendMail", ReplyAction="http://tempuri.org/IMail/SendMailResponse")]
        System.Threading.Tasks.Task SendMailAsync(string psw, string mail);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMailChannel : PanelBatik.MailServis.IMail, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MailClient : System.ServiceModel.ClientBase<PanelBatik.MailServis.IMail>, PanelBatik.MailServis.IMail {
        
        public MailClient() {
        }
        
        public MailClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MailClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MailClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MailClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetPassword() {
            return base.Channel.GetPassword();
        }
        
        public System.Threading.Tasks.Task<string> GetPasswordAsync() {
            return base.Channel.GetPasswordAsync();
        }
        
        public void SendMail(string psw, string mail) {
            base.Channel.SendMail(psw, mail);
        }
        
        public System.Threading.Tasks.Task SendMailAsync(string psw, string mail) {
            return base.Channel.SendMailAsync(psw, mail);
        }
    }
}