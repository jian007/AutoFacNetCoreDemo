using LinqToDB.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.DAL
{
    public class DbSetting
    {
        public class ConnectionStringSettings : IConnectionStringSettings
        {
            public string ConnectionString { get; set; }
            public string Name { get; set; }
            public string ProviderName { get; set; }
            public bool IsGlobal => false;
        }

        public class MySettings : ILinqToDBSettings
        {
            public IEnumerable<IDataProviderSettings> DataProviders => Enumerable.Empty<IDataProviderSettings>();

            public string DefaultConfiguration => "AutofacdemoDB";
            public string DefaultDataProvider => "MySql.Data.MySqlClient";

            public IEnumerable<IConnectionStringSettings> ConnectionStrings
            {
                get
                {
                    yield return
                        new ConnectionStringSettings
                        {
                        //    Name = "SqlServer",
                        //    ProviderName = "SqlServer",
                        //    ConnectionString = @"Server=.\;Database=Northwind;Trusted_Connection=True;Enlist=False;"
                        //Server=MyServer;Port=3306;Database=MyDatabase;Uid=root;Pwd=TestPassword;charset=utf8;
                        Name = "AutofacdemoDB",
                            ProviderName = "MySql.Data.MySqlClient",
                            ConnectionString = @"server=localhost;userid=root;password=root;port=3306;database=Autofacdemo;allowPublicKeyRetrieval=true;Character Set=utf8;"
                        };
                }
            }
        }
    }
}
