using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DBContext;

namespace DataLayer.DataEntity
{
    public class EmployeeEntity
    {
        public int EmpCode { get; set; }
        public string EmpName { get; set; }
        public string Gender { get; set; }
        public string EmailId { get; set; }
        public int Salary { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public int DepartmentId { get; set; }
        public string ProfileImagePath { get; set; }

        public static tblEmployee Convert(EmployeeEntity entity)
        {
            return new tblEmployee()
            {
                EmpName = entity.EmpName,
                DOB = entity.DOB.ToString(),
                DOJ = entity.DOJ.ToString(),
                DepartmentId = entity.DepartmentId,
                EmailId = entity.EmailId,
                Gender = entity.Gender,
                ProfileImage = entity.ProfileImagePath,
                Salary = entity.Salary,
                EmpCode = entity.EmpCode
            };
        }

        public static EmployeeEntity Convert(tblEmployee entity)
        {
            return new EmployeeEntity()
            {
                EmpName = entity.EmpName,
                DOB =  System.Convert.ToDateTime(entity.DOB),
                DOJ =  System.Convert.ToDateTime(entity.DOJ),
                DepartmentId = entity.DepartmentId,
                EmailId = entity.EmailId,
                Gender = entity.Gender,
                ProfileImagePath = entity.ProfileImage,
                Salary = entity.Salary,
                EmpCode = entity.EmpCode
            };
        }
    }
}
