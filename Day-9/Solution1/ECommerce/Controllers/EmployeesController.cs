using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using MySql.Data.MySqlClient;

using ECommerce.Models;

namespace ECommerce.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            List<Employee> employees = new List<Employee>();
            string conString = @"server=localhost;user=root; password='root'; database=ietmarch22";
            MySqlConnection con = new MySqlConnection(conString);
            string query = "SELECT * FROM employee";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Employee emp = new Employee();
                    emp.ID = int.Parse(reader["ID"].ToString());  //int.Parse, float.Parse, double.Parse
                    emp.Name = reader["Name"].ToString();
                    emp.Designation = reader["Designation"].ToString();
                    emp.Salary = int.Parse(reader["Salary"].ToString());
                    employees.Add(emp);
                }
            }
            catch (MySqlException exp)
            {
                string message = exp.Message;
                Console.WriteLine(message);
            }

            finally
            {
                con.Close();
            }
            this.ViewData["employees"] = employees;
            return View();
        }
    }
}