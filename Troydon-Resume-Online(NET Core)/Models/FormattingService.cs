using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Troydon_Resume_Online_NET_Core_.Models
{
    public class FormattingService
    {
        public string AsReadableDate(DateTime date)
        {
            return date.ToString("d");
        }

        // TO DO: Add another formatting service
    }
}
