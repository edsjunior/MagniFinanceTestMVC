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
		private readonly ICourseSubjectsAppService _courseSubjectApp;
		private readonly IStudentAppService _studentApp;
		private readonly IGradeAppService _gradeApp;

		public StudentSubjectsController(IStudentSubjectsAppService studentSubjectsApp,
			ICourseSubjectsAppService courseSubjectApp,
			IStudentAppService studentApp,
			IGradeAppService gradeApp)
		{
			_studentSubjectsApp = studentSubjectsApp;
			_studentApp = studentApp;
			_courseSubjectApp = courseSubjectApp;
			_gradeApp = gradeApp;
		}

		// GET: StudentSubjects
		public ActionResult Index()
		{
			var studentSubjectsViewModel = Mapper.Map<IEnumerable<StudentSubjects>, IEnumerable<StudentSubjectsViewModel>>(_studentSubjectsApp.GetAll());
			return View(studentSubjectsViewModel);
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
			ViewBag.Students = new SelectList(_studentApp.GetAll(), "StudentId", "Name");
			ViewBag.CourseSubjects = new SelectList(_courseSubjectApp.GetAll(), "CourseSubjectsId", "Name");
			ViewBag.Grades = new SelectList(_gradeApp.GetAll(), "GradeId", "GradeValue");
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
			ViewBag.Students = new SelectList(_studentApp.GetAll(), "StudentId", "Name");
			ViewBag.CourseSubjects = new SelectList(_courseSubjectApp.GetAll(), "CourseSubjectsId", "Name");
			ViewBag.Grades = new SelectList(_gradeApp.GetAll(), "GradeId", "GradeValue");

			var studentSubjects = _studentSubjectsApp.GetById(id);
			var studentSubjectsViewModel = Mapper.Map<StudentSubjects, StudentSubjectsViewModel>(studentSubjects);
			return View(studentSubjectsViewModel);
		}

		// POST: StudentSubjects/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(StudentSubjectsViewModel studentSubjects)
		{
			ViewBag.Students = new SelectList(_studentApp.GetAll(), "StudentId", "Name");
			ViewBag.CourseSubjects = new SelectList(_courseSubjectApp.GetAll(), "CourseSubjectsId", "Name");
			ViewBag.Grades = new SelectList(_gradeApp.GetAll(), "GradeId", "GradeValue");
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
