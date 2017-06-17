
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections;


namespace RealEstate.Models.Abstract
{
    
    public interface IRoleRepository
    {
        IEnumerable GetAll();
        void Create(IdentityRole Role);
    }
}