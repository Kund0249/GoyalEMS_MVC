using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DBContext;

namespace DataLayer.DataEntity
{
    public class DepartmentEntity
    {
        public int DepartmentSystemNuber { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }

        public static tblDepartment Convert(DepartmentEntity entity)
        {
            return new tblDepartment()
            {
                DeptId = entity.DepartmentSystemNuber,
                DepartmentCode = entity.DepartmentCode,
                DepartmentName = entity.DepartmentName
            };
        }

        public static DepartmentEntity Convert(tblDepartment entity)
        {
            return new DepartmentEntity()
            {
                DepartmentSystemNuber = entity.DeptId,
                DepartmentCode = entity.DepartmentCode,
                DepartmentName = entity.DepartmentName
            };
        }
    }
}
