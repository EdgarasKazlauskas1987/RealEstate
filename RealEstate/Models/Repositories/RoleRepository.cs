using RealEstate.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using Microsoft.AspNet.Identity.EntityFramework;

namespace RealEstate.Models.Repositories
{
    public class RoleRepository : IRoleRepository
    {

        ApplicationDbContext _db = new ApplicationDbContext();

        public void Create(IdentityRole Role)
        {
            _db.Roles.Add(Role);
            _db.SaveChanges();
        }

        public IEnumerable GetAll()
        {
            return _db.Roles;
        }
    }
}