using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Troydon_Resume_Online_NET_Core_.Models;

namespace Troydon_Resume_Online_NET_Core_.Controllers
{
    // Class Starts with localhost:444348/feedback
    [Route("feedback")]
    public class FeedbackController : Controller
    {
        //GET: /<controllers>/
        [Route("")]
        public IActionResult Index()
        {
            return new ContentResult { Content = "My CV Site feedback" };
        }

        // TODO: Remove test values to access site: localhost:44348/feedback/2019/September/13/test
        [Route("{year:min(2019)}/{month?}/{day:range(1,31)?}/{key?}")]
        //POST
        public IActionResult Post(int year, string month, int day, string key)
        {
            var post = new Post
            {
                Title = "My profile comment",
                Commented = DateTime.Now,
                Person = "Troydon Luicien",
                Body = "This is great website, do you not think so?"
            };

            return View();
        }
    }
}
