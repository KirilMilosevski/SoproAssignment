using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieWebApp;
using MovieWebApp.Models;

namespace MovieWebApp.DataAccess;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Person> Person { get; set; }
    }
