using System;
using System.Collections.Generic;
using BookShopCodeFirst.Models;
//using BookShopCodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShopCodeFirst.Data;

public partial class BooksContext : DbContext
{
    public BooksContext()
    {
    }

    public BooksContext(DbContextOptions<BooksContext> options)
        : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Edition> Editions { get; set; }
    public DbSet<Award> Awards { get; set; }

    public DbSet<BookAward> TyBookAwards { get; set; }

    public DbSet<Author> Authors { get; set; }

    public DbSet<BookAuthor> BookAuthors { get; set; }
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Author>().HasData(new List<Author>()
        {
            new() { Id = 1, FirstName = "John", LastName = "Doe"},
            new() { Id = 2, FirstName = "Ann", LastName = "Smith"},
            new() { Id = 3, FirstName = "Jack", LastName = "Taylor"}
        });
    }
}
