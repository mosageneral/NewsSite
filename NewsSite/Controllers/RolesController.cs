using Microsoft.AspNet.Identity.EntityFramework;
using NewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsSite.Controllers
{
    public class RolesController : Controller
    {

        // GET: Roles
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View(db.Roles.ToList());
        }

        // GET: Roles/Details/5
        

        // GET: Roles/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Roles/Create
        [HttpPost]
        public ActionResult Create(IdentityRole role)
        {
            try
            {
                db.Roles.Add(role);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



        // GET: Roles/Delete/5
        public ActionResult Delete(string id)
        {
            var role = db.Roles.Find(id);
            if (role == null)
            {
                return HttpNotFound();
            }
            return View(role);
        }

        // POST: Roles/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, IdentityRole role)
        {
            try
            {

                // TODO: Add delete logic here
                var findrole = db.Roles.Find(id);
                db.Roles.Remove(findrole);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.ex = ex;
                return View();
            }
        }
    }
}
