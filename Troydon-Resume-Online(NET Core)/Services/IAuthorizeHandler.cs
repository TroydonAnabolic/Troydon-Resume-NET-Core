using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Troydon_Resume_Online_NET_Core_.Services
{
    /// <summary>
    /// Classes implementing this interface are able to make a decision if authorization
    /// is allowed.
    /// </summary>
    public interface IAuthorizationHandler
    {
        /// <summary>
        /// Makes a decision if authorization is allowed.
        /// </summary>
        /// <param name="context">The authorization information.</param>
        Task HandleAsync(AuthorizationHandlerContext context);
    }
}
