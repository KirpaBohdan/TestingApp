using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TestingApp.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public DbSet<Answear> Answears { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Users_Tests> Users_Tests { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
           : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
            SampleData.AddData(this);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().HasKey(q => q.Id);
            builder.Entity<Test>().HasKey(q => q.Id);
            builder.Entity<Users_Tests>().HasKey(q =>
            new
            {
                q.UserId,
                q.TestId
            });
        }
    }
}
