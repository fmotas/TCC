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

		public IEnumerable<Materiais> GetSpecificProductFormMateriais(string productForm)
		{
			var context = new DimensionamentoContext(_dbConfig);

			var Materiais = context.ParteD5A2010Pg5450.ToList();

			foreach (var material in Materiais)
			{
				var typeOrGrade = "";

				if (!string.IsNullOrEmpty(material.TypeOrGrade))
				{
					typeOrGrade = "Gr." + material.TypeOrGrade;
				}
				if (material.ProductForm == productForm)
				{
					yield return new Materiais(material.SpecNo + typeOrGrade);
				}
			}
		}

		public IEnumerable<Materiais> GetSpecificProductFormsMateriais(string productForm1, string productForm2)
		{
			var context = new DB_A4111A_tccdimuffContext5446(_dbConfig);

			var Materiais = context.ParteD5A2010Pg5446.ToList();

			foreach (var material in Materiais)
			{
				var typeOrGrade = "";

				if (!string.IsNullOrEmpty(material.TypeOrGrade))
				{
					typeOrGrade = "Gr." + material.TypeOrGrade;
				}
				if (material.ProductForm == productForm1 || material.ProductForm == productForm2)
				{
					yield return new Materiais(material.SpecNo + typeOrGrade);
				}
			}
		}
	}
}
