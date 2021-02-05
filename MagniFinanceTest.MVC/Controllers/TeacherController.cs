using AutoMapper;
using MagniFinanceTest.Application.Interface;
using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MagniFinanceTest.MVC.Controllers
{
	public class TeacherController : Controller
	{
		private readonly ITeacherAppService _teacherApp;

		public TeacherController(ITeacherAppService teacherApp)
		{
			_teacherApp = teacherApp;
		}
		// GET: Teacher
		public ActionResult Index()
		{
			var courseViewModel = Mapper.Map<IEnumerable<Teacher>, IEnumerable<TeacherViewModel>>(_teacherApp.GetAll());
			return View(courseViewModel);
		}

		// GET: Teacher/Details/5
		public ActionResult Details(int id)
		{
			var teacher = _teacherApp.GetById(id);
			var teacherViewModel = Mapper.Map<Teacher, TeacherViewModel>(teacher);
			return View(teacherViewModel);
		}

		// GET: Teacher/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Teacher/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(TeacherViewModel teacher)
		{
			if (ModelState.IsValid)
			{
				var teacherDomain = Mapper.Map<TeacherViewModel, Teacher>(teacher);
				_teacherApp.Add(teacherDomain);

				return RedirectToAction("Index");
			}
			return View(teacher);
		}

		// GET: Teacher/Edit/5
		public ActionResult Edit(int id)
		{
			var teacher = _teacherApp.GetById(id);
			var teacherViewModel = Mapper.Map<Teacher, TeacherViewModel>(teacher);
			return View(teacherViewModel);
		}

		// POST: Teacher/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(TeacherViewModel teacher)
		{
			if (ModelState.IsValid)
			{
				var teacherDomain = Mapper.Map<TeacherViewModel, Teacher>(teacher);
				_teacherApp.Update(teacherDomain);

				return RedirectToAction("Index");
			}
			return View(teacher);
		}

		// GET: Teacher/Delete/5
		public ActionResult Delete(int id)
		{
			var teacher = _teacherApp.GetById(id);
			var teacherViewModel = Mapper.Map<Teacher, TeacherViewModel>(teacher);

			return View(teacherViewModel);
		}


		// POST: Teacher/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			var teacher = _teacherApp.GetById(id);
			_teacherApp.Remove(teacher);

			return RedirectToAction("Index");
		}
	}
}

