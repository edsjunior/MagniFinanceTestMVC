using AutoMapper;
using MagniFinanceTest.Application.Interface;
using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.MVC.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MagniFinanceTest.MVC.Controllers
{
	public class CoursesController : Controller
    {
        private readonly ICourseAppService _courseApp;
        private readonly ICourseSubjectsAppService _courseSubjectsApp;
        private readonly IStudentAppService _studentApp;
        private readonly ITeacherAppService _teacherApp;


        public CoursesController(ICourseAppService courseApp, 
            ICourseSubjectsAppService courseSubjectsApp,
            IStudentAppService studentApp,
            ITeacherAppService teacherApp)
		{
            _courseApp = courseApp;
            _courseSubjectsApp = courseSubjectsApp;
            _studentApp = studentApp;
            _teacherApp = teacherApp;
        }

        // GET: Courses
        public ActionResult Index()
        {
            var courseViewModel = Mapper.Map<IEnumerable<Course>, IEnumerable<CourseViewModel>>(_courseApp.GetAll());

			foreach (CourseViewModel item in courseViewModel)
			{
                item.CountStudents = _studentApp.CountStudentsByCourse(item.CourseId);
                item.CountTeachers = _teacherApp.CountTeachersByCourse(item.CourseId);
                item.CourseAverage = _courseSubjectsApp.AverageByCourse(item.CourseId);
            }
            
            return View(courseViewModel);
        }

        // GET: Courses/Details/5
        public ActionResult Details(int id)
        {
            var course = _courseApp.GetById(id);
            var courseViewModel = Mapper.Map<Course, CourseViewModel>(course);

            courseViewModel.CourseSubjects = GetCourseSubjects(id);

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

		private IEnumerable<CourseSubjectsViewModel> GetCourseSubjects(int id)
		{
			var courseSubjects = _courseSubjectsApp.FindByCourseId(id);
			var courseSubjectsViewModel = Mapper.Map<IEnumerable<CourseSubjects>, IEnumerable<CourseSubjectsViewModel>>(courseSubjects);

            return (courseSubjectsViewModel);
		}
	}
}
