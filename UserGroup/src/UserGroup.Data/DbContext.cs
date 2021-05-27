using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DbContext = UserGroup.Data.DbContext;

namespace UserGroup.Data
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext()
            : base(new DbContextOptionsBuilder<DbContext>().UseSqlite("Data Source=main.db").Options)
        { }

        public DbSet<Event> Events => Set<Event>();
        public DbSet<Speaker> Speakers => Set<Speaker>();

        #region Logging
        public static ILoggerFactory LoggerFactory { get; }
            = Microsoft.Extensions.Logging.LoggerFactory.Create(logBuilder=> logBuilder.AddConsole());

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder is null)
            {
                throw new ArgumentNullException(nameof(optionsBuilder));
            }

            optionsBuilder.UseLoggerFactory(LoggerFactory);
        }
        #endregion // Logging

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder is null)
            {
                throw new ArgumentNullException(nameof(modelBuilder));
            }

            modelBuilder.Entity<Speaker>()
                .HasAlternateKey(speaker => new { speaker.FirstName, speaker.LastName });
        }
    }
}
