﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace UserApp.UserRolesApi {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="UserRolesSoap", Namespace="http://tempuri.org/")]
    public partial class UserRoles : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddRequestOperationCompleted;
        
        private System.Threading.SendOrPostCallback isApprovedOperationCompleted;
        
        private System.Threading.SendOrPostCallback CertificateOperationCompleted;
        
        private System.Threading.SendOrPostCallback PrivateKeyOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddControlRequestOperationCompleted;
        
        private System.Threading.SendOrPostCallback ValidateToGetSessionKeyOperationCompleted;
        
        private System.Threading.SendOrPostCallback IOTCommandOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public UserRoles() {
            this.Url = global::UserApp.Properties.Settings.Default.UserApp_UserRolesApi_UserRoles;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event AddRequestCompletedEventHandler AddRequestCompleted;
        
        /// <remarks/>
        public event isApprovedCompletedEventHandler isApprovedCompleted;
        
        /// <remarks/>
        public event CertificateCompletedEventHandler CertificateCompleted;
        
        /// <remarks/>
        public event PrivateKeyCompletedEventHandler PrivateKeyCompleted;
        
        /// <remarks/>
        public event AddControlRequestCompletedEventHandler AddControlRequestCompleted;
        
        /// <remarks/>
        public event ValidateToGetSessionKeyCompletedEventHandler ValidateToGetSessionKeyCompleted;
        
        /// <remarks/>
        public event IOTCommandCompletedEventHandler IOTCommandCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddRequest", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool AddRequest(string username, string macid, string ipaddress, string macname, string date) {
            object[] results = this.Invoke("AddRequest", new object[] {
                        username,
                        macid,
                        ipaddress,
                        macname,
                        date});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void AddRequestAsync(string username, string macid, string ipaddress, string macname, string date) {
            this.AddRequestAsync(username, macid, ipaddress, macname, date, null);
        }
        
        /// <remarks/>
        public void AddRequestAsync(string username, string macid, string ipaddress, string macname, string date, object userState) {
            if ((this.AddRequestOperationCompleted == null)) {
                this.AddRequestOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddRequestOperationCompleted);
            }
            this.InvokeAsync("AddRequest", new object[] {
                        username,
                        macid,
                        ipaddress,
                        macname,
                        date}, this.AddRequestOperationCompleted, userState);
        }
        
        private void OnAddRequestOperationCompleted(object arg) {
            if ((this.AddRequestCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddRequestCompleted(this, new AddRequestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/isApproved", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool isApproved(string user, string macid, string mac) {
            object[] results = this.Invoke("isApproved", new object[] {
                        user,
                        macid,
                        mac});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void isApprovedAsync(string user, string macid, string mac) {
            this.isApprovedAsync(user, macid, mac, null);
        }
        
        /// <remarks/>
        public void isApprovedAsync(string user, string macid, string mac, object userState) {
            if ((this.isApprovedOperationCompleted == null)) {
                this.isApprovedOperationCompleted = new System.Threading.SendOrPostCallback(this.OnisApprovedOperationCompleted);
            }
            this.InvokeAsync("isApproved", new object[] {
                        user,
                        macid,
                        mac}, this.isApprovedOperationCompleted, userState);
        }
        
        private void OnisApprovedOperationCompleted(object arg) {
            if ((this.isApprovedCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.isApprovedCompleted(this, new isApprovedCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Certificate", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Certificate() {
            object[] results = this.Invoke("Certificate", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void CertificateAsync() {
            this.CertificateAsync(null);
        }
        
        /// <remarks/>
        public void CertificateAsync(object userState) {
            if ((this.CertificateOperationCompleted == null)) {
                this.CertificateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCertificateOperationCompleted);
            }
            this.InvokeAsync("Certificate", new object[0], this.CertificateOperationCompleted, userState);
        }
        
        private void OnCertificateOperationCompleted(object arg) {
            if ((this.CertificateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CertificateCompleted(this, new CertificateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/PrivateKey", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string PrivateKey() {
            object[] results = this.Invoke("PrivateKey", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void PrivateKeyAsync() {
            this.PrivateKeyAsync(null);
        }
        
        /// <remarks/>
        public void PrivateKeyAsync(object userState) {
            if ((this.PrivateKeyOperationCompleted == null)) {
                this.PrivateKeyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPrivateKeyOperationCompleted);
            }
            this.InvokeAsync("PrivateKey", new object[0], this.PrivateKeyOperationCompleted, userState);
        }
        
        private void OnPrivateKeyOperationCompleted(object arg) {
            if ((this.PrivateKeyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PrivateKeyCompleted(this, new PrivateKeyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddControlRequest", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool AddControlRequest(ref int id, string user, string macid, string ip, string mac) {
            object[] results = this.Invoke("AddControlRequest", new object[] {
                        id,
                        user,
                        macid,
                        ip,
                        mac});
            id = ((int)(results[1]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void AddControlRequestAsync(int id, string user, string macid, string ip, string mac) {
            this.AddControlRequestAsync(id, user, macid, ip, mac, null);
        }
        
        /// <remarks/>
        public void AddControlRequestAsync(int id, string user, string macid, string ip, string mac, object userState) {
            if ((this.AddControlRequestOperationCompleted == null)) {
                this.AddControlRequestOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddControlRequestOperationCompleted);
            }
            this.InvokeAsync("AddControlRequest", new object[] {
                        id,
                        user,
                        macid,
                        ip,
                        mac}, this.AddControlRequestOperationCompleted, userState);
        }
        
        private void OnAddControlRequestOperationCompleted(object arg) {
            if ((this.AddControlRequestCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddControlRequestCompleted(this, new AddControlRequestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ValidateToGetSessionKey", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool ValidateToGetSessionKey(string reqid, ref string sessionkey) {
            object[] results = this.Invoke("ValidateToGetSessionKey", new object[] {
                        reqid,
                        sessionkey});
            sessionkey = ((string)(results[1]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ValidateToGetSessionKeyAsync(string reqid, string sessionkey) {
            this.ValidateToGetSessionKeyAsync(reqid, sessionkey, null);
        }
        
        /// <remarks/>
        public void ValidateToGetSessionKeyAsync(string reqid, string sessionkey, object userState) {
            if ((this.ValidateToGetSessionKeyOperationCompleted == null)) {
                this.ValidateToGetSessionKeyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnValidateToGetSessionKeyOperationCompleted);
            }
            this.InvokeAsync("ValidateToGetSessionKey", new object[] {
                        reqid,
                        sessionkey}, this.ValidateToGetSessionKeyOperationCompleted, userState);
        }
        
        private void OnValidateToGetSessionKeyOperationCompleted(object arg) {
            if ((this.ValidateToGetSessionKeyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ValidateToGetSessionKeyCompleted(this, new ValidateToGetSessionKeyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IOTCommand", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool IOTCommand(string key, string command) {
            object[] results = this.Invoke("IOTCommand", new object[] {
                        key,
                        command});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void IOTCommandAsync(string key, string command) {
            this.IOTCommandAsync(key, command, null);
        }
        
        /// <remarks/>
        public void IOTCommandAsync(string key, string command, object userState) {
            if ((this.IOTCommandOperationCompleted == null)) {
                this.IOTCommandOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIOTCommandOperationCompleted);
            }
            this.InvokeAsync("IOTCommand", new object[] {
                        key,
                        command}, this.IOTCommandOperationCompleted, userState);
        }
        
        private void OnIOTCommandOperationCompleted(object arg) {
            if ((this.IOTCommandCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.IOTCommandCompleted(this, new IOTCommandCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void AddRequestCompletedEventHandler(object sender, AddRequestCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddRequestCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddRequestCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void isApprovedCompletedEventHandler(object sender, isApprovedCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class isApprovedCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal isApprovedCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void CertificateCompletedEventHandler(object sender, CertificateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CertificateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CertificateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void PrivateKeyCompletedEventHandler(object sender, PrivateKeyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PrivateKeyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PrivateKeyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void AddControlRequestCompletedEventHandler(object sender, AddControlRequestCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddControlRequestCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddControlRequestCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public int id {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void ValidateToGetSessionKeyCompletedEventHandler(object sender, ValidateToGetSessionKeyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ValidateToGetSessionKeyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ValidateToGetSessionKeyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string sessionkey {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void IOTCommandCompletedEventHandler(object sender, IOTCommandCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IOTCommandCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal IOTCommandCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591