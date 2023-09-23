using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoyalEMS_MVC.Models
{
    public class EmployeeWrapper
    {
        public EmployeeWrapper()
        {
            PageSize = 10;
        }
        public List<EmployeeModel> Employees { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
    }
}