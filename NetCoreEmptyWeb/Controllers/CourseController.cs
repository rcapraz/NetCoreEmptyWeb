using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreEmptyWeb.Models;
using NetCoreEmptyWeb.ViewModels;

namespace NetCoreEmptyWeb.Controllers
{
    public class CourseController : Controller
    {
        //GET: Course/Index
        public IActionResult Index()
        {
            //------------3.6 Öncesi-----------------
            //var kurs = new Course() { Id = 1, Name = "Kurs 1" };
            //ViewData["course"] = kurs;

            //-----------3.6-----------------------
            var kurs = new Course() { Id = 1, Name = "KursName" };
            var ogrenciler = new List<Student>()
            {

            new Student() { Name = "Ahmet" },
            new Student() { Name = "Mehmet" },
            new Student() { Name = "fdsdfsd" },
            new Student() { Name = "asd" }
            };
            var viewmodel = new CourseStudentsViewModel();
            viewmodel.Course = kurs;
            viewmodel.Students = ogrenciler;

            return View(viewmodel);
            //-------------------------------------
        }
        
        //GET: Course/Details
        //--------------------------------------06/08/20 tarihli ders içeriği
        //public IActionResult Details()
        //{
        //    //name: "core mvc kursu"
        //    //description : "a dan z ye"
        //    //ispublished: true
        //    //bu verileri her kurs için tekrar oluşturup her birisi için de view sayfası oluşturmak yerine model kullanılır
        //    var course = new Course();
        //    course.Name = "Core Mvc Kursu";
        //    course.Description = "Fenalık kurs";
        //    course.isPublished = true;
        //    return View(course);
        //}
        //GET: Course/List
        public IActionResult List()
        {
            var students = Repository.Students.Where(x => x.Confirm == true);
            return View(students);
        }
        //GET Course/apply
        //default attribute httpGet
        [HttpGet]
        public ActionResult Apply()
        {
            return View();
        }
        //POST Course/apply form
        //--------------YÖNTEM 1-----------------------------------
        //[HttpPost]
        //public ActionResult Apply(string Name, string Email, string Phone, bool Confirm)
        //{
        //    //db kayıt komutları buradan verilir.
        //    return View();
        //}
        //--------------000000000----------------------------------
        //------------- YÖNTEM 2-----------------------------------
        [HttpPost]
        public IActionResult Apply(StudentResponse student)
        {
            //buraya db kayıt komutları yazılabilir
            if (ModelState.IsValid)
            {
                Repository.AddStudent(student);

            }
            else
            {
                return View(student);
            }
            return View("Thanks", student);
        }
        //GET:Course/Details/id  with routing method -----------------------------07/08/20 tarihli ders
        //GET: Course/Details?id=2 with query string method ----- methodda değişikliğe gidilmez size üzerindeki url kısmında /2 silinip ?id=2 yazılır
        public ActionResult Details(int id)
        {

            return Content("id = " + id);
        }
        public ActionResult CourseList(int? pageindex, string sortby)
        {
            if (!pageindex.HasValue)
                pageindex = 1;
            if (string.IsNullOrWhiteSpace(sortby))
                sortby = "name";
            return Content("pageindex = "+pageindex + " Sorted by : " + sortby);
        }
        public ActionResult ByReleased(int year,int month) {
            return Content("Year : "+ year+"  month : "+month);
        }
    }
}
