using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dimensionamento.Entities
{
    public class DadosParaEspessuraDoCostado
	{
		[Display(Name = "Tipo De Casco ou Costado")]
		public string Tipo_de_Casco_ou_Costado { get; set; }
		[Display(Name = "Tipo de Tampo")]
		public string Tipo_de_Tampo { get; set; }
		[Display(Name = "Pressão de Operação Máxima")]
		public double Pressao_de_Operacao_Maxima { get; set; }
		[Display(Name = "Pressão de Operação Míxima")]
		public double Pressao_de_Operacao_Minima { get; set; }
		[Display(Name = "Pressão Interna de Projeto")]
		public double Pressao_Interna_de_Projeto { get; set; }
		[Display(Name = "Pressão Externa de Projeto")]
		public double Pressao_Externa_de_Projeto { get; set; }
		[Display(Name = "Temperatura de Operação")]
		public double Temperatura_de_Operacao { get; set; }
		[Display(Name = "Temperatura de Projeto")]
		public double Temperatura_de_Projeto { get; set; }
		[Display(Name = "Diâmetro Interno")]
		public double Diametro_Interno { get; set; }
		[Display(Name = "Comprimento Entre Tangentes")]
		public double Comprimento_Entre_Tangentes { get; set; }
		[Display(Name = "Volume Interno")]
		public double Volume_Interno { get; set; }
		[Display(Name = "Sobrespessura de Corrosão")]
		public double Sobrespessura_de_Corrosao { get; set; }
		[Display(Name = "Fluido")]
		public string Fluido { get; set; }
		[Display(Name = "Gravidade Específica")]
		public double Gravidade_Especifica { get; set; }
		[Display(Name = "Teste de Pressão Hidrostatica")]
		public double Teste_de_Pressao_Hidrostatica { get; set; }
		[Display(Name = "Nível de Líquido")]
		public NivelDeLiquido Nivel_de_Liquido { get; set; }
		[Display(Name = "Materiais")]
		public Materiais Materiais { get; set; }
		[Display(Name = "Juntas de Topo")]
		public string Juntas_de_Topo { get; set; }
		[Display(Name = "Radiografia do Casco e Tampo")]
		public string Radiografia_do_Casco_e_Tampo { get; set; }
		[Display(Name = "Eficiência de Junta do Costado")]
		public double Eficiencia_de_Junta_do_Costado { get; set; }
		[Display(Name = "Eficiência de Junta dos Tampos")]
		public double Eficiencia_de_Junta_dos_Tampos { get; set; }
		[Display(Name = "Fator do Tampo Elíptico")]
		public double Fator_do_Tampo_Eliptico { get; set; }
	}
}
