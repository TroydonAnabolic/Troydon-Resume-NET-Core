using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Troydon_Resume_Online_NET_Core_.Models.Account
{
    public class AdminNumberRequirement : IAuthorizationRequirement
    {
        public int AdminNumber { get; }
        public int MinimumAge { get; }

        public AdminNumberRequirement(int adminNumber, int minimumAge)
        {
            AdminNumber = adminNumber;
            MinimumAge = minimumAge;
        }
    }
}
