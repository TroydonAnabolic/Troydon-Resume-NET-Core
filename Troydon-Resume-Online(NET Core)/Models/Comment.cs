using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Troydon_Resume_Online_NET_Core_.Models
{
    public class Comment
    {
        public long Id { get; set; }
        private string _key { get; set; }
        public string Key
        {
            get
            {
                if (_key == null)
                {
                    _key = Regex.Replace(Title.ToLower(), "[^a-z0-9]", "-");
                }
                return _key;
            }
            set { _key = value; }
        }

        [Display(Name ="Comment Title")]
        [Required]
        [StringLength(100, MinimumLength = 5,
            ErrorMessage = "Title need to be between 5 and 100 characters long")]
        [DataType(DataType.Text)]
        public string Title { get; set; }
        public string Person { get; set; }
        [Required]
        [MinLength(50, ErrorMessage = "Comment must be at least 50 characters long")]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public string Rate { get; set;  }
        public DateTime Commented { get; set; }

    }
}
