using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Troydon_Resume_Online_NET_Core_.Models;

namespace Troydon_Resume_Online_NET_Core_.Controllers
{
    // Class Starts with localhost:XXXX/feedback
    [Authorize]
    [Route("Feedback")]
    public class FeedbackController : Controller
    {
        private readonly FeedbackDataContext _db;
        private readonly ErrorViewModel _error;

        public FeedbackController(
            FeedbackDataContext db,
            ErrorViewModel error)
        {
            _db = db;
            _error = error;
        }

        //GET: /<controllers>/
        [AllowAnonymous]
        [Route("")]
        public IActionResult Index(int page = 0)
        {

            var pageSize = 2;
            var totalPosts = _db.Comments.Count();
            var totalPages = totalPosts / pageSize;
            var previousPage = page - 1;
            var nextPage = page + 1;

            ViewBag.PreviousPage = previousPage;
            ViewBag.HasPreviousPage = previousPage >= 0;
            ViewBag.NextPage = nextPage;
            ViewBag.HasNextPage = nextPage < totalPages;

            var comments =
                _db.Comments
                    .OrderByDescending(x => x.Commented)
                    .Skip(pageSize * page)
                    .Take(pageSize)
                    .ToArray();

            //returns only partial view which means only part of the page will load when the next and previous buttons clicked
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView(comments);

            return View(comments);
        }

        // https://localhost:44348/Feedback/2019/September
        [Route("{year:min(2019)}/{month:range(1,12)?}/{key?}")]
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

            // Redirect to newly created comment.
            return RedirectToAction("Comment", "Feedback", new
            {
                year = comment.Commented.Year,
                month = comment.Commented.Month,
                key = comment.Key
            });
        }

        [HttpGet]
        public ActionResult Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
            }
            Comment student = _db.Comments.Find(id);
            if (student == null)
            {
                var error = _error.RequestId;
                return View("Error");
            }
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Comment comment)
        {
            try
            {
                Comment student = _db.Comments.Find(id);
                _db.Comments.Remove(comment);
                _db.SaveChanges();
            }
            catch (DataException/* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
            return RedirectToAction("Index");
        }


    }
}
