using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace FaithBase.Domain.Identity
{
    public class ApplicationRole : IdentityRole
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}