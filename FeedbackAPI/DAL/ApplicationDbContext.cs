using FeedbackAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FeedbackAPI.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<FeedbackServices> feedbackServices { get; set; }

        

    }
}
