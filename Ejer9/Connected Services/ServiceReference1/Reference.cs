﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ejer9.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Ejer9.ServiceReference1.HelloWorldResponse HelloWorld(Ejer9.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Ejer9.ServiceReference1.HelloWorldResponse> HelloWorldAsync(Ejer9.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombre del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ModificarPersona", ReplyAction="*")]
        Ejer9.ServiceReference1.ModificarPersonaResponse ModificarPersona(Ejer9.ServiceReference1.ModificarPersonaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ModificarPersona", ReplyAction="*")]
        System.Threading.Tasks.Task<Ejer9.ServiceReference1.ModificarPersonaResponse> ModificarPersonaAsync(Ejer9.ServiceReference1.ModificarPersonaRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombre del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarPersona", ReplyAction="*")]
        Ejer9.ServiceReference1.AgregarPersonaResponse AgregarPersona(Ejer9.ServiceReference1.AgregarPersonaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarPersona", ReplyAction="*")]
        System.Threading.Tasks.Task<Ejer9.ServiceReference1.AgregarPersonaResponse> AgregarPersonaAsync(Ejer9.ServiceReference1.AgregarPersonaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarPersona", ReplyAction="*")]
        int EliminarPersona(int persona_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarPersona", ReplyAction="*")]
        System.Threading.Tasks.Task<int> EliminarPersonaAsync(int persona_id);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Ejer9.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Ejer9.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public Ejer9.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Ejer9.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ModificarPersonaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ModificarPersona", Namespace="http://tempuri.org/", Order=0)]
        public Ejer9.ServiceReference1.ModificarPersonaRequestBody Body;
        
        public ModificarPersonaRequest() {
        }
        
        public ModificarPersonaRequest(Ejer9.ServiceReference1.ModificarPersonaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ModificarPersonaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int persona_id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ap_paterno;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string ap_materno;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string tipo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string correo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string departamento;
        
        public ModificarPersonaRequestBody() {
        }
        
        public ModificarPersonaRequestBody(int persona_id, string nombre, string ap_paterno, string ap_materno, string tipo, string correo, string departamento) {
            this.persona_id = persona_id;
            this.nombre = nombre;
            this.ap_paterno = ap_paterno;
            this.ap_materno = ap_materno;
            this.tipo = tipo;
            this.correo = correo;
            this.departamento = departamento;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ModificarPersonaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ModificarPersonaResponse", Namespace="http://tempuri.org/", Order=0)]
        public Ejer9.ServiceReference1.ModificarPersonaResponseBody Body;
        
        public ModificarPersonaResponse() {
        }
        
        public ModificarPersonaResponse(Ejer9.ServiceReference1.ModificarPersonaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ModificarPersonaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int ModificarPersonaResult;
        
        public ModificarPersonaResponseBody() {
        }
        
        public ModificarPersonaResponseBody(int ModificarPersonaResult) {
            this.ModificarPersonaResult = ModificarPersonaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarPersonaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarPersona", Namespace="http://tempuri.org/", Order=0)]
        public Ejer9.ServiceReference1.AgregarPersonaRequestBody Body;
        
        public AgregarPersonaRequest() {
        }
        
        public AgregarPersonaRequest(Ejer9.ServiceReference1.AgregarPersonaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarPersonaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string ap_paterno;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ap_materno;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string tipo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string correo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string departamento;
        
        public AgregarPersonaRequestBody() {
        }
        
        public AgregarPersonaRequestBody(string nombre, string ap_paterno, string ap_materno, string tipo, string correo, string departamento) {
            this.nombre = nombre;
            this.ap_paterno = ap_paterno;
            this.ap_materno = ap_materno;
            this.tipo = tipo;
            this.correo = correo;
            this.departamento = departamento;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarPersonaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarPersonaResponse", Namespace="http://tempuri.org/", Order=0)]
        public Ejer9.ServiceReference1.AgregarPersonaResponseBody Body;
        
        public AgregarPersonaResponse() {
        }
        
        public AgregarPersonaResponse(Ejer9.ServiceReference1.AgregarPersonaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarPersonaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int AgregarPersonaResult;
        
        public AgregarPersonaResponseBody() {
        }
        
        public AgregarPersonaResponseBody(int AgregarPersonaResult) {
            this.AgregarPersonaResult = AgregarPersonaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Ejer9.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Ejer9.ServiceReference1.WebService1Soap>, Ejer9.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Ejer9.ServiceReference1.HelloWorldResponse Ejer9.ServiceReference1.WebService1Soap.HelloWorld(Ejer9.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Ejer9.ServiceReference1.HelloWorldRequest inValue = new Ejer9.ServiceReference1.HelloWorldRequest();
            inValue.Body = new Ejer9.ServiceReference1.HelloWorldRequestBody();
            Ejer9.ServiceReference1.HelloWorldResponse retVal = ((Ejer9.ServiceReference1.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Ejer9.ServiceReference1.HelloWorldResponse> Ejer9.ServiceReference1.WebService1Soap.HelloWorldAsync(Ejer9.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Ejer9.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            Ejer9.ServiceReference1.HelloWorldRequest inValue = new Ejer9.ServiceReference1.HelloWorldRequest();
            inValue.Body = new Ejer9.ServiceReference1.HelloWorldRequestBody();
            return ((Ejer9.ServiceReference1.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Ejer9.ServiceReference1.ModificarPersonaResponse Ejer9.ServiceReference1.WebService1Soap.ModificarPersona(Ejer9.ServiceReference1.ModificarPersonaRequest request) {
            return base.Channel.ModificarPersona(request);
        }
        
        public int ModificarPersona(int persona_id, string nombre, string ap_paterno, string ap_materno, string tipo, string correo, string departamento) {
            Ejer9.ServiceReference1.ModificarPersonaRequest inValue = new Ejer9.ServiceReference1.ModificarPersonaRequest();
            inValue.Body = new Ejer9.ServiceReference1.ModificarPersonaRequestBody();
            inValue.Body.persona_id = persona_id;
            inValue.Body.nombre = nombre;
            inValue.Body.ap_paterno = ap_paterno;
            inValue.Body.ap_materno = ap_materno;
            inValue.Body.tipo = tipo;
            inValue.Body.correo = correo;
            inValue.Body.departamento = departamento;
            Ejer9.ServiceReference1.ModificarPersonaResponse retVal = ((Ejer9.ServiceReference1.WebService1Soap)(this)).ModificarPersona(inValue);
            return retVal.Body.ModificarPersonaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Ejer9.ServiceReference1.ModificarPersonaResponse> Ejer9.ServiceReference1.WebService1Soap.ModificarPersonaAsync(Ejer9.ServiceReference1.ModificarPersonaRequest request) {
            return base.Channel.ModificarPersonaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Ejer9.ServiceReference1.ModificarPersonaResponse> ModificarPersonaAsync(int persona_id, string nombre, string ap_paterno, string ap_materno, string tipo, string correo, string departamento) {
            Ejer9.ServiceReference1.ModificarPersonaRequest inValue = new Ejer9.ServiceReference1.ModificarPersonaRequest();
            inValue.Body = new Ejer9.ServiceReference1.ModificarPersonaRequestBody();
            inValue.Body.persona_id = persona_id;
            inValue.Body.nombre = nombre;
            inValue.Body.ap_paterno = ap_paterno;
            inValue.Body.ap_materno = ap_materno;
            inValue.Body.tipo = tipo;
            inValue.Body.correo = correo;
            inValue.Body.departamento = departamento;
            return ((Ejer9.ServiceReference1.WebService1Soap)(this)).ModificarPersonaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Ejer9.ServiceReference1.AgregarPersonaResponse Ejer9.ServiceReference1.WebService1Soap.AgregarPersona(Ejer9.ServiceReference1.AgregarPersonaRequest request) {
            return base.Channel.AgregarPersona(request);
        }
        
        public int AgregarPersona(string nombre, string ap_paterno, string ap_materno, string tipo, string correo, string departamento) {
            Ejer9.ServiceReference1.AgregarPersonaRequest inValue = new Ejer9.ServiceReference1.AgregarPersonaRequest();
            inValue.Body = new Ejer9.ServiceReference1.AgregarPersonaRequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.ap_paterno = ap_paterno;
            inValue.Body.ap_materno = ap_materno;
            inValue.Body.tipo = tipo;
            inValue.Body.correo = correo;
            inValue.Body.departamento = departamento;
            Ejer9.ServiceReference1.AgregarPersonaResponse retVal = ((Ejer9.ServiceReference1.WebService1Soap)(this)).AgregarPersona(inValue);
            return retVal.Body.AgregarPersonaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Ejer9.ServiceReference1.AgregarPersonaResponse> Ejer9.ServiceReference1.WebService1Soap.AgregarPersonaAsync(Ejer9.ServiceReference1.AgregarPersonaRequest request) {
            return base.Channel.AgregarPersonaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Ejer9.ServiceReference1.AgregarPersonaResponse> AgregarPersonaAsync(string nombre, string ap_paterno, string ap_materno, string tipo, string correo, string departamento) {
            Ejer9.ServiceReference1.AgregarPersonaRequest inValue = new Ejer9.ServiceReference1.AgregarPersonaRequest();
            inValue.Body = new Ejer9.ServiceReference1.AgregarPersonaRequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.ap_paterno = ap_paterno;
            inValue.Body.ap_materno = ap_materno;
            inValue.Body.tipo = tipo;
            inValue.Body.correo = correo;
            inValue.Body.departamento = departamento;
            return ((Ejer9.ServiceReference1.WebService1Soap)(this)).AgregarPersonaAsync(inValue);
        }
        
        public int EliminarPersona(int persona_id) {
            return base.Channel.EliminarPersona(persona_id);
        }
        
        public System.Threading.Tasks.Task<int> EliminarPersonaAsync(int persona_id) {
            return base.Channel.EliminarPersonaAsync(persona_id);
        }
    }
}
