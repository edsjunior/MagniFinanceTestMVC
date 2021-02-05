using AutoMapper;
using MagniFinanceTest.Application.Interface;
using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MagniFinanceTest.MVC.Controllers
{
	public class CourseSubjectsController : Controller
    {

        private readonly ICourseSubjectsAppService _courseSubjectsApp;
        private readonly ICourseAppService _courseApp;
        private readonly ITeacherAppService _teacherApp;

        public CourseSubjectsController(ICourseSubjectsAppService courseSubjectsApp, 
            ICourseAppService courseApp,
            ITeacherAppService teacherApp)
        {
            _courseSubjectsApp = courseSubjectsApp;
            _courseApp = courseApp;
            _teacherApp = teacherApp;


        }
        // GET: CourseSubjectsSubjects
        public ActionResult Index()
        {
            var courseSubjectsViewModel = Mapper.Map<IEnumerable<CourseSubjects>, IEnumerable<CourseSubjectsViewModel>>(_courseSubjectsApp.GetAll());
            return View(courseSubjectsViewModel);
        }

        // GET: CourseSubjectsSubjects/Details/5
        public ActionResult Details(int id)
        {
            var courseSubjects = _courseSubjectsApp.GetById(id);
            var courseSubjectsViewModel = Mapper.Map<CourseSubjects, CourseSubjectsViewModel>(courseSubjects);
            return View(courseSubjectsViewModel);
        }

        // GET: CourseSubjectsSubjects/Create
        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(_courseApp.GetAll(), "CourseId", "Name");
            ViewBag.TeacherId = new SelectList(_teacherApp.GetAll(), "PersonId", "Name");
            return View();
        }

        // POST: CourseSubjectsSubjects/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CourseSubjectsViewModel courseSubjects)
        {
            if (ModelState.IsValid)
            {
                var courseSubjectsDomain = Mapper.Map<CourseSubjectsViewModel, CourseSubjects>(courseSubjects);
                _courseSubjectsApp.Add(courseSubjectsDomain);

                return RedirectToAction("Index");
            }
            return View(courseSubjects);
        }

        // GET: CourseSubjectsSubjects/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Courses = new SelectList(_courseApp.GetAll(), "CourseId", "Name");
            ViewBag.Teachers = new SelectList(_teacherApp.GetAll(), "PersonId", "Name");

            var courseSubjects = _courseSubjectsApp.GetById(id);
            var courseSubjectsViewModel = Mapper.Map<CourseSubjects, CourseSubjectsViewModel>(courseSubjects);
            return View(courseSubjectsViewModel);
        }

        // POST: CourseSubjectsSubjects/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CourseSubjectsViewModel courseSubjects)
        {
            if (ModelState.IsValid)
            {
                var courseSubjectsDomain = Mapper.Map<CourseSubjectsViewModel, CourseSubjects>(courseSubjects);
                _courseSubjectsApp.Update(courseSubjectsDomain);

                return RedirectToAction("Index");
            }
            return View(courseSubjects);
        }

        // GET: CourseSubjectsSubjects/Delete/5
        public ActionResult Delete(int id)
        {
            var courseSubjects = _courseSubjectsApp.GetById(id);
            var courseSubjectsViewModel = Mapper.Map<CourseSubjects, CourseSubjectsViewModel>(courseSubjects);

            return View(courseSubjectsViewModel);
        }

        // POST: CourseSubjectsSubjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id, FormCollection collection)
        {
            var courseSubjects = _courseSubjectsApp.GetById(id);
            _courseSubjectsApp.Remove(courseSubjects);

            return RedirectToAction("Index");
        }
    }
}
