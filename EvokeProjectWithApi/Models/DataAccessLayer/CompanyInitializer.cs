using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvokeProjectWithApi.Models.DataAccessLayer {
    public class CompanyInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CompanyContext> {
        protected override void Seed (CompanyContext context) {
            var employees = new List<Employee>
            {
                new Employee{Name="Carson",Email="Alexander@email.com",Age=20, Phone=291111111},
                new Employee{Name="Meredith",Email="Alonso@email.com",Age=21, Phone=292221111},
                new Employee{Name="Arturo",Email="Anand@email.com",Age=22, Phone=293331111},
                new Employee{Name="Gytis",Email="Barzdukas@email.com",Age=23, Phone=294441111},
                new Employee{Name="Yan",Email="Li@email.com",Age=24, Phone=295551111},
                new Employee{Name="Peggy",Email="Justice@email.com",Age=25, Phone=296661111},
                new Employee{Name="Laura",Email="Norman@email.com",Age=26, Phone=297771111},
                new Employee{Name="Nino",Email="Olivetto@email.com",Age=27, Phone=298881111}
            };

            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();

            var candidates = new List<Candidate>
            {
                new Candidate{Name="Alex",Email="Alex@email.com",Age=20, Phone=291111111},
                new Candidate{Name="Murlok",Email="Murlok@email.com",Age=21, Phone=292221111},
                new Candidate{Name="Anduin",Email="Anduin@email.com",Age=22, Phone=293331111},
                new Candidate{Name="Silvana",Email="Silvana@email.com",Age=23, Phone=294441111},
                new Candidate{Name="Shaggy",Email="Shaggy@email.com",Age=24, Phone=295551111},
                new Candidate{Name="Yogsoron",Email="Yogsoron@email.com",Age=25, Phone=296661111},
                new Candidate{Name="Illidan",Email="Illidan@email.com",Age=26, Phone=297771111},
                new Candidate{Name="Thrall",Email="Thrall@email.com",Age=27, Phone=298881111}
            };
            candidates.ForEach(s => context.Candidates.Add(s));
            context.SaveChanges();
        }
    }
}