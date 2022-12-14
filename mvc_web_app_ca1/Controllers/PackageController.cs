using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mvc_web_app_ca1.Models;
using mvc_web_app_ca1.Repository;

namespace mvc_web_app_ca1.Controllers
{
    public class PackageController : Controller
    {
        IMockRepo _repo;

        public PackageController(IMockRepo repo)
        {
            _repo = repo;
        }


        // GET: PackageController
        public ActionResult Index()
        {
            var packages = _repo.GetPackages(); 
            return View(packages);
        }

        // GET: PackageController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PackageController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PackageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PackageModel p)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.CreatePackage(p);
                    return RedirectToAction(nameof(Index));

                }
                return View();

            }
            catch
            {
                return View();
            }
        }

        // GET: PackageController/Edit/5
        public ActionResult Edit(int id)
        {
            var package = _repo.GetPackage(id);
            return View(package);
        }

        // POST: PackageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PackageModel m)
        {
            try
            {
                _repo.EditPackage(m);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PackageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PackageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
