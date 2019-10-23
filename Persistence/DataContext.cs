using System;
using Domain;
using Microsoft.EntityFrameworkCore;
namespace Persistence
{
    public class DataContext: DbContext
    {
        public DbSet<Value> Values {get;set;}

        public DataContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Value>().HasData(
              new Value { Id = 1, Name = "Luna",LastName ="Smith",Date = DateTime.Now},
              new Value { Id = 2, Name = "Jackson",LastName = "Wang", Date = DateTime.Today},
              new Value { Id = 3, Name = "Sara" , LastName = "Johnson",Date=DateTime.Today},
              new Value { Id = 4, Name = "Sam", LastName = "Larsson", Date = DateTime.Today },
              new Value { Id = 5, Name = "Julian", LastName = "June", Date = DateTime.Today }
            );
        }
    }
}