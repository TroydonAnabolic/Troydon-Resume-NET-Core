using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace Troydon_Resume_Online_NET_Core_.Models
{
    internal class HttpStatusCodeResult : ActionResult
    {
        private HttpStatusCode badRequest;

        public HttpStatusCodeResult(HttpStatusCode badRequest)
        {
            this.badRequest = badRequest;
        }
        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }
    }
}