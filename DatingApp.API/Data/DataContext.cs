using DatingApp.API.Controllers.Models;
using Microsoft.EntityFrameworkCore;

using DatingApp.API.Models;

namespace DatingApp.API.Controllers.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        
        public DbSet<Value> Values { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}