using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace FaithBase.Domain.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public Administrator Administrator { get; set; }
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}