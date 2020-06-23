using Microsoft.AspNetCore.Identity;
using System;

namespace Mhr.Data.Identity
{
    public class AppUser : IdentityUser
    {
        // Add additional profile data for application users by adding properties to this class
        public string Name { get; set; }
        public string Department { get; set; }
        public DateTime EnrolledDate { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }

    }
}
