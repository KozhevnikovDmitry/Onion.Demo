using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;

namespace Onion.Demo.NH
{
    public class Schema
    {
        public Schema()
        {
            Config = MsSqlCeConfiguration.MsSqlCe40
                                         .ConnectionString(c => c.FromConnectionStringWithKey("OnionDemo"))
                                         .FormatSql()
                                         .ShowSql();
        }

        public Configuration GetConfig()
        {
            return Fluently.Configure()
                           .Database(Config)
                           .Mappings(m => m.FluentMappings.AddFromAssembly(typeof(EmployeeMap).Assembly))
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
            return Fluently.Configure(GetConfig()).BuildSessionFactory();
        }

        public IPersistenceConfigurer Config { get; private set; }
    }
}
