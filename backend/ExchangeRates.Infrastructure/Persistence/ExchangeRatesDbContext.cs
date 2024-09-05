using ExchangeRates.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRates.Infrastructure.Persistence
{
    internal class ExchangeRatesDbContext(DbContextOptions<ExchangeRatesDbContext> options) : DbContext(options)
    {
        internal DbSet<ExchangeRate> ExchangeRates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ExchangeRate>()
                .Property(er => er.Mid)
                .HasPrecision(18, 4);
        }
    }
}
