using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NgoThienDao.TrungTamNgoaiNgu.Models.Reponse.Language;
using NgoThienDao.TrungTamNgoaiNgu.Models.Reponse.Level;
using NgoThienDao.TrungTamNgoaiNgu.Models.Reponse.Male;
using NgoThienDao.TrungTamNgoaiNgu.Models.Reponse.Student;
using NgoThienDao.TrungTamNgoaiNgu.Models.Request.Student;
using NgoThienDao.TrungTamNgoaiNgu.Service;

namespace NgoThienDao.TrungTamNgoaiNgu.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService studentService = new StudentService();
        private readonly MaleService maleService = new MaleService();
        private readonly LevelService levelService = new LevelService();
        private readonly LanguageService languageService = new LanguageService();

        public IActionResult Index(StudentSearch request)
        {
            return View(studentService.SearchAndViewStudent(request.keyword));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Males = GetMaleDetails();
            ViewBag.Levels = GetLevelDetails();
            ViewBag.Languages = GetLanguageDetails();
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentCreate model)
        {
            var createResult = studentService.InsertStudent(
                new StudentCreate()
                {
                    StudentName = model.StudentName,
                    DOB = model.DOB,
                    IDMale = model.IDMale,
                    Email = model.Email,
                    IDLevel = model.IDLevel,
                    IDLanguage = model.IDLanguage
                });
            if (createResult > 0)
            {
                TempData["Success"] = "Sinh viên đã được thêm vào thành công";
            }
            else
            {
                TempData["Error"] = "Lỗi, làm ơn nhập lại lần nữa";
            }
            ModelState.Clear();
            ViewBag.Males = GetMaleDetails();
            ViewBag.Levels = GetLevelDetails();
            ViewBag.Languages = GetLanguageDetails();
            return View(new StudentCreate());
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            StudentDetail student = studentService.GetStudentByID(id);
            if (student == null)
            {
                return NotFound();
            }
            var deleteView = new StudentDelete()
            {
                ID = student.ID,
                DOB = student.DOB,
                Email = student.Email,
                Male = student.Male,
                StudentName = student.StudentName
            };
            return View(deleteView);
        }

        [HttpPost]
        public IActionResult Delete(StudentDelete model)
        {
            if (studentService.DeleteStudent(model.ID) > 0)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            StudentDetail student = studentService.GetStudentByID(id);
            var studentEdit = new StudentEdit()
            {
                ID = student.ID,
                StudentName = student.StudentName,
                DOB = student.DOB,
                IDLanguage = student.IDLanguage,
                IDMale = student.IDMale,
                Email = student.Email,
                IDLevel = student.IDLevel
            };
            if (studentEdit == null)
            {
                return NotFound();
            }
            ViewBag.Males = GetMaleDetails();
            ViewBag.Levels = GetLevelDetails();
            ViewBag.Languages = GetLanguageDetails();
            return View(studentEdit);
        }

        [HttpPost]
        public IActionResult Edit(StudentEdit model)
        {
            if (ModelState.IsValid)
            {
                studentService.UpdateStudent(model);
                return RedirectToAction("Index");
            }
            ViewBag.Males = GetMaleDetails();
            ViewBag.Levels = GetLevelDetails();
            ViewBag.Languages = GetLanguageDetails();
            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            StudentDetail student = studentService.GetStudentByID(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        public List<MaleView> GetMaleDetails()
        {
            var reponse = maleService.GetMaleDetails();
            var data = reponse.Select(m => new MaleView()
            {
                Name = m.Male,
                Value = m.ID
            }).ToList();
            return data;
        }

        public List<LevelView> GetLevelDetails()
        {
            var reponse = levelService.GetLevelDetails();
            var data = reponse.Select(l => new LevelView()
            {
                Name = l.LevelLanguage,
                Value = l.ID
            }).ToList();
            return data;
        }

        public List<LanguageView> GetLanguageDetails()
        {
            var reponse = languageService.GetLanguageDetails();
            var data = reponse.Select(l => new LanguageView()
            {
                Name = l.Language,
                Value = l.ID
            }).ToList();
            return data;
        }
    }
}