using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.SqlServerCompact;
using System.Data.SqlServerCe;
using System.Diagnostics;

namespace Onion.Demo.EF
{
    public class OnionConfiguration : DbConfiguration
    {
        public OnionConfiguration()
        {
            SetDatabaseLogFormatter((context, action) =>
                new DatabaseLogFormatter(s => Debug.WriteLine(s)));
            SetProviderServices(SqlCeProviderServices.ProviderInvariantName, SqlCeProviderServices.Instance);
            SetProviderFactory(SqlCeProviderServices.ProviderInvariantName, new SqlCeProviderFactory());
            SetExecutionStrategy(SqlCeProviderServices.ProviderInvariantName, () => new DefaultExecutionStrategy());
        }
    }
}