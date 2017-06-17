using RealEstate.Models.Abstract;
using System.Collections;
using Microsoft.AspNet.Identity.EntityFramework;

namespace RealEstate.Models.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        ApplicationDbContext _db = new ApplicationDbContext();

        //Create new role
        public void Create(IdentityRole Role)
        {
            _db.Roles.Add(Role);
            _db.SaveChanges();
        }

        //GET; Return all  roles
        public IEnumerable GetAll()
        {
            return _db.Roles;
        }
    }
}