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
		[Display(Name = "t1 Sem Sobrespessura de Corrosao(mm)")]
		//O capítulo 4, seção 4.1, subseção 4.1.2 diz que a espessura mínima sem sobrespessura de corrosão é de 1,6 mm.
		public double t1_Sem_Sobrespessura_de_Corrosao { get; set; } = 1.60;
		[Display(Name = "t1 Com Sobrespessura de Corrosao(mm)")]
		public double t1_Com_Sobrespessura_de_Corrosao { get; set; }
		[Display(Name = "t2(mm)")]
		public double t2 { get; set; }

	}
}
