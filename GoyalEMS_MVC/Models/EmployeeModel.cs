using DataLayer.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GoyalEMS_MVC.Models
{
    public class EmployeeModel
    {
        public int EmpCode { get; set; }

        [Required(ErrorMessage ="Please enter employee name")]
        [RegularExpression("[A-Za-z\\s]*",ErrorMessage ="Please enter alphabets only")]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "Please select employee gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter employee email address")]
        [EmailAddress(ErrorMessage ="Please enter valid email address")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Please enter employee salary")]
        [Range(10000,100000,ErrorMessage ="Please enter salary in range of 10000 to 100000")]
        public int Salary { get; set; }

        [Required(ErrorMessage = "Please select employee DOB")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Please select employee DOJ")]
        public DateTime DOJ { get; set; }

        [Required(ErrorMessage = "Please select employee department")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Please select employee profile image")]
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

        public static EmployeeModel Convert(EmployeeEntity model)
        {
            return new EmployeeModel()
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