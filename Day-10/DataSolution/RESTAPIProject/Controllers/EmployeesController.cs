using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using RESTAPIProject.Models;
using RESTAPIProject.DAL;

namespace RESTAPIProject.Controllers
{
    public class EmployeesController : ApiController
    {
        // GET: api/Employees
        public IEnumerable<Employee> Get()
        {
            return DataManager.GetAll();
        }

        // GET: api/Employees/5
        public Employee Get(int id)
        {
            return DataManager.GetAll().Find((employee)=>(employee.ID==id));
        }

        // POST: api/Employees
        public void Post([FromBody] Employee emp)
        {
            bool status = DataManager.Insert(emp);
        }

        // PUT: api/Employees/5
        public void Put(int id, [FromBody] Employee emp)
        {
            DataManager.Update(emp);
        }

        // DELETE: api/Employees/5
        public void Delete(int id)
        {
            DataManager.Delete(id);
        }
    }
}
