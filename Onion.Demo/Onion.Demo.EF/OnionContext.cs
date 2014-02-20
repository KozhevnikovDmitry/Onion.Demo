using System.Data.Entity;
using Onion.Demo.DomainModel;

namespace Onion.Demo.EF
{
    [DbConfigurationType(typeof(OnionConfiguration))]
    public class OnionContext : DbContext
    {
        public OnionContext()
            : base("OnionDemo")
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
        }
    }
}