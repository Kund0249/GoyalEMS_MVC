using DataLayer.DataEntity;
using System.ComponentModel.DataAnnotations;

namespace GoyalEMS_MVC.Models
{
    public class DepartmentModel
    {


        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Please enter department code")]
        public string DepartmentCode { get; set; }

        [Required(ErrorMessage = "Please enter department name")]
        public string DepartmentName { get; set; }



        public static DepartmentEntity Convert(DepartmentModel model)
        {
            return new DepartmentEntity()
            {
                DepartmentSystemNuber = model.DepartmentId,
                DepartmentCode = model.DepartmentCode,
                DepartmentName = model.DepartmentName
            };
        }

        public static DepartmentModel Convert(DepartmentEntity model)
        {
            return new DepartmentModel()
            {
                DepartmentId = model.DepartmentSystemNuber,
                DepartmentCode = model.DepartmentCode,
                DepartmentName = model.DepartmentName
            };
        }

    }
}