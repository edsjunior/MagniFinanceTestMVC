using AutoMapper;
using MagniFinanceTest.Application.Interface;
using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MagniFinanceTest.MVC.Controllers
{
    public class GradeController : Controller
    {
        private readonly IGradeAppService _gradeApp;

        public GradeController(IGradeAppService gradeApp)
        {
            _gradeApp = gradeApp;
        }
        // GET: Grade
        public ActionResult Index()
        {
            var courseViewModel = Mapper.Map<IEnumerable<Grade>, IEnumerable<GradeViewModel>>(_gradeApp.GetAll());
            return View(courseViewModel);
        }

        // GET: Grade/Details/5
        public ActionResult Details(int id)
        {
            var grade = _gradeApp.GetById(id);
            var gradeViewModel = Mapper.Map<Grade, GradeViewModel>(grade);
            return View(gradeViewModel);
        }

        // GET: Grade/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Grade/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GradeViewModel grade)
        {
            if (ModelState.IsValid)
            {
                var gradeDomain = Mapper.Map<GradeViewModel, Grade>(grade);
                _gradeApp.Add(gradeDomain);

                return RedirectToAction("Index");
            }
            return View(grade);
        }

        // GET: Grade/Edit/5
        public ActionResult Edit(int id)
        {
            var grade = _gradeApp.GetById(id);
            var gradeViewModel = Mapper.Map<Grade, GradeViewModel>(grade);
            return View(gradeViewModel);
        }

        // POST: Grade/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GradeViewModel grade)
        {
            if (ModelState.IsValid)
            {
                var gradeDomain = Mapper.Map<GradeViewModel, Grade>(grade);
                _gradeApp.Update(gradeDomain);

                return RedirectToAction("Index");
            }
            return View(grade);
        }

        // GET: Grade/Delete/5
        public ActionResult Delete(int id)
        {
            var grade = _gradeApp.GetById(id);
            var gradeViewModel = Mapper.Map<Grade, GradeViewModel>(grade);

            return View(gradeViewModel);
        }

        // POST: Grade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var grade = _gradeApp.GetById(id);
            _gradeApp.Remove(grade);

            return RedirectToAction("Index");
        }
    }
}
