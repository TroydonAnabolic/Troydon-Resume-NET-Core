using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Troydon_Resume_Online_NET_Core_.Controllers
{
    public class FeedbackController : Controller
    {
        //GET: /<controllers>/
        public IActionResult Index()
        {
            return View();
        }

        //POST
        public IActionResult Comment(string id)
        {
            return new ContentResult { Content = id };
        }
    }
}
