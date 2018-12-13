using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Dimensionamento.Models
{
	public partial class DB_A4111A_tccdimuffContext5448 : DbContext
    {
		private readonly IOptions<DbConfig> _dbConfig;
		private readonly string _connectionString;
		public DB_A4111A_tccdimuffContext5448(IOptions<DbConfig> dbConfig)
        {
			_dbConfig = dbConfig;
			_connectionString = _dbConfig.Value.DataSource;
		}

        public DB_A4111A_tccdimuffContext5448(DbContextOptions<DB_A4111A_tccdimuffContext5448> options)
            : base(options)
        {
        }

        public virtual DbSet<ParteD5A2010Pg5448> ParteD5A2010Pg5448 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=SQL5035.site4now.net;User Id=DB_A4111A_tccdimuff_admin;Password=asdf1234;Database=DB_A4111A_tccdimuff;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParteD5A2010Pg5448>(entity =>
            {
                entity.ToTable("Parte_D_5_A_2010_PG5448");

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
        }
    }
}
