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
        private readonly FeedbackDataContext _db;

        public FeedbackController(FeedbackDataContext db)
        {
            _db = db;
        }

        //GET: /<controllers>/
        [Route("")]
        public IActionResult Index()
        {
            // Return the first 5 comments on the comments page
            var comments = _db.Comments.OrderByDescending(x => x.Commented).Take(5).ToArray();

            return View(comments);
        }

        // https://localhost:44348/Feedback/2019/September
        [Route("{year:min(2019)}/{month?}/{day:range(1,31)?}/{key?}")]
        //POST
        public IActionResult Comment(int year, string month, int day, string key)
        {
            var comment = _db.Comments.FirstOrDefault(x => x.Key == key);

            return View(comment);
        }

        [HttpGet, Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Route("create")]
        public IActionResult Create(Comment comment)
        {
            // If not valid return back to view, else process request
            if (!ModelState.IsValid)
            {
                return View();
            }

            // override fields that the user submitted
            comment.Person = User.Identity.Name;
            comment.Commented = DateTime.Now;

            // Save to the database
            _db.Comments.Add(comment);
            _db.SaveChanges();

            return View();
        }
    }
}
