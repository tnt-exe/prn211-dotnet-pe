using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace PaperJournal_Library.Models
{
    public partial class PaperJournalSp2023DBContext : DbContext
    {
        public PaperJournalSp2023DBContext()
        {
        }

        public PaperJournalSp2023DBContext(DbContextOptions<PaperJournalSp2023DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<JournalInfo> JournalInfos { get; set; } = null!;
        public virtual DbSet<Paper> Papers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
            var strConn = config["ConnectionStrings:DefaultDB"];

            return strConn;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.StaffId)
                    .HasName("PK__Account__96D4AAF714BF8003");

                entity.ToTable("Account");

                entity.Property(e => e.StaffId)
                    .HasMaxLength(50)
                    .HasColumnName("StaffID");

                entity.Property(e => e.AccountEmail).HasMaxLength(50);

                entity.Property(e => e.AccountFullName).HasMaxLength(60);

                entity.Property(e => e.AccountPassword).HasMaxLength(50);

                entity.Property(e => e.Birthday).HasColumnType("datetime");
            });

            modelBuilder.Entity<JournalInfo>(entity =>
            {
                entity.HasKey(e => e.JournalId)
                    .HasName("PK__JournalI__2501038619640AE7");

                entity.ToTable("JournalInfo");

                entity.Property(e => e.JournalId)
                    .ValueGeneratedNever()
                    .HasColumnName("JournalID");

                entity.Property(e => e.Category).HasMaxLength(100);

                entity.Property(e => e.JournalName).HasMaxLength(120);

                entity.Property(e => e.ShortJournalDescription).HasMaxLength(250);

                entity.Property(e => e.Telephone).HasMaxLength(20);
            });

            modelBuilder.Entity<Paper>(entity =>
            {
                entity.ToTable("Paper");

                entity.Property(e => e.PaperId)
                    .HasMaxLength(20)
                    .HasColumnName("PaperID");

                entity.Property(e => e.Authors).HasMaxLength(150);

                entity.Property(e => e.JournalId).HasColumnName("JournalID");

                entity.Property(e => e.PaperTitle).HasMaxLength(100);

                entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.Papers)
                    .HasForeignKey(d => d.JournalId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Paper__JournalID__286302EC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
