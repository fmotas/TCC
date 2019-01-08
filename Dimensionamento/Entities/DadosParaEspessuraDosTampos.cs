using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dimensionamento.Entities
{
    public class DadosParaEspessuraDosTampos : DadosParaEspessuraDosBocais
	{
		[Display(Name = "Fator de Junta Soldada")]
		public double Fator_de_Junta_Soldada { get; set; }
		[Display(Name = "Máxima Tensão Admissível(Mpa)")]
		public double Maxima_Tensao_Admissivel { get; set; }
		[Display(Name = "Raio da Coroa(mm)")]
		public double Raio_da_Coroa { get; set; }
		[Display(Name = "Raio do Rebordo(mm)")]
		public double Raio_do_Rebordo { get; set; }
		[Display(Name = "Fator do Tampo Elíptico")]
		public double Fator_do_Tampo_Eliptico { get; set; }
		//[Display(Name = "Módulo de Elasticidade à Temperatura Máxima de Projeto(Mpa)")]
		//public double Modulo_de_Elasticidade_a_Temperatura_Maxima_de_Projeto { get; set; }
		//[Display(Name = "Tensão de Escoamento do Material à Temperatura Máxima de Projeto(Mpa)")]
		//public double Tensao_de_Escoamento_do_Material_a_Temperatura_de_Projeto { get; set; }
		[Display(Name = "Espessura dos Tampos(mm)")]
		public double Espessura_dos_Tampo { get; set; }
	}
}
