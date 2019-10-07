using EvokeProjectWithApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;


namespace EvokeProjectWithApi.Controllers {
    public class EmployeeController : ApiController {
        // GET api/Employee
        public IEnumerable<Man> Get () {
            using (CompanyEntities context = new CompanyEntities()) {
                var data = context.Employee.Select(c => new { c.Name, c.Age, c.Email, c.Phone });
                List<Man> people = new List<Man>();
                foreach (var employee in data) {
                    people.Add(new ManBuilder().SetName(employee.Name).SetAge(employee.Age).SetEmail(employee.Email).SetPhone(employee.Phone).build());
                }
                return people;
            }
        }

        // GET api/Employee/5
        public string Get (int id) {
            return "value";
        }

        // POST api/Employee
        public void Post ([FromBody]string value) {
        }

        // PUT api/Employee/5
        public void Put (int id, [FromBody]string value) {
        }

        // DELETE api/Employee/5
        public void Delete (int id) {
        }
    }
}