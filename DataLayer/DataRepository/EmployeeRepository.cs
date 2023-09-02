using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DataEntity;
using DataLayer.DBContext;
namespace DataLayer.DataRepository
{
   public class EmployeeRepository
    {
        DBEmployeeDataContext dB = new DBEmployeeDataContext();
        public void Save(EmployeeEntity entity)
        {
            dB.tblEmployees.InsertOnSubmit(EmployeeEntity.Convert(entity));
            dB.SubmitChanges();
        }
    }
}
