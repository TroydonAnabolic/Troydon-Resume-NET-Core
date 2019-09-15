using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Troydon_Resume_Online_NET_Core_.Models
{
    public class FeedbackDataContext : DbContext
    {


        public DbSet<Comment> Comments { get; set; }
        public FeedbackDataContext(DbContextOptions<FeedbackDataContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }
    }


}
