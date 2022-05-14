﻿using Cassandra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class DataConnection
    {
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
        private static DataConnection _Ins;
        private DataConnection()
        {
            session = getConnect();
            session.Execute("use LibraryManagement;");
        }

        public ISession session;
        private string IP = "127.0.0.1"; 
        private string Datacenter = "datacenter1";
        public ISession getConnect()
        {
            return session = Cluster.Builder()
                                 .AddContactPoints(IP)
                                 .WithPort(9042)
                                 .WithLoadBalancingPolicy(new DCAwareRoundRobinPolicy(Datacenter))
                                 //.WithAuthProvider(new PlainTextAuthProvider(< Username >, < Password >))
                                 .Build()
                                 .Connect();
        }
    }
}