﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFaplikacja.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DaneZdyskow", Namespace="http://schemas.datacontract.org/2004/07/WatcherService")]
    [System.SerializableAttribute()]
    public partial struct DaneZdyskow : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string aField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string bField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string dField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string eField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string fField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string gField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string a {
            get {
                return this.aField;
            }
            set {
                if ((object.ReferenceEquals(this.aField, value) != true)) {
                    this.aField = value;
                    this.RaisePropertyChanged("a");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string b {
            get {
                return this.bField;
            }
            set {
                if ((object.ReferenceEquals(this.bField, value) != true)) {
                    this.bField = value;
                    this.RaisePropertyChanged("b");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string c {
            get {
                return this.cField;
            }
            set {
                if ((object.ReferenceEquals(this.cField, value) != true)) {
                    this.cField = value;
                    this.RaisePropertyChanged("c");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string d {
            get {
                return this.dField;
            }
            set {
                if ((object.ReferenceEquals(this.dField, value) != true)) {
                    this.dField = value;
                    this.RaisePropertyChanged("d");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string e {
            get {
                return this.eField;
            }
            set {
                if ((object.ReferenceEquals(this.eField, value) != true)) {
                    this.eField = value;
                    this.RaisePropertyChanged("e");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string f {
            get {
                return this.fField;
            }
            set {
                if ((object.ReferenceEquals(this.fField, value) != true)) {
                    this.fField = value;
                    this.RaisePropertyChanged("f");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string g {
            get {
                return this.gField;
            }
            set {
                if ((object.ReferenceEquals(this.gField, value) != true)) {
                    this.gField = value;
                    this.RaisePropertyChanged("g");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Dane", Namespace="http://schemas.datacontract.org/2004/07/WatcherService")]
    [System.SerializableAttribute()]
    public partial struct Dane : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime czasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string zmianaField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime czas {
            get {
                return this.czasField;
            }
            set {
                if ((this.czasField.Equals(value) != true)) {
                    this.czasField = value;
                    this.RaisePropertyChanged("czas");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string zmiana {
            get {
                return this.zmianaField;
            }
            set {
                if ((object.ReferenceEquals(this.zmianaField, value) != true)) {
                    this.zmianaField = value;
                    this.RaisePropertyChanged("zmiana");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IWatcherService")]
    public interface IWatcherService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWatcherService/Run", ReplyAction="http://tempuri.org/IWatcherService/RunResponse")]
        void Run();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWatcherService/Run", ReplyAction="http://tempuri.org/IWatcherService/RunResponse")]
        System.Threading.Tasks.Task RunAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWatcherService/Stop", ReplyAction="http://tempuri.org/IWatcherService/StopResponse")]
        void Stop();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWatcherService/Stop", ReplyAction="http://tempuri.org/IWatcherService/StopResponse")]
        System.Threading.Tasks.Task StopAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWatcherService/WypiszDaneDyskow", ReplyAction="http://tempuri.org/IWatcherService/WypiszDaneDyskowResponse")]
        WPFaplikacja.ServiceReference1.DaneZdyskow[] WypiszDaneDyskow();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWatcherService/WypiszDaneDyskow", ReplyAction="http://tempuri.org/IWatcherService/WypiszDaneDyskowResponse")]
        System.Threading.Tasks.Task<WPFaplikacja.ServiceReference1.DaneZdyskow[]> WypiszDaneDyskowAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWatcherService/PobierzListeZmian", ReplyAction="http://tempuri.org/IWatcherService/PobierzListeZmianResponse")]
        WPFaplikacja.ServiceReference1.Dane[] PobierzListeZmian();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWatcherService/PobierzListeZmian", ReplyAction="http://tempuri.org/IWatcherService/PobierzListeZmianResponse")]
        System.Threading.Tasks.Task<WPFaplikacja.ServiceReference1.Dane[]> PobierzListeZmianAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWatcherService/GetPath", ReplyAction="http://tempuri.org/IWatcherService/GetPathResponse")]
        void GetPath(string sciezka);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWatcherService/GetPath", ReplyAction="http://tempuri.org/IWatcherService/GetPathResponse")]
        System.Threading.Tasks.Task GetPathAsync(string sciezka);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWatcherServiceChannel : WPFaplikacja.ServiceReference1.IWatcherService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WatcherServiceClient : System.ServiceModel.ClientBase<WPFaplikacja.ServiceReference1.IWatcherService>, WPFaplikacja.ServiceReference1.IWatcherService {
        
        public WatcherServiceClient() {
        }
        
        public WatcherServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WatcherServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WatcherServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WatcherServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Run() {
            base.Channel.Run();
        }
        
        public System.Threading.Tasks.Task RunAsync() {
            return base.Channel.RunAsync();
        }
        
        public void Stop() {
            base.Channel.Stop();
        }
        
        public System.Threading.Tasks.Task StopAsync() {
            return base.Channel.StopAsync();
        }
        
        public WPFaplikacja.ServiceReference1.DaneZdyskow[] WypiszDaneDyskow() {
            return base.Channel.WypiszDaneDyskow();
        }
        
        public System.Threading.Tasks.Task<WPFaplikacja.ServiceReference1.DaneZdyskow[]> WypiszDaneDyskowAsync() {
            return base.Channel.WypiszDaneDyskowAsync();
        }
        
        public WPFaplikacja.ServiceReference1.Dane[] PobierzListeZmian() {
            return base.Channel.PobierzListeZmian();
        }
        
        public System.Threading.Tasks.Task<WPFaplikacja.ServiceReference1.Dane[]> PobierzListeZmianAsync() {
            return base.Channel.PobierzListeZmianAsync();
        }
        
        public void GetPath(string sciezka) {
            base.Channel.GetPath(sciezka);
        }
        
        public System.Threading.Tasks.Task GetPathAsync(string sciezka) {
            return base.Channel.GetPathAsync(sciezka);
        }
    }
}
