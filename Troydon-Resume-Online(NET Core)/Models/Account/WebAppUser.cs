using Microsoft.AspNetCore.Identity;
using System;
using System.Security.Claims;

namespace Troydon_Resume_Online_NET_Core_.Models.Account
{
    public class WebApp1User : IdentityUser<string>
    {
        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public DateTime DOB { get; set; }

        public Claim Claims { get; set; }
    }
}
