using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServerCompact;
using System.Data.SqlServerCe;

namespace Onion.Demo.EF
{
    public class OnionConfiguration : DbConfiguration
    {
        public OnionConfiguration()
        {
            SetProviderServices(SqlCeProviderServices.ProviderInvariantName, SqlCeProviderServices.Instance);
            SetProviderFactory(SqlCeProviderServices.ProviderInvariantName, new SqlCeProviderFactory());
            SetExecutionStrategy(SqlCeProviderServices.ProviderInvariantName, () => new DefaultExecutionStrategy());
        }
    }
}