using FinanceApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<GroupModel> Group => Set<GroupModel>();
        public DbSet<ItemModel> Item => Set<ItemModel>();
        public DbSet<ItemTransactionTypeModel> ItemTransactionType => Set<ItemTransactionTypeModel>();
        public DbSet<RecurrentItemFrequencyTypeModel> RecurrentItemFrequencyType => Set<RecurrentItemFrequencyTypeModel>();
        public DbSet<RecurrentItemModel> RecurrentItem => Set<RecurrentItemModel>();
        public DbSet<TagModel> Tag => Set<TagModel>();
        public DbSet<UserModel> Users => Set<UserModel>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GroupModel>().ToTable("Group");
            modelBuilder.Entity<ItemModel>().ToTable("Item");
            modelBuilder.Entity<ItemTransactionTypeModel>().ToTable("ItemTransactionType");
            modelBuilder.Entity<RecurrentItemFrequencyTypeModel>().ToTable("RecurrentItemFrequencyType");
            modelBuilder.Entity<RecurrentItemModel>().ToTable("RecurrentItem");
            modelBuilder.Entity<TagModel>().ToTable("Tag");
            modelBuilder.Entity<UserModel>().ToTable("User");
        }
    }
}
