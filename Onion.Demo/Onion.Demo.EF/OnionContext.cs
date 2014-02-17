using System.Data.Entity;
using Onion.Demo.DM;

namespace Onion.Demo.EF
{
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