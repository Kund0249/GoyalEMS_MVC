using DataLayer.DataEntity;
using DataLayer.DBContext;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.DataRepository
{
    public class DepartmentRepository
    {
        DBEmployeeDataContext context = new DBEmployeeDataContext();
        //string cs;
        //public DepartmentRepository()
        //{
        //    cs = "data source=.;database=EmployeeDB;trusted_connection=true";
        //}

        public List<DepartmentEntity> GetDepartments
        {
            get
            {
                List<tblDepartment> tblDepartments = context.tblDepartments.ToList();
                List<DepartmentEntity> departments = new List<DepartmentEntity>();

                foreach (tblDepartment item in tblDepartments)
                {
                    departments.Add(DepartmentEntity.Convert(item));
                }
                return departments;
            }

        }

        public DepartmentEntity GetDepartment(int Id)
        {
           tblDepartment department = context.tblDepartments.SingleOrDefault(x => x.DeptId == Id);
           if(department != null)
            {
                return DepartmentEntity.Convert(department);
            }
            return null;
        }
        public void Save(DepartmentEntity entity)
        {

            context.tblDepartments.InsertOnSubmit(DepartmentEntity.Convert(entity));
            context.SubmitChanges();
            //using(SqlConnection con = new SqlConnection(cs))
            //{
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = con;
            //    cmd.CommandText = string.Format("insert into tblDepartment values('{0}','{1}')", entity.DepartmentCode, entity.DepartmentName);

            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //}
        }

        public bool Remove(int DepartmentSystemNumber)
        {
           tblDepartment department = context.tblDepartments.SingleOrDefault(x => x.DeptId == DepartmentSystemNumber);
           if(department != null)
            {
                context.tblDepartments.DeleteOnSubmit(department);
                context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool Update(DepartmentEntity entity)
        {
            tblDepartment department = context.tblDepartments.SingleOrDefault(x => x.DeptId == entity.DepartmentSystemNuber);
            if (department != null)
            {
                department.DepartmentName = entity.DepartmentName;
                department.DepartmentCode = entity.DepartmentCode;
                context.SubmitChanges();
                return true;
            }
            return false;
        }


    }
}
