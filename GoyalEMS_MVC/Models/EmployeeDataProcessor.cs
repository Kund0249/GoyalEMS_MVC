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
        public void Save(EmployeeModel model)
        {
            Repository.Save(EmployeeModel.Convert(model));
        }
    }
}