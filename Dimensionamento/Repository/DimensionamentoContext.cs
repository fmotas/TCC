using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Options;

namespace Dimensionamento.teste
{
    public partial class DimensionamentoContext : DbContext
	{
		private readonly IOptions<DbConfig> _dbConfig;
		private readonly string _connectionString;
		public DimensionamentoContext(IOptions<DbConfig> dbConfig)
		{
			_dbConfig = dbConfig;
			_connectionString = _dbConfig.Value.DataSource;
		}

        public DimensionamentoContext(DbContextOptions<DimensionamentoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AsmeViiiFatorK2004Pg377> AsmeViiiFatorK2004Pg377 { get; set; }
        public virtual DbSet<Nr13CategoriaDeVaso> Nr13CategoriaDeVaso { get; set; }
        public virtual DbSet<Nr13GrupoRiscoDoVaso> Nr13GrupoRiscoDoVaso { get; set; }
        public virtual DbSet<Nr13TiposDeFluidos> Nr13TiposDeFluidos { get; set; }
        public virtual DbSet<ParteD5A2010Pg5450> ParteD5A2010Pg5450 { get; set; }
        public virtual DbSet<ParteD5A2010Pg5452> ParteD5A2010Pg5452 { get; set; }
        public virtual DbSet<ParteDY12010Pg4700> ParteDY12010Pg4700 { get; set; }
        public virtual DbSet<ParteDY12010Pg4702> ParteDY12010Pg4702 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AsmeViiiFatorK2004Pg377>(entity =>
            {
                entity.ToTable("ASME_VIII_Fator_K_2004_PG377");

                entity.Property(e => e.D2h).HasColumnName("D/2h");
            });

            modelBuilder.Entity<Nr13CategoriaDeVaso>(entity =>
            {
                entity.ToTable("NR_13_Categoria_de_Vaso");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Categoria).HasMaxLength(10);

                entity.Property(e => e.ClassedeFluido).HasMaxLength(10);

                entity.Property(e => e.GrupodePotencialdeRisco).HasMaxLength(10);
            });

            modelBuilder.Entity<Nr13GrupoRiscoDoVaso>(entity =>
            {
                entity.ToTable("NR_13_Grupo_Risco_do_Vaso");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Grupo).HasMaxLength(10);

                entity.Property(e => e.PmXV)
                    .HasColumnName("Pm_x_V")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Nr13TiposDeFluidos>(entity =>
            {
                entity.ToTable("NR_13_Tipos_de_Fluidos");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Classe).HasMaxLength(10);

                entity.Property(e => e.TipodeFluido).HasMaxLength(300);
            });

            modelBuilder.Entity<ParteD5A2010Pg5450>(entity =>
            {
                entity.ToTable("Parte_D_5-A_2010_PG5450");

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

            modelBuilder.Entity<ParteD5A2010Pg5452>(entity =>
            {
                entity.ToTable("Parte_D_5-A_2010_PG5452");

                entity.Property(e => e._100).HasColumnName("100");

                entity.Property(e => e._125).HasColumnName("125");

                entity.Property(e => e._150).HasColumnName("150");

                entity.Property(e => e._175).HasColumnName("175");

                entity.Property(e => e._200).HasColumnName("200");

                entity.Property(e => e._225).HasColumnName("225");

                entity.Property(e => e._250).HasColumnName("250");

                entity.Property(e => e._275).HasColumnName("275");

                entity.Property(e => e._300).HasColumnName("300");

                entity.Property(e => e._30to40).HasColumnName("-30To40");

                entity.Property(e => e._325).HasColumnName("325");

                entity.Property(e => e._350).HasColumnName("350");

                entity.Property(e => e._375).HasColumnName("375");

                entity.Property(e => e._400).HasColumnName("400");

                entity.Property(e => e._425).HasColumnName("425");

                entity.Property(e => e._450).HasColumnName("450");

                entity.Property(e => e._475).HasColumnName("475");

                entity.Property(e => e._65).HasColumnName("65");
            });

            modelBuilder.Entity<ParteDY12010Pg4700>(entity =>
            {
                entity.ToTable("Parte_D_Y-1_2010_PG4700");

                entity.Property(e => e.AlloyDesignationOrUnsno)
                    .HasColumnName("AlloyDesignationOrUNSNo")
                    .HasMaxLength(50);

                entity.Property(e => e.ClassOrConditionOrTemper).HasMaxLength(50);

                entity.Property(e => e.NominalComposition).HasMaxLength(50);

                entity.Property(e => e.ProductForm).HasMaxLength(50);

                entity.Property(e => e.SpecNo).HasMaxLength(50);

                entity.Property(e => e.TypeOrGrade).HasMaxLength(50);
            });

            modelBuilder.Entity<ParteDY12010Pg4702>(entity =>
            {
                entity.ToTable("Parte_D_Y-1_2010_PG4702");

                entity.Property(e => e._150).HasColumnName("150");

                entity.Property(e => e._200).HasColumnName("200");

                entity.Property(e => e._20to100).HasColumnName("-20To100");

                entity.Property(e => e._250).HasColumnName("250");

                entity.Property(e => e._300).HasColumnName("300");

                entity.Property(e => e._350).HasColumnName("350");

                entity.Property(e => e._400).HasColumnName("400");

                entity.Property(e => e._450).HasColumnName("450");

                entity.Property(e => e._500).HasColumnName("500");
            });
        }

		public async Task<List<Nr13TiposDeFluidos>> ListFluidos()
		{
			using (var context = this)
			{
				return await context.Nr13TiposDeFluidos.ToListAsync();
			}
		}
	}		
}
