using GTE.Domain.Entities;
using GTE.Infra.Data.Extensions;
using GTE.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace GTE.Infra.Data.Context
{
    public class GTEContext : DbContext
    {
        public DbSet<AccountType> AccountType { get; set; }
        public DbSet<BankInformation> BankInformation { get; set; }
        public DbSet<BestTimeToWork> BestTimeToWork { get; set; }
        public DbSet<Knowledge> Knowledge { get; set; }
        public DbSet<OccupationArea> OccupationArea { get; set; }
        public DbSet<Programmer> Programmer { get; set; }
        public DbSet<WillingnessToWork> WillingnessToWork { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.AddConfiguration(new AccountTypeMapping());
            modelBuilder.AddConfiguration(new BankInformationMapping());
            modelBuilder.AddConfiguration(new BestTimeToWorkMapping());
            modelBuilder.AddConfiguration(new KnowledgeMapping());
            modelBuilder.AddConfiguration(new OccupationAreaMapping());
            modelBuilder.AddConfiguration(new ProgrammerMapping());
            modelBuilder.AddConfiguration(new WillingnessToWorkMapping());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("GTEContextConnection"));
        }
    }
}
