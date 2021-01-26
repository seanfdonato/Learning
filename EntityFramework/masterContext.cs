using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EntityFramework
{
    public partial class masterContext : DbContext
    {
        public masterContext()
        {
        }

        public masterContext(DbContextOptions<masterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BaseConfig> BaseConfigs { get; set; }
        public virtual DbSet<MailConfig> MailConfigs { get; set; }
        public virtual DbSet<WebServiceConfig> WebServiceConfigs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<BaseConfig>(entity =>
            {
                entity.ToTable("BaseConfig");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("value")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MailConfig>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("MailConfig");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne<BaseConfig>(d => d.IdBaseConfigNavigation)
                    .WithOne(p => p.MailConfigs)
                    .HasForeignKey<BaseConfig>(d => d.Id);
            });

            modelBuilder.Entity<WebServiceConfig>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("WebServiceConfig");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne<BaseConfig>(d => d.IdBaseConfigNavigation)
                    .WithOne(p => p.WebServiceConfigs)
                    .HasForeignKey<BaseConfig>(d => d.Id);

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
