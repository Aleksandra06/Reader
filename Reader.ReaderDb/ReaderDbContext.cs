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

        public DbSet<BooksModel> BookDbSet { get; set; }
        public DbSet<ReadModel> ReadDbSet { get; set; }
    }
}
