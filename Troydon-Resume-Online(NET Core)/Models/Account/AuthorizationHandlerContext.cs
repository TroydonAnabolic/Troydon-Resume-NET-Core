using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Troydon_Resume_Online_NET_Core_.Models.Account
{
    public class AuthorizationHandlerContext : IAuthorizationHandler
    {
        public Task HandleAsync(Microsoft.AspNetCore.Authorization.AuthorizationHandlerContext context)
        {
            throw new NotImplementedException();
        }
    }
}
