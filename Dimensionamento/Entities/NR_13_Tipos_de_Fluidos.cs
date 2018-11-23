using Dimensionamento.Cálculos;
using System.ComponentModel.DataAnnotations;

namespace Dimensionamento.Entities
{
	public class NR_13_Tipos_de_Fluidos
    {
		[Key]
		public int Id { get; }
		public string TipodeFluido { get; set; }
		public string Categoria { get; set; }
		public int Grupo { get; set; }
		public char Classe { get; set; }

		public NR_13_Tipos_de_Fluidos(DadosDeProjeto dados)
		{
			Categoria = CalculosGerais.getCategoriadoVaso(dados);
			Grupo = CalculosGerais.getGrupoPotencialdeRisco(dados);
			Classe = CalculosGerais.getClassedeFluido(dados);
		}

		public NR_13_Tipos_de_Fluidos(NR_13_Tipos_de_Fluidos Classificacao_NR_13)
		{
			Categoria = Classificacao_NR_13.Categoria;
			Grupo = Classificacao_NR_13.Grupo;
			Classe = Classificacao_NR_13.Classe;
		}
	}
}
