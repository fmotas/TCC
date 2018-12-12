using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Dimensionamento.Models
{
    public partial class DB_A4111A_tccdimuffContext : DbContext
    {
        public DB_A4111A_tccdimuffContext()
        {
        }

        public DB_A4111A_tccdimuffContext(DbContextOptions<DB_A4111A_tccdimuffContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ParteD5A2010Pg5446> ParteD5A2010Pg5446 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SQL5035.site4now.net;User Id=DB_A4111A_tccdimuff_admin;Password=asdf1234;Database=DB_A4111A_tccdimuff;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParteD5A2010Pg5446>(entity =>
            {
                entity.ToTable("Parte_D_5_A_2010_PG5446");

                entity.Property(e => e.AlloyDesignationOrUnsno)
                    .HasColumnName("AlloyDesignationOrUNSNo")
                    .HasMaxLength(50);

                entity.Property(e => e.ClassOrConditionOrTemper).HasMaxLength(50);

                entity.Property(e => e.GroupNo).HasMaxLength(50);

                entity.Property(e => e.NominalComposition).HasMaxLength(50);

                entity.Property(e => e.Pno)
                    .HasColumnName("PNo")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductForm).HasMaxLength(50);

                entity.Property(e => e.SizeOrThicknessMmMax)
                    .HasColumnName("SizeOrThickness_mm_Max")
                    .HasMaxLength(50);

                entity.Property(e => e.SizeOrThicknessMmMin)
                    .HasColumnName("SizeOrThickness_mm_Min")
                    .HasMaxLength(50);

                entity.Property(e => e.SpecNo).HasMaxLength(50);

                entity.Property(e => e.TypeOrGrade).HasMaxLength(50);
            });
        }
    }
}
