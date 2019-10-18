using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NgoThienDao.TrungTamNgoaiNgu.Models.Request.Student
{
    public class StudentCreate
    {
        public int ID { get; set; }

        [Display(Name = "Tên SV")]
        [Required(ErrorMessage = "Tên SV phải có 6-50 ký tự"), MaxLength(50), MinLength(6)]
        public string StudentName { get; set; }

        [Display(Name = "Ngày Sinh")]
        [Required(ErrorMessage = "Ngày sinh không được bỏ trống")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email không được bỏ trống")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email không hợp lệ.")]
        public string Email { get; set; }

        [Display(Name = "Ngôn ngữ")]
        public int IDLanguage { get; set; }

        [Display(Name = "Cấp độ")]
        public int IDLevel { get; set; }

        [Display(Name = "Giới tính")]
        public int IDMale { get; set; }
    }
}
