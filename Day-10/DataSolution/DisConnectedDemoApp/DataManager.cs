using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DisConnectedDemoApp
{
    public  class DataManager
    {
        public static string conenctionString = @"server=localhost;user=root;database=ietmarch22;password='root'";

        public static List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();
            MySqlConnection con = new MySqlConnection(conenctionString);
            string query = "SELECT * from employee";                          //SELECT * from product";
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

                    emp.ID=int.Parse(row["ID"].ToString());
                    emp.Name=row["Name"].ToString();
                    emp.Designation=row["Designation"].ToString();
                    emp.Salary=double.Parse(row["Salary"].ToString());
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
            string query = "SELECT * from employee";
            MySqlCommand cmd = new MySqlCommand(query, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
           MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
            try
            {
                da.Fill(ds); //*****************************************************************
                DataTable dt = ds.Tables[0];
                DataRow newRow=dt.NewRow();
                newRow["ID"] = emp.ID;
                newRow["Name"] = emp.Name;
                newRow["Designation"] = emp.Designation;
                newRow["Salary"] = emp.Salary;

                dt.Rows.Add(newRow);
                da.Update(ds);  //********************************************************
                status = true;
            }
            catch( MySqlException exp)
            {
                string message = exp.Message;
            }

            return status;
        }

        public static bool Update(Employee empToUpdate)
        {
            bool status = false;
            MySqlConnection con = new MySqlConnection(conenctionString);
            string query = "SELECT * from employee";
            MySqlCommand cmd = new MySqlCommand(query, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
            try
            {
                da.Fill(ds); //*****************************************************************
                DataTable dt = ds.Tables[0];

                DataRow theRow = dt.AsEnumerable().FirstOrDefault(row => row.Field<int>("ID") == empToUpdate.ID);

                if(theRow != null)
                {
                    theRow["Name"] = empToUpdate.Name;
                    theRow["Salary"] = empToUpdate.Salary;
                    theRow["Designation"] = empToUpdate.Designation;
                    da.Update(ds);  //*********************************************************************
                    status = true;
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
            string query = "SELECT * from employee";
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
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return status;
        }

    }
}
