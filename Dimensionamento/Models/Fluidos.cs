using Dimensionamento.Repository;
using Dimensionamento.teste;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dimensionamento.Models
{
	public class Fluidos
	{
		private readonly IOptions<DbConfig> _dbConfig;

		public string Text { get; set; }
		public string Value { get; set; }

		public Fluidos(string value)
		{
			Text = value;
			Value = value;
		}

		public Fluidos(IOptions<DbConfig> dbConfig)
		{
			_dbConfig = dbConfig;
		}

		public IEnumerable<Fluidos> getFluidos()
		{
			var context = new DimensionamentoContext(_dbConfig);

			var Fluidos = context.Nr13TiposDeFluidos.ToList();

			foreach (var fluido in Fluidos)
			{
				yield return new Fluidos(fluido.TipodeFluido);
			}
		}
	}
}