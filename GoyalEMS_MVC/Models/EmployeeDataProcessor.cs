using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataLayer.DataRepository;
using DataLayer.DataEntity;

namespace GoyalEMS_MVC.Models
{
    public class EmployeeDataProcessor
    {
        EmployeeRepository Repository = new EmployeeRepository();

        public List<EmployeeModel> GetEmployees(int EmpCode = 0,string Email = null)
        {
            
                List<EmployeeModel> employees = new List<EmployeeModel>();
                var employeeEntities = Repository.GetFilteredEmployees(EmpCode, Email);
                if (employeeEntities.Count > 0)
                {
                    foreach (EmployeeEntity item in employeeEntities)
                    {
                        employees.Add(EmployeeModel.Convert(item));
                    }
                }
                return employees;
           
        }
        public void Save(EmployeeModel model)
        {
            Repository.Save(EmployeeModel.Convert(model));
        }
    }
}