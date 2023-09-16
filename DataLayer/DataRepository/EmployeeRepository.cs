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

        public List<EmployeeEntity> GetEmployees
        {
            get
            {
                List<EmployeeEntity> employees = new List<EmployeeEntity>();
                var data = dB.tblEmployees.ToList();
                if (data != null)
                {
                    if (data.Count > 0)
                    {
                        foreach (tblEmployee item in data)
                        {
                            employees.Add(EmployeeEntity.Convert(item));
                        }
                    }
                }
                return employees;
            }
        }

        public List<EmployeeEntity> GetFilteredEmployees(int EmployeeCode = 0,string EmployeeEmail = null)
        {
            List<EmployeeEntity> employees = new List<EmployeeEntity>();
            var data = dB.tblEmployees.Where(x => (EmployeeCode == 0 || x.EmpCode == EmployeeCode) && (EmployeeEmail == null || x.EmailId == EmployeeEmail)).ToList();
            if (data != null)
            {
                if (data.Count > 0)
                {
                    foreach (tblEmployee item in data)
                    {
                        employees.Add(EmployeeEntity.Convert(item));
                    }
                }
            }
            return employees;
        }
    }
}
