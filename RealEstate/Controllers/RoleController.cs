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
    public class RoleController : Controller
    {
        private readonly IRoleRepository _projectRepo;

        public RoleController(IRoleRepository repo)
        {
            this._projectRepo = repo;
        }

        // GET: all roles
        public ActionResult Index()
        {
            var Roles = _projectRepo.GetAll();
            return View(Roles);
        }

        //GET: create a new role
        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }

        //POST: create a new role
        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            _projectRepo.Create(Role);
            return RedirectToAction("Index");
        }

        //NOT USING REPOSITORY (OLD)
        /*
        ApplicationDbContext context;

        public RoleController()
        {
            context = new ApplicationDbContext();
        }

        // GET: all roles
        public ActionResult Index()
        {
            var Roles = context.Roles.ToList();
            return View(Roles);
        }
        
        //GET: create a new role
        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }

        //POST: create a new role
        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            context.Roles.Add(Role);
            context.SaveChanges();
            return RedirectToAction("Index");
        } */
    } 
}