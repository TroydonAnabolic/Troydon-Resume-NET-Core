using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Troydon_Resume_Online_NET_Core_.Models;

namespace Troydon_Resume_Online_NET_Core_.ViewComponents
{
    [ViewComponent]
    public class NewsHighlightsViewComponent : ViewComponent
    {
        private readonly FeedbackDataContext _db;
        public NewsHighlightsViewComponent(FeedbackDataContext db)
        {
           this._db = db;
        }

        public IViewComponentResult Invoke()
        {
            var highlights = _db.NewsHighlights.ToArray();

            return View(highlights);
        }
    }
}
