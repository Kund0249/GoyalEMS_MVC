using DataLayer.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoyalEMS_MVC.Models
{
    public class EmployeeModel
    {
        public int EmpCode { get; set; }
        public string EmpName { get; set; }
        public string Gender { get; set; }
        public string EmailId { get; set; }
        public int Salary { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public int DepartmentId { get; set; }
        public HttpPostedFileBase ProfileImage { get; set; }
        public string ProfileImagePath { get; set; }

        public static EmployeeEntity Convert(EmployeeModel model)
        {
            return new EmployeeEntity()
            {
                EmpName = model.EmpName,
                DOB = model.DOB,
                DOJ = model.DOJ,
                DepartmentId = model.DepartmentId,
                EmailId = model.EmailId,
                Gender = model.Gender,
                ProfileImagePath = model.ProfileImagePath,
                Salary = model.Salary,
                EmpCode = model.EmpCode
            };
        }
    }
}