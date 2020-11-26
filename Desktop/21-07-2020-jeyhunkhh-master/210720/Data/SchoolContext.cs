using System;
using System.Collections.Generic;
using System.Text;
using _210720.Models;
using Microsoft.EntityFrameworkCore;

namespace _210720.Data
{
    public class SchoolContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-CFIOP8C;Database=School;Integrated Security=True");
        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
