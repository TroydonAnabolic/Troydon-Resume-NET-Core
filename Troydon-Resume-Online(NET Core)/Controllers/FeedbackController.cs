using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Troydon_Resume_Online_NET_Core_.Controllers
{
    [Route("feedback")]
    public class FeedbackController : Controller
    {
        //GET: /<controllers>/
        [Route("")]
        public IActionResult Index()
        {
            return new ContentResult { Content = "My CV Site feedback" };
        }

        // TODO: Remove test values
        [Route("{year:min(2019)}/{month?}/{day:range(1,31)?}/{key?}")]
        //POST
        public IActionResult Comment(int year, string month, int day, string key)
        {
            return new ContentResult
            {
                Content = string.Format("Year: {0} Month: {1} Day: {2} Key: {3}",
                                        year, month, day, key )
            };
        }
    }
}
