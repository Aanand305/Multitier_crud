using CommonLayer.Models;
using DataAccessLayer;
using System;
using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public class BLEmployeeBussiness
    {
        private EmployeeDataAccess dataAccess;
        public BLEmployeeBussiness()
        {
            dataAccess = new EmployeeDataAccess();

        }

        public List<Employee>GetEmployees()
        {
            return dataAccess.GetEmployees();
        }
    }
}
