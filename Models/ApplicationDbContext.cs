using Microsoft.EntityFrameworkCore;

namespace InquiryApp.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Inquiry> Inquiries { get; set; }
    }
}
