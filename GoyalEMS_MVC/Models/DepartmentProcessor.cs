using System.Collections.Generic;
using DataLayer.DataEntity;
using DataLayer.DataRepository;
namespace GoyalEMS_MVC.Models
{
    public class DepartmentProcessor
    {
        DepartmentRepository repo = new DepartmentRepository();
        //public static List<DepartmentModel> Departments = new List<DepartmentModel>();

        public List<DepartmentModel> GetDepartments
        {
            get
            {
                List<DepartmentEntity> departments = repo.GetDepartments;
                List<DepartmentModel> departmentModels = new List<DepartmentModel>();
                foreach (DepartmentEntity item in departments)
                {
                    departmentModels.Add(DepartmentModel.Convert(item));
                }
                return departmentModels;
            }
        }

        public DepartmentModel GetDepartment(int Id)
        {
            var data = repo.GetDepartment(Id);
            if(data != null)
             return DepartmentModel.Convert(data);

            return null;
        }
        public void Save(DepartmentModel model)
        {
            repo.Save(DepartmentModel.Convert(model));
        }

        public bool Remove(int DepartmentId)
        {
           return repo.Remove(DepartmentId);
        }

        public bool Update(DepartmentModel model)
        {
            return repo.Update(DepartmentModel.Convert(model));
        }
    }
}