using EvokeProjectWithApi.Models;
using EvokeProjectWithApi.Models.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;


namespace EvokeProjectWithApi.Controllers {
    public class EmployeeController : ApiController {
        // GET api/Employee
        public IEnumerable<DecaratedMan> Get () {
            using (CompanyContext context = new CompanyContext()) {
                ManSortStrategy manSortStrategy = null;
                if (new Random().Next(0, 2) == 0) {
                    manSortStrategy = new SortByName();
                } else {
                    manSortStrategy = new SortByAge();
                }
                var data = context.Employees.ToList();
                List<DecaratedMan> people = new List<DecaratedMan>();
                foreach (var employee in data) {
                    Man.Builder builder = new Man.Builder()
                         .SetName(employee.Name)
                         .SetAge(employee.Age)
                         .SetEmail(employee.Email)
                         .SetPhone(employee.Phone);
                    people.Add(new DecaratedMan(builder.build()));
                }
                return manSortStrategy.filter(people);
            }
        }
    }
}