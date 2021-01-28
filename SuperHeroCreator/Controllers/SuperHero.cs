using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroCreator.Data;
using SuperHeroCreator.Models;

namespace SuperHeroCreator.Controllers
{
    public class SuperHero : Controller
    {
        private ApplicationDbContext _context;
        public SuperHero(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: SuperHero
        public ActionResult Index()
        {
            return View();
        }

        // GET: SuperHero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SuperHero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperHero/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuperHeros newHero) // pass a superhero object to create new hero
        {
            try
            {
                _context.SuperHero.Add(newHero);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SuperHero/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: SuperHero/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperHero/Delete/5
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
