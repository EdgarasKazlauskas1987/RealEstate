using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace RealEstate.Models.Abstract
{
    
    public interface IRoleRepository
    {
        IEnumerable GetAll();
        void Create(IdentityRole Role);
    }
}