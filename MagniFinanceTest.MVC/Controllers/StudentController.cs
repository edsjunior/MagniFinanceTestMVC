using AutoMapper;
using MagniFinanceTest.Application.Interface;
using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MagniFinanceTest.MVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentAppService _studentApp;
        private readonly ICourseAppService _courseApp;

        public StudentController(IStudentAppService studentApp, ICourseAppService courseApp)
        {
            _studentApp = studentApp;
            _courseApp = courseApp;
        }

        // GET: Student
        public ActionResult Index()
        {
            var courseViewModel = Mapper.Map<IEnumerable<Student>, IEnumerable<StudentViewModel>>(_studentApp.GetAll());
            return View(courseViewModel);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            var student = _studentApp.GetById(id);
            var studentViewModel = Mapper.Map<Student, StudentViewModel>(student);
            return View(studentViewModel);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(_courseApp.GetAll(), "CourseId", "Name");
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentViewModel student)
        {
            if (ModelState.IsValid)
            {
                var studentDomain = Mapper.Map<StudentViewModel, Student>(student);
                _studentApp.Add(studentDomain);

                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.CourseId = new SelectList(_courseApp.GetAll(), "CourseId", "Name");
            var student = _studentApp.GetById(id);
            var studentViewModel = Mapper.Map<Student, StudentViewModel>(student);
            return View(studentViewModel);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(StudentViewModel student)
        {
            if (ModelState.IsValid)
            {
                var studentDomain = Mapper.Map<StudentViewModel, Student>(student);
                _studentApp.Update(studentDomain);

                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            var student = _studentApp.GetById(id);
            var studentViewModel = Mapper.Map<Student, StudentViewModel>(student);

            return View(studentViewModel);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var student = _studentApp.GetById(id);
            _studentApp.Remove(student);

            return RedirectToAction("Index");
        }
    }
}
