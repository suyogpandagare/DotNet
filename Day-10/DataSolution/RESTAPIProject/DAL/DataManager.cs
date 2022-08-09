using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using MySql.Data.MySqlClient;
using RESTAPIProject.Models;
namespace RESTAPIProject.DAL
{

    public class DataManager
    {
        public static string conenctionString = @"server=localhost;user=root;database=actsdb;password=''";

        public static List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();
            MySqlConnection con = new MySqlConnection(conenctionString);
            string query = "SELECT * from employees;SELECT * from products";
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                //using Disconnected Data Access
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(ds);//

                //Offline: Snapshot of data
                //disconnected Data
                DataTable dt = ds.Tables[0];
                DataRowCollection rows = dt.Rows;

                foreach (DataRow row in rows)
                {
                    Employee emp = new Employee();

                    emp.ID = int.Parse(row["ID"].ToString());
                    emp.Name = row["Name"].ToString();
                    emp.Designation = row["Designation"].ToString();
                    emp.Salary = double.Parse(row["Salary"].ToString());
                    employees.Add(emp);
                }
            }
            catch (MySqlException exp)
            {
                string message = exp.Message;
            }
            return employees;
        }

        public static bool Insert(Employee emp)
        {
            bool status = false;
            MySqlConnection con = new MySqlConnection(conenctionString);
            string query = "SELECT * from employees";
            MySqlCommand cmd = new MySqlCommand(query, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
            try
            {
                con.Open();
                MySqlTransaction tr = con.BeginTransaction();
                da.Fill(ds); //*****************************************************************
                DataTable dt = ds.Tables[0];
                DataRow newRow = dt.NewRow();
                newRow["ID"] = emp.ID;
                newRow["Name"] = emp.Name;
                newRow["Designation"] = emp.Designation;
                newRow["Salary"] = emp.Salary;

                dt.Rows.Add(newRow);
                da.Update(ds,dt.TableName);  //********************************************************
               tr.Commit();
                
                status = true;
                
            }
            catch (MySqlException exp)
            {
                string message = exp.Message;
            }

            return status;
        }

        public static bool Update(Employee empToUpdate)
        {
            bool status = false;
            MySqlConnection con = new MySqlConnection(conenctionString);
            string query = "SELECT * from employees";
            MySqlCommand cmd = new MySqlCommand(query, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
            try
            {
                da.Fill(ds); //*****************************************************************
                DataTable dt = ds.Tables[0];

                DataRow theRow = dt.AsEnumerable().FirstOrDefault(row => row.Field<int>("ID") == empToUpdate.ID);

                if (theRow != null)
                {
                    theRow["Name"] = empToUpdate.Name;
                    theRow["Salary"] = empToUpdate.Salary;
                    theRow["Designation"] = empToUpdate.Designation;
                    da.Update(ds);  //*********************************************************************
                    status = true;
                    Commit(con);
                }
                status = true;
            }
            catch (MySqlException exp)
            {
                string message = exp.Message;
            }

            return status;
        }

        public static bool Delete(int id)
        {
            bool status = false;
            MySqlConnection con = new MySqlConnection(conenctionString);
            string query = "SELECT * from employees";
            MySqlCommand cmd = new MySqlCommand(query, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
            try
            {
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                DataRow theRow = dt.AsEnumerable().FirstOrDefault(row => row.Field<int>("ID") == id);
                if (theRow != null)
                    theRow.Delete();
                da.Update(ds);   // important method of data Adapter
                status = true;
                Commit(con);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return status;
        }

        private static int Commit(MySqlConnection con)
        {
            string query2 = "commit";
            MySqlCommand cmd = new MySqlCommand(query2, con);
            cmd.CommandType = CommandType.Text;
            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected;
        }

    }
}