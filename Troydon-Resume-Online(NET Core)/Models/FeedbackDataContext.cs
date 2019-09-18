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

        public IQueryable<NewsHighlight> NewsHighlights
        {
            get
            {
                return new[]
                {
                    new NewsHighlight {
                        Key = "endure",
                        Name = "Super Endurance Package",
                        Description = "This formula will greatly boost your endurance",
                        Type = "supplement",
                        Price = 20,
                        Weight = 500,
                    },
                    new NewsHighlight {
                        Key = "mass",
                        Name = "Mass Monster",
                        Description = "Gain ultimate massiveness",
                        Type = "supplement",
                        Price = 110,
                        Weight = 1500
                    },
                    new NewsHighlight {
                        Key = "improve",
                        Name = "Muscle Regime",
                        Description = "12 week workout routine",
                        Type = "routine",
                        Price = 220,
                    },
                    new NewsHighlight {
                        Key = "lift",
                        Name = "Iron Straps",
                        Type = "equipment",
                        Price = 30,
                    },
                }.AsQueryable();
            }
        }


        public FeedbackDataContext(DbContextOptions<FeedbackDataContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }
    }


}
