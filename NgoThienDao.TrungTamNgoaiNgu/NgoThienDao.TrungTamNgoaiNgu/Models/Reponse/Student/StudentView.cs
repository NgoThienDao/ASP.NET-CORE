using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NgoThienDao.TrungTamNgoaiNgu.Models.Reponse.Student
{
    public class StudentView
    {
        public int ID { get; set; }

        [Display(Name = "Tên SV")]
        public string StudentName { get; set; }

        [Display(Name = "Ngày Sinh")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Display(Name = "Giới tính")]
        public string Male { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Ngôn ngữ")]
        public string LanguageRegistration { get; set; }

        [Display(Name = "Cấp độ")]
        public string LevelLanguage { get; set; }
    }
}
