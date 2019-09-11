using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Troydon_Resume_Online_NET_Core_.Models;

namespace Troydon_Resume_Online_NET_Core_.Controllers
{
    // Class Starts with localhost:XXXX/feedback
    [Route("feedback")]
    public class FeedbackController : Controller
    {
        //GET: /<controllers>/
        [Route("")]
        public IActionResult Index()
        {
            return new ContentResult { Content = "My CV Site feedback" };
        }

        // TODO: Remove test values to access site: localhost:XXXX/feedback/2019/September/13/test
        [Route("{year:min(2019)}/{month?}/{day:range(1,31)?}/{key?}")]
        //POST
        public IActionResult Comment(int year, string month, int day, string key)
        {
            var comment = new Comment
            {
                Title = "My profile comments",
                Commented = DateTime.Now,
                Person = "Troydon Luicien",
                Body = "This is great website, do you not think so?"
            };

            return View(comment);
        }

        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }
    }
}
