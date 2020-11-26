using _200720.Models;
using Microsoft.EntityFrameworkCore;

namespace _200720.Data
{
    public class HotelContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-TNHKHHJ;Database=Hotel;Integrated Security=True");
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
