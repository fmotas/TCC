using Dimensionamento.Cálculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dimensionamento.Entities.Costado
{
	public class CostadoOutputs
	{
		public NR_13_Tipos_de_Fluidos Classificacao_NR_13 { get; set; }
		public double Espessura_sem_sobrespessura_de_corrosao { get; set; }
		public double Espessura_com_sobrespessura_de_corrosao { get; set; }

		public CostadoOutputs(DadosDeProjeto dados)
		{
			Classificacao_NR_13 = new NR_13_Tipos_de_Fluidos(dados);
			Espessura_sem_sobrespessura_de_corrosao = EspessuraDoCostado.ResultadoSemSobrespessuraDeCorrosao(dados);
			Espessura_com_sobrespessura_de_corrosao = EspessuraDoCostado.ResultadoComSobrespessuraDeCorrosao(dados);
		}

		public CostadoOutputs(CostadoOutputs outputs)
		{
			Classificacao_NR_13 = new NR_13_Tipos_de_Fluidos(outputs.Classificacao_NR_13);
			Espessura_sem_sobrespessura_de_corrosao = outputs.Espessura_sem_sobrespessura_de_corrosao;
			Espessura_com_sobrespessura_de_corrosao = outputs.Espessura_com_sobrespessura_de_corrosao;
		}
	}
}
