using Library.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Library.Data
{
    public class LibraryDbContext: DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options):base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Library.Data.Models.Library> Libraries { get; set; }


    }
}
