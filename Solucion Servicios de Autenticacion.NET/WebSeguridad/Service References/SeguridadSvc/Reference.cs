﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18444
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSeguridad.SeguridadSvc {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SeguridadSvc.ISeguridad")]
    public interface ISeguridad {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISeguridad/ValidarUsuario", ReplyAction="http://tempuri.org/ISeguridad/ValidarUsuarioResponse")]
        bool ValidarUsuario(string Nombre_usuario, string Password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISeguridadChannel : WebSeguridad.SeguridadSvc.ISeguridad, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SeguridadClient : System.ServiceModel.ClientBase<WebSeguridad.SeguridadSvc.ISeguridad>, WebSeguridad.SeguridadSvc.ISeguridad {
        
        public SeguridadClient() {
        }
        
        public SeguridadClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SeguridadClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SeguridadClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SeguridadClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool ValidarUsuario(string Nombre_usuario, string Password) {
            return base.Channel.ValidarUsuario(Nombre_usuario, Password);
        }
    }
}