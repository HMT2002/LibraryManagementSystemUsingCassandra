using Cassandra;
using Cassandra.Serialization;
using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class DataConnection
    {
        private static DataConnection _Ins;
        public static DataConnection Ins
        {
            get
            {
                if (_Ins == null)
                    _Ins = new DataConnection();
                return _Ins;
            }
            set
            {
                _Ins = value;
            }
        }
        private string Datacenter = "datacenter1";
        public ISession session;
        private string IP = "192.168.0.102"; 
        private DataConnection()
        {
            session = getConnect();
            session.Execute("use LibraryManagement;");
        }

        public ISession getConnect()
        {
            TypeSerializerDefinitions definitions = new TypeSerializerDefinitions();
            definitions.Define(new DateCodec());
            return session = Cluster.Builder()
                                 .AddContactPoints(IP)
                                 .WithPort(9042)
                                 .WithLoadBalancingPolicy(new DCAwareRoundRobinPolicy(Datacenter))
                                 .WithTypeSerializers(definitions)
                                 .Build()
                                 .Connect();
        }
    }
}
