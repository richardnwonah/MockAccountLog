using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using MockBankApi.Models;

    public class StagingDbContext : DbContext
    {
        public StagingDbContext (DbContextOptions<StagingDbContext> options)
            : base(options)
        {
        }

    //public DbSet<MockBankApi.Models.Staging> Staging { get; set; } = default!;

    public DbSet<MockBankApi.Models.Staging> Staging { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Staging>().HasData(
            new Staging
            {
                Id = Guid.NewGuid(),
                AccountNumber = "1500643512",
                AccountName = "John One Doe",
                Address =  "No3 Peninsula Graden Estate",
                City = "Ajah",
                State = "Lagos",
                Currency = "N",
                CumulativeInflow = 20000
            },
              new Staging
              {
                  Id = Guid.NewGuid(),
                  AccountNumber = "1500343511",
                  AccountName = "John Two Doe",
                  Address = "Dolphin Estate",
                  City = "Ikoyi",
                  State = "Lagos",
                  Currency = "N",
                  CumulativeInflow = 200
              }
        );
    }
}
