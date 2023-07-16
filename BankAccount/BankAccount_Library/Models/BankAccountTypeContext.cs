using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace BankAccount_Library.Models
{
    public partial class BankAccountTypeContext : DbContext
    {
        public BankAccountTypeContext()
        {
        }

        public BankAccountTypeContext(DbContextOptions<BankAccountTypeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountType> AccountTypes { get; set; } = null!;
        public virtual DbSet<BankAccount> BankAccounts { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

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
            var strConn = config["ConnectionStrings:BankAccountsTypeDB"];
            return strConn;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__AccountT__516F039556304D38");

                entity.Property(e => e.TypeId)
                    .HasMaxLength(20)
                    .HasColumnName("TypeID");

                entity.Property(e => e.TypeDesc).HasMaxLength(250);

                entity.Property(e => e.TypeName).HasMaxLength(80);
            });

            modelBuilder.Entity<BankAccount>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PK__BankAcco__349DA586AF9250C9");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(20)
                    .HasColumnName("AccountID");

                entity.Property(e => e.AccountName).HasMaxLength(120);

                entity.Property(e => e.BranchName).HasMaxLength(50);

                entity.Property(e => e.OpenDate).HasColumnType("date");

                entity.Property(e => e.TypeId)
                    .HasMaxLength(20)
                    .HasColumnName("TypeID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.BankAccounts)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__BankAccou__TypeI__286302EC");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .HasColumnName("UserID");

                entity.Property(e => e.Password).HasMaxLength(80);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
