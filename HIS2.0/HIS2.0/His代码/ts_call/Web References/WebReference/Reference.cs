﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.5477
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 2.0.50727.5477 版自动生成。
// 
#pragma warning disable 1591

namespace ts_call.WebReference {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5483")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WHCentralhospitalSoap", Namespace="http://tempuri.org/")]
    public partial class WHCentralhospital : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddDoctortoDdepartmentOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteDoctortoDdepartmentOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddRegisterInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback OutRegisterInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetdrugInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeletedrugInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback TollboothInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReturnpremiumOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddItemOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WHCentralhospital() {
            this.Url = global::ts_call.Properties.Settings.Default.ts_call_WebReference_WHCentralhospital;
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
        public event AddDoctortoDdepartmentCompletedEventHandler AddDoctortoDdepartmentCompleted;
        
        /// <remarks/>
        public event DeleteDoctortoDdepartmentCompletedEventHandler DeleteDoctortoDdepartmentCompleted;
        
        /// <remarks/>
        public event AddRegisterInfoCompletedEventHandler AddRegisterInfoCompleted;
        
        /// <remarks/>
        public event OutRegisterInfoCompletedEventHandler OutRegisterInfoCompleted;
        
        /// <remarks/>
        public event GetdrugInfoCompletedEventHandler GetdrugInfoCompleted;
        
        /// <remarks/>
        public event DeletedrugInfoCompletedEventHandler DeletedrugInfoCompleted;
        
        /// <remarks/>
        public event TollboothInfoCompletedEventHandler TollboothInfoCompleted;
        
        /// <remarks/>
        public event ReturnpremiumCompletedEventHandler ReturnpremiumCompleted;
        
        /// <remarks/>
        public event AddItemCompletedEventHandler AddItemCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddDoctortoDdepartment", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddDoctortoDdepartment(string strxml) {
            object[] results = this.Invoke("AddDoctortoDdepartment", new object[] {
                        strxml});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddDoctortoDdepartmentAsync(string strxml) {
            this.AddDoctortoDdepartmentAsync(strxml, null);
        }
        
        /// <remarks/>
        public void AddDoctortoDdepartmentAsync(string strxml, object userState) {
            if ((this.AddDoctortoDdepartmentOperationCompleted == null)) {
                this.AddDoctortoDdepartmentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddDoctortoDdepartmentOperationCompleted);
            }
            this.InvokeAsync("AddDoctortoDdepartment", new object[] {
                        strxml}, this.AddDoctortoDdepartmentOperationCompleted, userState);
        }
        
        private void OnAddDoctortoDdepartmentOperationCompleted(object arg) {
            if ((this.AddDoctortoDdepartmentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddDoctortoDdepartmentCompleted(this, new AddDoctortoDdepartmentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteDoctortoDdepartment", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteDoctortoDdepartment(string strxml) {
            object[] results = this.Invoke("DeleteDoctortoDdepartment", new object[] {
                        strxml});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteDoctortoDdepartmentAsync(string strxml) {
            this.DeleteDoctortoDdepartmentAsync(strxml, null);
        }
        
        /// <remarks/>
        public void DeleteDoctortoDdepartmentAsync(string strxml, object userState) {
            if ((this.DeleteDoctortoDdepartmentOperationCompleted == null)) {
                this.DeleteDoctortoDdepartmentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteDoctortoDdepartmentOperationCompleted);
            }
            this.InvokeAsync("DeleteDoctortoDdepartment", new object[] {
                        strxml}, this.DeleteDoctortoDdepartmentOperationCompleted, userState);
        }
        
        private void OnDeleteDoctortoDdepartmentOperationCompleted(object arg) {
            if ((this.DeleteDoctortoDdepartmentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteDoctortoDdepartmentCompleted(this, new DeleteDoctortoDdepartmentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddRegisterInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddRegisterInfo(string strxml) {
            object[] results = this.Invoke("AddRegisterInfo", new object[] {
                        strxml});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddRegisterInfoAsync(string strxml) {
            this.AddRegisterInfoAsync(strxml, null);
        }
        
        /// <remarks/>
        public void AddRegisterInfoAsync(string strxml, object userState) {
            if ((this.AddRegisterInfoOperationCompleted == null)) {
                this.AddRegisterInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddRegisterInfoOperationCompleted);
            }
            this.InvokeAsync("AddRegisterInfo", new object[] {
                        strxml}, this.AddRegisterInfoOperationCompleted, userState);
        }
        
        private void OnAddRegisterInfoOperationCompleted(object arg) {
            if ((this.AddRegisterInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddRegisterInfoCompleted(this, new AddRegisterInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/OutRegisterInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string OutRegisterInfo(string strxml) {
            object[] results = this.Invoke("OutRegisterInfo", new object[] {
                        strxml});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void OutRegisterInfoAsync(string strxml) {
            this.OutRegisterInfoAsync(strxml, null);
        }
        
        /// <remarks/>
        public void OutRegisterInfoAsync(string strxml, object userState) {
            if ((this.OutRegisterInfoOperationCompleted == null)) {
                this.OutRegisterInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnOutRegisterInfoOperationCompleted);
            }
            this.InvokeAsync("OutRegisterInfo", new object[] {
                        strxml}, this.OutRegisterInfoOperationCompleted, userState);
        }
        
        private void OnOutRegisterInfoOperationCompleted(object arg) {
            if ((this.OutRegisterInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.OutRegisterInfoCompleted(this, new OutRegisterInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetdrugInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetdrugInfo(string strxml) {
            object[] results = this.Invoke("GetdrugInfo", new object[] {
                        strxml});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetdrugInfoAsync(string strxml) {
            this.GetdrugInfoAsync(strxml, null);
        }
        
        /// <remarks/>
        public void GetdrugInfoAsync(string strxml, object userState) {
            if ((this.GetdrugInfoOperationCompleted == null)) {
                this.GetdrugInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetdrugInfoOperationCompleted);
            }
            this.InvokeAsync("GetdrugInfo", new object[] {
                        strxml}, this.GetdrugInfoOperationCompleted, userState);
        }
        
        private void OnGetdrugInfoOperationCompleted(object arg) {
            if ((this.GetdrugInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetdrugInfoCompleted(this, new GetdrugInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeletedrugInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeletedrugInfo(string strxml) {
            object[] results = this.Invoke("DeletedrugInfo", new object[] {
                        strxml});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DeletedrugInfoAsync(string strxml) {
            this.DeletedrugInfoAsync(strxml, null);
        }
        
        /// <remarks/>
        public void DeletedrugInfoAsync(string strxml, object userState) {
            if ((this.DeletedrugInfoOperationCompleted == null)) {
                this.DeletedrugInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeletedrugInfoOperationCompleted);
            }
            this.InvokeAsync("DeletedrugInfo", new object[] {
                        strxml}, this.DeletedrugInfoOperationCompleted, userState);
        }
        
        private void OnDeletedrugInfoOperationCompleted(object arg) {
            if ((this.DeletedrugInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeletedrugInfoCompleted(this, new DeletedrugInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/TollboothInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string TollboothInfo(string strxml) {
            object[] results = this.Invoke("TollboothInfo", new object[] {
                        strxml});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void TollboothInfoAsync(string strxml) {
            this.TollboothInfoAsync(strxml, null);
        }
        
        /// <remarks/>
        public void TollboothInfoAsync(string strxml, object userState) {
            if ((this.TollboothInfoOperationCompleted == null)) {
                this.TollboothInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTollboothInfoOperationCompleted);
            }
            this.InvokeAsync("TollboothInfo", new object[] {
                        strxml}, this.TollboothInfoOperationCompleted, userState);
        }
        
        private void OnTollboothInfoOperationCompleted(object arg) {
            if ((this.TollboothInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TollboothInfoCompleted(this, new TollboothInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Returnpremium", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Returnpremium(string strxml) {
            object[] results = this.Invoke("Returnpremium", new object[] {
                        strxml});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ReturnpremiumAsync(string strxml) {
            this.ReturnpremiumAsync(strxml, null);
        }
        
        /// <remarks/>
        public void ReturnpremiumAsync(string strxml, object userState) {
            if ((this.ReturnpremiumOperationCompleted == null)) {
                this.ReturnpremiumOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReturnpremiumOperationCompleted);
            }
            this.InvokeAsync("Returnpremium", new object[] {
                        strxml}, this.ReturnpremiumOperationCompleted, userState);
        }
        
        private void OnReturnpremiumOperationCompleted(object arg) {
            if ((this.ReturnpremiumCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReturnpremiumCompleted(this, new ReturnpremiumCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddItem", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddItem(string strxml) {
            object[] results = this.Invoke("AddItem", new object[] {
                        strxml});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddItemAsync(string strxml) {
            this.AddItemAsync(strxml, null);
        }
        
        /// <remarks/>
        public void AddItemAsync(string strxml, object userState) {
            if ((this.AddItemOperationCompleted == null)) {
                this.AddItemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddItemOperationCompleted);
            }
            this.InvokeAsync("AddItem", new object[] {
                        strxml}, this.AddItemOperationCompleted, userState);
        }
        
        private void OnAddItemOperationCompleted(object arg) {
            if ((this.AddItemCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddItemCompleted(this, new AddItemCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5483")]
    public delegate void AddDoctortoDdepartmentCompletedEventHandler(object sender, AddDoctortoDdepartmentCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5483")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddDoctortoDdepartmentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddDoctortoDdepartmentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5483")]
    public delegate void DeleteDoctortoDdepartmentCompletedEventHandler(object sender, DeleteDoctortoDdepartmentCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5483")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteDoctortoDdepartmentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteDoctortoDdepartmentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5483")]
    public delegate void AddRegisterInfoCompletedEventHandler(object sender, AddRegisterInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5483")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddRegisterInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddRegisterInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5483")]
    public delegate void OutRegisterInfoCompletedEventHandler(object sender, OutRegisterInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5483")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OutRegisterInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal OutRegisterInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5483")]
    public delegate void GetdrugInfoCompletedEventHandler(object sender, GetdrugInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5483")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetdrugInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetdrugInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5483")]
    public delegate void DeletedrugInfoCompletedEventHandler(object sender, DeletedrugInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5483")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeletedrugInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeletedrugInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5483")]
    public delegate void TollboothInfoCompletedEventHandler(object sender, TollboothInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5483")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TollboothInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TollboothInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5483")]
    public delegate void ReturnpremiumCompletedEventHandler(object sender, ReturnpremiumCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5483")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReturnpremiumCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReturnpremiumCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5483")]
    public delegate void AddItemCompletedEventHandler(object sender, AddItemCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5483")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddItemCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddItemCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
}

#pragma warning restore 1591