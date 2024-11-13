using Microsoft.EntityFrameworkCore;
using LoginCadastroMVC.Models;
using System.Collections.Generic;

namespace LoginCadastroMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
