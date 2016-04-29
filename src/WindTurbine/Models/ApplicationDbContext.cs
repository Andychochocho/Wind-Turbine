using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindTurbine.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
    }
}