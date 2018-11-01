using Dimensionamento.teste;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;

namespace Dimensionamento.Models
{
	public class Materiais
    {
		private readonly IOptions<DbConfig> _dbConfig;

		public string Text { get; set; }
		public string Value { get; set; }

		public Materiais(string value)
		{
			Text = value;
			Value = value;
		}

		public Materiais(IOptions<DbConfig> dbConfig)
		{
			_dbConfig = dbConfig;
		}

		public IEnumerable<Materiais> getMateriais()
		{
			var context = new DimensionamentoContext(_dbConfig);

			var Materiais = context.ParteD5A2010Pg5450.ToList();

			foreach (var materiais in Materiais)
			{
				var typeOrGrade = "";

				if (!string.IsNullOrEmpty(materiais.TypeOrGrade))
				{
					typeOrGrade = "GR." + materiais.TypeOrGrade;
				}
				yield return new Materiais(materiais.SpecNo + typeOrGrade);
			}
		}
	}
}
