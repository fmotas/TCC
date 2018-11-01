using Dimensionamento.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;

namespace Dimensionamento.Repository
{
	public class DimensionamentoContextold : DbContext
	{
		private readonly IOptions<DbConfig> _dbConfig;
		private readonly string _connectionString;
		public DbSet<NR_13_Tipos_de_Fluidos> TiposdeFluidos { get; set; }

		public DimensionamentoContextold(IOptions<DbConfig> dbConfig)
		{
			_dbConfig = dbConfig;
			_connectionString = _dbConfig.Value.DataSource;
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(_connectionString);
		}

		public List<NR_13_Tipos_de_Fluidos> ListFluidos()
		{
			using (var context = this)
			{
				return context.TiposdeFluidos.ToList();
			}
		}
	}
}
