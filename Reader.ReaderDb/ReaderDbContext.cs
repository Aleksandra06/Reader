using System;
using Microsoft.EntityFrameworkCore;
using Reader.ReaderDb.Model;

namespace Reader.ReaderDb
{
    public class ReaderDbContext : DbContext
    {
        public ReaderDbContext(DbContextOptions<ReaderDbContext> options)
            : base(options)
        {
        }

        public DbSet<BookModel> BookDbSet { get; set; }
        public DbSet<ReadModel> ReadDbSet { get; set; }
        public DbSet<AuthorModel> AutorDbSet { get; set; }
    }
}
