using System;
using System.Data.SqlServerCe;
using System.Diagnostics;
using System.IO;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Onion.Demo.NH
{
    internal class Schema
    {
        public Schema()
        {
            Config = MsSqlCeConfiguration.Standard
                                         .ConnectionString(c => c.FromConnectionStringWithKey("OnionDemo"))
                                         .FormatSql()
                                         .ShowSql();
        }

        public Configuration GetConfig()
        {
            return Fluently.Configure()
                           .Database(Config)
                           .Mappings(m => m.FluentMappings.AddFromAssembly(typeof(EmployeeMap).Assembly))
                           .ExposeConfiguration(cfg =>
                                    {
                                        if (!File.Exists("OnionDemo.sdf"))
                                        {
                                            var schema = new SchemaExport(cfg);
                                            var engine = new SqlCeEngine("Data Source=OnionDemo.sdf");
                                            engine.CreateDatabase();
                                            schema.Drop(true, true);
                                            schema.Create(true, true);
                                        }
                                    })
                           .BuildConfiguration()
                           .DataBaseIntegration(db =>
                           {
                               db.LogFormattedSql = true;
                               db.LogSqlInConsole = true;
                               db.AutoCommentSql = true;
                           });
        }

        public ISessionFactory CreateSessionFactory()
        {
            try
            {
                return Fluently.Configure(GetConfig()).BuildSessionFactory();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }
        }

        public IPersistenceConfigurer Config { get; private set; }
    }
}
