using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WatcherService
{
    [ServiceContract]
    public interface IWatcherService
    {
        [OperationContract]
        void Run();
        [OperationContract]
        void Stop();
        [OperationContract]
        List<DaneZdyskow> WypiszDaneDyskow();
        [OperationContract]
        List<Dane> PobierzListeZmian();
        [OperationContract]
        void GetPath(string sciezka);
    }

    [DataContract]
    public struct Dane
    {
        [DataMember]
        public DateTime czas { get; set; }
        [DataMember]
        public string zmiana { get; set; }
    }
    [DataContract]
    public struct DaneZdyskow
    {
        [DataMember]
        public string a { get; set; }
        [DataMember]
        public string b { get; set; }
        [DataMember]
        public string c { get; set; }
        [DataMember]
        public string d { get; set; }
        [DataMember]
        public string e { get; set; }
        [DataMember]
        public string f { get; set; }
        [DataMember]
        public string g { get; set; }

    }

}
