﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfBiblioteca.ServiceReference2autorservice {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2autorservice.IAutorService")]
    public interface IAutorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAutorService/GetVersion", ReplyAction="http://tempuri.org/IAutorService/GetVersionResponse")]
        string GetVersion();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAutorService/GetVersion", ReplyAction="http://tempuri.org/IAutorService/GetVersionResponse")]
        System.Threading.Tasks.Task<string> GetVersionAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAutorServiceChannel : WcfBiblioteca.ServiceReference2autorservice.IAutorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AutorServiceClient : System.ServiceModel.ClientBase<WcfBiblioteca.ServiceReference2autorservice.IAutorService>, WcfBiblioteca.ServiceReference2autorservice.IAutorService {
        
        public AutorServiceClient() {
        }
        
        public AutorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AutorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AutorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AutorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetVersion() {
            return base.Channel.GetVersion();
        }
        
        public System.Threading.Tasks.Task<string> GetVersionAsync() {
            return base.Channel.GetVersionAsync();
        }
    }
}
