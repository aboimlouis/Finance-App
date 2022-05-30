using LearningApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningApp.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<CharacterModel> Charaters => Set<CharacterModel>();
        public DbSet<UserModel> Users => Set<UserModel>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CharacterModel>().ToTable("Character");
            modelBuilder.Entity<UserModel>().ToTable("User");
        }
    }
}
