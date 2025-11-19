using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        //
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // dbset for the type we want to create the database set for
        // table name will be Users
        public DbSet<AppUser> Users { get; set; }
    }
}