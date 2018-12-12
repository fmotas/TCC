using System.ComponentModel.DataAnnotations;

namespace Dimensionamento.Entities
{
	public class DadosParaEspessuraDosBocais
    {
		[Display(Name = "Bocal de Entrada de Fluído")]
		public Bocal Bocal_de_Entrada_de_Fluido { get; set; }
		[Display(Name = "Bocal de Saída de Gás")]
		public Bocal Bocal_de_Saida_de_Gas { get; set; }
		[Display(Name = "Bocal de Válvula de Segurança")]
		public Bocal Bocal_de_Valvula_de_Seguranca { get; set; }
		[Display(Name = "Bocal de Saída de Água")]
		public Bocal Bocal_de_Saida_de_Agua { get; set; }
		[Display(Name = "Bocal de Saída de Óleo")]
		public Bocal Bocal_de_Saida_de_Oleo { get; set; }
		[Display(Name = "Dreno")]
		public Bocal Dreno { get; set; }
		[Display(Name = "Respiradouro")]
		public Bocal Respiradouro { get; set; }
		[Display(Name = "Bocas de Visita")]
		public Bocal Bocas_de_Visita { get; set; }
	}
}
