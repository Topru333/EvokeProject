using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EvokeProjectWithApi.Models.DataAccessLayer {
    public class CompanyContext : DbContext {
        public CompanyContext () : base("CompanyContext") {
        }

        public DbSet<Employee> Employees {
            get; set;
        }

        public DbSet<Candidate> Candidates {
            get; set;
        }

        protected override void OnModelCreating (DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}