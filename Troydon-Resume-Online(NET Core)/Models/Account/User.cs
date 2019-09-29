using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Troydon_Resume_Online_NET_Core_.Models.Account
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }

        public string AdminNumber { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
