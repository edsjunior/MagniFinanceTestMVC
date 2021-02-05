using AutoMapper;
using MagniFinanceTest.Application.Interface;
using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MagniFinanceTest.MVC.Controllers
{
	public class CoursesController : Controller
    {
        private readonly ICourseAppService _courseApp;

        public CoursesController(ICourseAppService courseApp)
		{
            _courseApp = courseApp;
        }

        // GET: Courses
        public ActionResult Index()
        {
            var courseViewModel = Mapper.Map<IEnumerable<Course>, IEnumerable<CourseViewModel>>(_courseApp.GetAll());
            return View(courseViewModel);
        }

        // GET: Courses/Details/5
        public ActionResult Details(int id)
        {
            var course = _courseApp.GetById(id);
            var courseViewModel = Mapper.Map<Course, CourseViewModel>(course);
            return View(courseViewModel);
        }

        // GET: Courses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Courses/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CourseViewModel course)
        {
			if (ModelState.IsValid)
			{
                var courseDomain = Mapper.Map<CourseViewModel, Course>(course);
                _courseApp.Add(courseDomain);

                return RedirectToAction("Index");
			}
            return View(course);
        }

        // GET: Courses/Edit/5
        public ActionResult Edit(int id)
        {
            var course = _courseApp.GetById(id);
            var courseViewModel = Mapper.Map<Course, CourseViewModel>(course);
            return View(courseViewModel);
        }

        // POST: Courses/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CourseViewModel course)
        {
			if (ModelState.IsValid)
			{
                var courseDomain = Mapper.Map<CourseViewModel, Course>(course);
                _courseApp.Update(courseDomain);

                return RedirectToAction("Index");
			}
            return View(course);
        }

        // GET: Courses/Delete/5
        public ActionResult Delete(int id)
        {
            var course = _courseApp.GetById(id);
            var courseViewModel = Mapper.Map<Course, CourseViewModel>(course);

            return View(courseViewModel);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var course = _courseApp.GetById(id);
            _courseApp.Remove(course);

            return RedirectToAction("Index");
            
        }
    }
}
