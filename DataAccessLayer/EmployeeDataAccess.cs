using CommonLayer.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class EmployeeDataAccess
    {
        private DbConnection db = new DbConnection();

        public List<Employee>GetEmployees()
        {
            string query = "select * from Employee";
            SqlCommand sql = new SqlCommand();
            sql.CommandText = query;
            sql.Connection = db.connection;
            if(db.connection.State==System.Data.ConnectionState.Closed)
                db.connection.Open();
            SqlDataReader reader = sql.ExecuteReader();
            List<Employee> employees = new List<Employee>();
            while(reader.Read())
            {
                Employee employee = new Employee();
                employee.id = (int)reader["id"];
                employee.Name=reader["name"].ToString();
                employee.Age=reader["Age"].ToString();
                employee.Salary = reader["Salary"].ToString();
                employee.Department_id = (int)reader["Department_id"];
                employees.Add(employee);
            }
            db.connection.Close();
            return employees;
           
        }
        
    }
}
