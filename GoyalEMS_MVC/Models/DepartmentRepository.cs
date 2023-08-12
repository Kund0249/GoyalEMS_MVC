using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoyalEMS_MVC.Models
{
    public class DepartmentRepository
    {
        public static List<DepartmentModel> Departments = new List<DepartmentModel>();

        public List<DepartmentModel> GetDepartments
        {
            get
            {
                return Departments;
            }
        }
        public void Save(DepartmentModel model)
        {
            Departments.Add(model);
        }
    }
}