using Microsoft.EntityFrameworkCore;
using ApiComBanco.Entities;

namespace ApiComBanco.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BooksDB;ConnectRetryCount=0");
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Emprestimo> Emprestimo { get; set; }

    }
}