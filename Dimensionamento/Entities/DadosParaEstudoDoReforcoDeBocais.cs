using System.ComponentModel.DataAnnotations;

namespace Dimensionamento.Entities
{
	public class DadosParaEstudoDoReforcoDeBocais
    {
		[Display(Name = "Diâmetro Nominal(mm)")]
		public double Diametro_Nominal { get; set; }
		[Display(Name = "Raio Interno do Bocal(mm)")]
		public double Raio_Interno_do_Bocal { get; set; }
		[Display(Name = "Coeficiente de Eficiência de Solda")]
		public double Coeficiente_de_Eficiencia_de_Solda { get; set; }
		[Display(Name = "Tensão Admissível Para o Bocal à Temperatura de Projeto(MPa)")]
		public double Tensão_Admissivel_Para_o_Bocal_a_Temperatura_de_Projeto { get; set; }
		[Display(Name = "Tensão Admissível Para o Material de Adição à Temperatura de Projeto(MPa)")]
		public double Tensão_Admissivel_Para_o_Material_de_Adição_a_Temperatura_de_Projeto { get; set; }
		[Display(Name = "Largura do Reforço do Bocal(mm)")]
		public double Largura_do_Reforço_do_Bocal { get; set; }
		[Display(Name = "Espessura do Reforço do Bocal(mm)")]
		public double Espessura_do_Reforço_do_Bocal { get; set; }
		[Display(Name = "Bocal de Projeção a Partir da Parede Externa do Vaso")]
		public double Bocal_de_Projeção_a_Partir_da_Parede_Externa_do_Vaso { get; set; }
		[Display(Name = "Leg weld (L41)")]
		public double Leg_Weld_L41 { get; set; }
		[Display(Name = "Leg weld (L42)")]
		public double Leg_Weld_L42 { get; set; }
		[Display(Name = "PMTA(Corroído e Quente)")]		public double PMTA { get; set; }
	}
}
