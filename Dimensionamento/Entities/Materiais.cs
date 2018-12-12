using System.ComponentModel.DataAnnotations;

namespace Dimensionamento.Entities
{
	public class Materiais
    {
		[Display(Name = "Material dos Cascos e Tampos")]
		public string Cascos_e_Tampos { get; set; }
		[Display(Name = "Material dos Suportes")]
		public string Suportes { get; set; }
		[Display(Name = "Material do Pescoço de Bocais")]
		public string Pescoco_de_Bocais { get; set; }
		[Display(Name = "Material da Boca de Visita")]
		public string Boca_de_Visita { get; set; }
		[Display(Name = "Material das Luvas")]
		public string Luvas { get; set; }
		[Display(Name = "Material dos Internos-Chapas")]
		public string Internos_Chapas { get; set; }
		[Display(Name = "Material dos Parafusos")]
		public string Parafusos { get; set; }
	}
}
