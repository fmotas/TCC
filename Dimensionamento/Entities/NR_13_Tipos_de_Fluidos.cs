using System.ComponentModel.DataAnnotations;

namespace Dimensionamento.Entities
{
	public class NR_13_Tipos_de_Fluidos
    {
		[Key]
		public int Id { get; }
		public char Classe { get; set; }
		public string TipodeFluido { get; set; }
	}
}
