using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Troydon_Resume_Online_NET_Core_.Models
{
    public class Comment
    {
        public string Title { get; set; }
        public string Person { get; set; }
        public string Body { get; set; }
        public string Position { get; set; }
        public string Rate { get; set;  }
        public DateTime Commented { get; set; }

    }
}
