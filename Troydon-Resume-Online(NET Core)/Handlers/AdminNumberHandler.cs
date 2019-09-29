using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
//using PoliciesAuthApp1.Services.Requirements;
using Troydon_Resume_Online_NET_Core_.Models.Account;

namespace Troydon_Resume_Online_NET_Core_.Handlers
{

        public class AdminNumberHandler : AuthorizationHandler<AdminNumberRequirement>
        {
            protected override Task HandleRequirementAsync(Microsoft.AspNetCore.Authorization.AuthorizationHandlerContext context,
                                                           AdminNumberRequirement requirement)
            {
                if (!context.User.HasClaim(c => c.Type == ClaimTypes.DateOfBirth &&
                                                c.Issuer == "http://contoso.com"))
                {
                    //TODO: Use the following if targeting a version of
                    //.NET Framework older than 4.6:
                    //      return Task.FromResult(0);
                    return Task.CompletedTask;
                }

                var dateOfBirth = Convert.ToDateTime(
                    context.User.FindFirst(c => c.Type == ClaimTypes.DateOfBirth &&
                                                c.Issuer == "http://contoso.com").Value);

                int calculatedAge = DateTime.Today.Year - dateOfBirth.Year;
                if (dateOfBirth > DateTime.Today.AddYears(-calculatedAge))
                {
                    calculatedAge--;
                }

                if (calculatedAge >= requirement.MinimumAge && requirement.AdminNumber is 964212)
                {
                    context.Succeed(requirement);
                }

                //TODO: Use the following if targeting a version of
                //.NET Framework older than 4.6:
                //      return Task.FromResult(0);
                return Task.CompletedTask;
            }

    }
    
}
