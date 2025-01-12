//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by SlSvcUtil, version 5.0.61118.0
// 
namespace WcfServiceHost.Model222
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MobileQuery", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceHost.Model")]
    public partial class MobileQuery : object
    {
        
        private string FamilyField;
        
        private string GenusField;
        
        private string SubfamilyField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Family
        {
            get
            {
                return this.FamilyField;
            }
            set
            {
                this.FamilyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Genus
        {
            get
            {
                return this.GenusField;
            }
            set
            {
                this.GenusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Subfamily
        {
            get
            {
                return this.SubfamilyField;
            }
            set
            {
                this.SubfamilyField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MobileInformation", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceHost.Model")]
    public partial class MobileInformation : object
    {
        
        private string CommonNameField;
        
        private string FamilyField;
        
        private string GenusField;
        
        private string ScientificNameField;
        
        private string SubfamilyField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CommonName
        {
            get
            {
                return this.CommonNameField;
            }
            set
            {
                this.CommonNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Family
        {
            get
            {
                return this.FamilyField;
            }
            set
            {
                this.FamilyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Genus
        {
            get
            {
                return this.GenusField;
            }
            set
            {
                this.GenusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ScientificName
        {
            get
            {
                return this.ScientificNameField;
            }
            set
            {
                this.ScientificNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Subfamily
        {
            get
            {
                return this.SubfamilyField;
            }
            set
            {
                this.SubfamilyField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IMobileService")]
public interface IMobileService
{
    
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMobileService/GetRandomMobileName", ReplyAction="http://tempuri.org/IMobileService/GetRandomMobileNameResponse")]
    System.IAsyncResult BeginGetRandomMobileName(System.AsyncCallback callback, object asyncState);
    
    string EndGetRandomMobileName(System.IAsyncResult result);
    
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMobileService/GetMobileMatch", ReplyAction="http://tempuri.org/IMobileService/GetMobileMatchResponse")]
    System.IAsyncResult BeginGetMobileMatch(WcfServiceHost.Model.MobileQuery query, System.AsyncCallback callback, object asyncState);
    
    WcfServiceHost.Model.MobileInformation[] EndGetMobileMatch(System.IAsyncResult result);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IMobileServiceChannel : IMobileService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class GetRandomMobileNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{
    
    private object[] results;
    
    public GetRandomMobileNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState)
    {
        this.results = results;
    }
    
    public string Result
    {
        get
        {
            base.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class GetMobileMatchCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{
    
    private object[] results;
    
    public GetMobileMatchCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState)
    {
        this.results = results;
    }
    
    public WcfServiceHost.Model.MobileInformation[] Result
    {
        get
        {
            base.RaiseExceptionIfNecessary();
            return ((WcfServiceHost.Model.MobileInformation[])(this.results[0]));
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class MobileServiceClient : System.ServiceModel.ClientBase<IMobileService>, IMobileService
{
    
    private BeginOperationDelegate onBeginGetRandomMobileNameDelegate;
    
    private EndOperationDelegate onEndGetRandomMobileNameDelegate;
    
    private System.Threading.SendOrPostCallback onGetRandomMobileNameCompletedDelegate;
    
    private BeginOperationDelegate onBeginGetMobileMatchDelegate;
    
    private EndOperationDelegate onEndGetMobileMatchDelegate;
    
    private System.Threading.SendOrPostCallback onGetMobileMatchCompletedDelegate;
    
    private BeginOperationDelegate onBeginOpenDelegate;
    
    private EndOperationDelegate onEndOpenDelegate;
    
    private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
    
    private BeginOperationDelegate onBeginCloseDelegate;
    
    private EndOperationDelegate onEndCloseDelegate;
    
    private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
    
    public MobileServiceClient()
    {
    }
    
    public MobileServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public MobileServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public MobileServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public MobileServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public System.Net.CookieContainer CookieContainer
    {
        get
        {
            System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
            if ((httpCookieContainerManager != null))
            {
                return httpCookieContainerManager.CookieContainer;
            }
            else
            {
                return null;
            }
        }
        set
        {
            System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
            if ((httpCookieContainerManager != null))
            {
                httpCookieContainerManager.CookieContainer = value;
            }
            else
            {
                throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                        "ookieContainerBindingElement.");
            }
        }
    }
    
    public event System.EventHandler<GetRandomMobileNameCompletedEventArgs> GetRandomMobileNameCompleted;
    
    public event System.EventHandler<GetMobileMatchCompletedEventArgs> GetMobileMatchCompleted;
    
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
    
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult IMobileService.BeginGetRandomMobileName(System.AsyncCallback callback, object asyncState)
    {
        return base.Channel.BeginGetRandomMobileName(callback, asyncState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    string IMobileService.EndGetRandomMobileName(System.IAsyncResult result)
    {
        return base.Channel.EndGetRandomMobileName(result);
    }
    
    private System.IAsyncResult OnBeginGetRandomMobileName(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        return ((IMobileService)(this)).BeginGetRandomMobileName(callback, asyncState);
    }
    
    private object[] OnEndGetRandomMobileName(System.IAsyncResult result)
    {
        string retVal = ((IMobileService)(this)).EndGetRandomMobileName(result);
        return new object[] {
                retVal};
    }
    
    private void OnGetRandomMobileNameCompleted(object state)
    {
        if ((this.GetRandomMobileNameCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.GetRandomMobileNameCompleted(this, new GetRandomMobileNameCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void GetRandomMobileNameAsync()
    {
        this.GetRandomMobileNameAsync(null);
    }
    
    public void GetRandomMobileNameAsync(object userState)
    {
        if ((this.onBeginGetRandomMobileNameDelegate == null))
        {
            this.onBeginGetRandomMobileNameDelegate = new BeginOperationDelegate(this.OnBeginGetRandomMobileName);
        }
        if ((this.onEndGetRandomMobileNameDelegate == null))
        {
            this.onEndGetRandomMobileNameDelegate = new EndOperationDelegate(this.OnEndGetRandomMobileName);
        }
        if ((this.onGetRandomMobileNameCompletedDelegate == null))
        {
            this.onGetRandomMobileNameCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetRandomMobileNameCompleted);
        }
        base.InvokeAsync(this.onBeginGetRandomMobileNameDelegate, null, this.onEndGetRandomMobileNameDelegate, this.onGetRandomMobileNameCompletedDelegate, userState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult IMobileService.BeginGetMobileMatch(WcfServiceHost.Model.MobileQuery query, System.AsyncCallback callback, object asyncState)
    {
        return base.Channel.BeginGetMobileMatch(query, callback, asyncState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    WcfServiceHost.Model.MobileInformation[] IMobileService.EndGetMobileMatch(System.IAsyncResult result)
    {
        return base.Channel.EndGetMobileMatch(result);
    }
    
    private System.IAsyncResult OnBeginGetMobileMatch(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        WcfServiceHost.Model.MobileQuery query = ((WcfServiceHost.Model.MobileQuery)(inValues[0]));
        return ((IMobileService)(this)).BeginGetMobileMatch(query, callback, asyncState);
    }
    
    private object[] OnEndGetMobileMatch(System.IAsyncResult result)
    {
        WcfServiceHost.Model.MobileInformation[] retVal = ((IMobileService)(this)).EndGetMobileMatch(result);
        return new object[] {
                retVal};
    }
    
    private void OnGetMobileMatchCompleted(object state)
    {
        if ((this.GetMobileMatchCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.GetMobileMatchCompleted(this, new GetMobileMatchCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void GetMobileMatchAsync(WcfServiceHost.Model.MobileQuery query)
    {
        this.GetMobileMatchAsync(query, null);
    }
    
    public void GetMobileMatchAsync(WcfServiceHost.Model.MobileQuery query, object userState)
    {
        if ((this.onBeginGetMobileMatchDelegate == null))
        {
            this.onBeginGetMobileMatchDelegate = new BeginOperationDelegate(this.OnBeginGetMobileMatch);
        }
        if ((this.onEndGetMobileMatchDelegate == null))
        {
            this.onEndGetMobileMatchDelegate = new EndOperationDelegate(this.OnEndGetMobileMatch);
        }
        if ((this.onGetMobileMatchCompletedDelegate == null))
        {
            this.onGetMobileMatchCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetMobileMatchCompleted);
        }
        base.InvokeAsync(this.onBeginGetMobileMatchDelegate, new object[] {
                    query}, this.onEndGetMobileMatchDelegate, this.onGetMobileMatchCompletedDelegate, userState);
    }
    
    private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
    }
    
    private object[] OnEndOpen(System.IAsyncResult result)
    {
        ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
        return null;
    }
    
    private void OnOpenCompleted(object state)
    {
        if ((this.OpenCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void OpenAsync()
    {
        this.OpenAsync(null);
    }
    
    public void OpenAsync(object userState)
    {
        if ((this.onBeginOpenDelegate == null))
        {
            this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
        }
        if ((this.onEndOpenDelegate == null))
        {
            this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
        }
        if ((this.onOpenCompletedDelegate == null))
        {
            this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
        }
        base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
    }
    
    private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
    }
    
    private object[] OnEndClose(System.IAsyncResult result)
    {
        ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
        return null;
    }
    
    private void OnCloseCompleted(object state)
    {
        if ((this.CloseCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void CloseAsync()
    {
        this.CloseAsync(null);
    }
    
    public void CloseAsync(object userState)
    {
        if ((this.onBeginCloseDelegate == null))
        {
            this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
        }
        if ((this.onEndCloseDelegate == null))
        {
            this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
        }
        if ((this.onCloseCompletedDelegate == null))
        {
            this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
        }
        base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
    }
    
    protected override IMobileService CreateChannel()
    {
        return new MobileServiceClientChannel(this);
    }
    
    private class MobileServiceClientChannel : ChannelBase<IMobileService>, IMobileService
    {
        
        public MobileServiceClientChannel(System.ServiceModel.ClientBase<IMobileService> client) : 
                base(client)
        {
        }
        
        public System.IAsyncResult BeginGetRandomMobileName(System.AsyncCallback callback, object asyncState)
        {
            object[] _args = new object[0];
            System.IAsyncResult _result = base.BeginInvoke("GetRandomMobileName", _args, callback, asyncState);
            return _result;
        }
        
        public string EndGetRandomMobileName(System.IAsyncResult result)
        {
            object[] _args = new object[0];
            string _result = ((string)(base.EndInvoke("GetRandomMobileName", _args, result)));
            return _result;
        }
        
        public System.IAsyncResult BeginGetMobileMatch(WcfServiceHost.Model.MobileQuery query, System.AsyncCallback callback, object asyncState)
        {
            object[] _args = new object[1];
            _args[0] = query;
            System.IAsyncResult _result = base.BeginInvoke("GetMobileMatch", _args, callback, asyncState);
            return _result;
        }
        
        public WcfServiceHost.Model.MobileInformation[] EndGetMobileMatch(System.IAsyncResult result)
        {
            object[] _args = new object[0];
            WcfServiceHost.Model.MobileInformation[] _result = ((WcfServiceHost.Model.MobileInformation[])(base.EndInvoke("GetMobileMatch", _args, result)));
            return _result;
        }
    }
}
