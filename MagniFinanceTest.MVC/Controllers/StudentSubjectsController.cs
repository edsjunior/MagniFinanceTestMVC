using AutoMapper;
using MagniFinanceTest.Application.Interface;
using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MagniFinanceTest.MVC.Controllers
{
    public class StudentSubjectsController : Controller
    {
        private readonly IStudentSubjectsAppService _studentSubjectsApp;

        public StudentSubjectsController(IStudentSubjectsAppService studentSubjectsApp)
        {
            _studentSubjectsApp = studentSubjectsApp;
        }

        // GET: StudentSubjects
        public ActionResult Index()
        {
            var courseViewModel = Mapper.Map<IEnumerable<StudentSubjects>, IEnumerable<StudentSubjectsViewModel>>(_studentSubjectsApp.GetAll());
            return View(courseViewModel);
        }

        // GET: StudentSubjects/Details/5
        public ActionResult Details(int id)
        {
            var studentSubjects = _studentSubjectsApp.GetById(id);
            var studentSubjectsViewModel = Mapper.Map<StudentSubjects, StudentSubjectsViewModel>(studentSubjects);
            return View(studentSubjectsViewModel);
        }

        // GET: StudentSubjects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentSubjects/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentSubjectsViewModel studentSubjects)
        {
            if (ModelState.IsValid)
            {
                var studentSubjectsDomain = Mapper.Map<StudentSubjectsViewModel, StudentSubjects>(studentSubjects);
                _studentSubjectsApp.Add(studentSubjectsDomain);

                return RedirectToAction("Index");
            }
            return View(studentSubjects);
        }

        // GET: StudentSubjects/Edit/5
        public ActionResult Edit(int id)
        {
            var studentSubjects = _studentSubjectsApp.GetById(id);
            var studentSubjectsViewModel = Mapper.Map<StudentSubjects, StudentSubjectsViewModel>(studentSubjects);
            return View(studentSubjectsViewModel);
        }

        // POST: StudentSubjects/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StudentSubjectsViewModel studentSubjects)
        {
            if (ModelState.IsValid)
            {
                var studentSubjectsDomain = Mapper.Map<StudentSubjectsViewModel, StudentSubjects>(studentSubjects);
                _studentSubjectsApp.Update(studentSubjectsDomain);

                return RedirectToAction("Index");
            }
            return View(studentSubjects);
        }

        // GET: StudentSubjects/Delete/5
        public ActionResult Delete(int id)
        {
            var studentSubjects = _studentSubjectsApp.GetById(id);
            var studentSubjectsViewModel = Mapper.Map<StudentSubjects, StudentSubjectsViewModel>(studentSubjects);

            return View(studentSubjectsViewModel);
        }

        // POST: StudentSubjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var studentSubjects = _studentSubjectsApp.GetById(id);
            _studentSubjectsApp.Remove(studentSubjects);

            return RedirectToAction("Index");
        }
    }
}
