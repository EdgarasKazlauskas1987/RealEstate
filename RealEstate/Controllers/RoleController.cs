using Microsoft.AspNet.Identity.EntityFramework;
using RealEstate.Models;
using RealEstate.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Controllers
{
    [Authorize]
    public class RoleController : Controller
    {
        //Roles repository
        private readonly IRoleRepository _projectRepo;

        //Dependency injection
        public RoleController(IRoleRepository repo)
        {
            this._projectRepo = repo;
        }

        // GET: All roles
        public ActionResult Index()
        {
            var Roles = _projectRepo.GetAll();
            return View(Roles);
        }

        //GET: Create a new role
        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }

        //POST: Create a new role
        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            _projectRepo.Create(Role);
            return RedirectToAction("Index");
        }

    } 
}