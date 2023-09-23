using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoyalEMS_MVC.Models
{
    public class EmployeeFilterModel
    {
        public int EmpCode { get; set; }
        public string Email { get; set; }
        //public int? pagenuber { get; set; }
        public int? PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
    }
}