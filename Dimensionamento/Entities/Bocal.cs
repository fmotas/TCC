using System.ComponentModel.DataAnnotations;

namespace Dimensionamento.Entities
{
	public class Bocal
	{
		[Display(Name = "Material")]
		public string Material { get; set; }
		[Display(Name = "Diâmetro Nominal(mm)")]
		public double Diametro_Nominal { get; set; }
		[Display(Name = "Coeficiente de Eficiência de Solda")]
		public double Coeficiente_de_Eficiencia_de_Solda { get; set; }
		[Display(Name = "Tensão Admissível Para o Bocal à Temperatura de Projeto(MPa)")]
		public double Tensão_Admissivel_Para_o_Bocal_a_Temperatura_de_Projeto { get; set; }
	}
}
