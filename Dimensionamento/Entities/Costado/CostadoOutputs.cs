using Dimensionamento.Cálculos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dimensionamento.Entities.Costado
{
	public class CostadoOutputs
	{
		private double pEspessura_sem_sobrespessura_de_corrosao;
		private double pEspessura_com_sobrespessura_de_corrosao;
		public NR_13_Tipos_de_Fluidos Classificacao_NR_13 { get; set; }
		[Display(Name = "Espessura sem sobrespessura de corrosão(mm)")]
		public double Espessura_sem_sobrespessura_de_corrosao { get => double.Parse(pEspessura_sem_sobrespessura_de_corrosao.ToString("0.00")); set => pEspessura_sem_sobrespessura_de_corrosao = value; }
		[Display(Name = "Espessura com sobrespessura de corrosão(mm)")]
		public double Espessura_com_sobrespessura_de_corrosao { get => double.Parse(pEspessura_com_sobrespessura_de_corrosao.ToString("0.00")); set => pEspessura_com_sobrespessura_de_corrosao = value; }

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
