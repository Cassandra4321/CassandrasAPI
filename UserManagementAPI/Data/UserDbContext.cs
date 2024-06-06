using Microsoft.EntityFrameworkCore;

namespace UserManagementAPI.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {
        }

        public  DbSet<Models.User> Users { get; set; }
    }
}
