using Dimensionamento.Cálculos;
using System.ComponentModel.DataAnnotations;

namespace Dimensionamento.Entities.Costado
{
	public class CostadoInputs
    {
		[Display(Name = "Pressão Interna de Projeto(MPa)")]
		public double Pressao_Interna_de_Projeto { get; set; }
		[Display(Name = "Diâmetro Interno(mm)")]
		public double Diametro_Interno { get; set; }
		[Display(Name = "Máxima Tensão Admissível(MPa)")]
		public double Maxima_Tensao_Admissivel { get; set; }
		[Display(Name = "Coeficiente de Eficiência de Solda")]
		public double Eficiencia_de_Junta_do_Costado { get; set; }
		[Display(Name = "Sobrespessura de Corrosão(mm)")]
		public double Sobrespessura_de_Corrosao { get; set; }


		public CostadoInputs(DadosDeProjeto dados)
		{
			Pressao_Interna_de_Projeto = dados.Pressao_Interna_de_Projeto;
			Diametro_Interno = dados.Diametro_Interno;
			Maxima_Tensao_Admissivel = EspessuraDoCostado.getTensaoMaximaAdmissivel(dados);
			Eficiencia_de_Junta_do_Costado = dados.Eficiencia_de_Junta_do_Costado;
			Sobrespessura_de_Corrosao = dados.Sobrespessura_de_Corrosao;
		}

		public CostadoInputs(CostadoInputs inputs)
		{
			Pressao_Interna_de_Projeto = inputs.Pressao_Interna_de_Projeto;
			Diametro_Interno = inputs.Diametro_Interno;
			Maxima_Tensao_Admissivel = inputs.Maxima_Tensao_Admissivel;
			Eficiencia_de_Junta_do_Costado = inputs.Eficiencia_de_Junta_do_Costado;
			Sobrespessura_de_Corrosao = inputs.Sobrespessura_de_Corrosao;
		}
	}
}
