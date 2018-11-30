using Dimensionamento.Cálculos;
using System;
using System.ComponentModel.DataAnnotations;

namespace Dimensionamento.Entities.Costado
{
	public class DadosOutputs
	{
		private double pEspessura_do_costado_sem_sobrespessura_de_corrosao;
		private double pEspessura_do_costado_com_sobrespessura_de_corrosao;

		private double pPressao_interna_maxima_admissivel_dos_tampos;
		private double pEspessura_dos_tampos_sem_sobrespessura_de_corrosao;
		private double pEspessura_dos_tampos_com_sobrespessura_de_corrosao;

		public NR_13_Tipos_de_Fluidos Classificacao_NR_13 { get; set; }
		[Display(Name = "Espessura do Costado sem sobrespessura de corrosão(mm)")]
		public double Espessura_do_costado_sem_sobrespessura_de_corrosao { get => double.Parse(pEspessura_do_costado_sem_sobrespessura_de_corrosao.ToString("0.00")); set => pEspessura_do_costado_sem_sobrespessura_de_corrosao = value; }
		[Display(Name = "Espessura do Costado com sobrespessura de corrosão(mm)")]
		public double Espessura_do_costado_com_sobrespessura_de_corrosao { get => double.Parse(pEspessura_do_costado_com_sobrespessura_de_corrosao.ToString("0.00")); set => pEspessura_do_costado_com_sobrespessura_de_corrosao = value; }
		[Display(Name = "Pressão interna máxima admissível dos Tampos(Mpa)")]
		public double Pressao_interna_maxima_admissivel_dos_tampos
		{
			get => double.Parse(pPressao_interna_maxima_admissivel_dos_tampos.ToString("0.00"));
			set => pPressao_interna_maxima_admissivel_dos_tampos = value;
		}
		[Display(Name = "Espessura do Tampo sem sobrespessura de corrosão(mm)")]
		public double Espessura_dos_tampos_sem_sobrespessura_de_corrosao
		{
			get => double.Parse(pEspessura_dos_tampos_sem_sobrespessura_de_corrosao.ToString("0.00"));
			set => pEspessura_dos_tampos_sem_sobrespessura_de_corrosao = value;
		}
		[Display(Name = "Espessura do Tampo com sobrespessura de corrosão(mm)")]
		public double Espessura_dos_tampos_com_sobrespessura_de_corrosao
		{
			get => double.Parse(pEspessura_dos_tampos_com_sobrespessura_de_corrosao.ToString("0.00"));
			set => pEspessura_dos_tampos_com_sobrespessura_de_corrosao = value;
		}

		public DadosOutputs(DadosDeProjeto dados)
		{
			Classificacao_NR_13 = new NR_13_Tipos_de_Fluidos(dados);

			Espessura_do_costado_sem_sobrespessura_de_corrosao = EspessuraDoCostado.ResultadoSemSobrespessuraDeCorrosao(dados);
			Espessura_do_costado_com_sobrespessura_de_corrosao = EspessuraDoCostado.ResultadoComSobrespessuraDeCorrosao(dados);
			dados.Espessura_do_Costado = Espessura_do_costado_com_sobrespessura_de_corrosao;

			var dimensionamentoDosTampos = verificarPaDosTampos(dados);
			Espessura_dos_tampos_sem_sobrespessura_de_corrosao = dimensionamentoDosTampos.EspessuraDosTampos - dados.Sobrespessura_de_Corrosao;
			Espessura_dos_tampos_com_sobrespessura_de_corrosao = dimensionamentoDosTampos.EspessuraDosTampos;
			Pressao_interna_maxima_admissivel_dos_tampos = dimensionamentoDosTampos.Pa;
		}

		private DimensionamentoDosTampos verificarPaDosTampos(DadosDeProjeto dados)
		{
			var dimensionamentoDosTampos = new DimensionamentoDosTampos(dados);

			if (dimensionamentoDosTampos.Pa >= dados.Pressao_Interna_de_Projeto)
			{
				return dimensionamentoDosTampos;
			}
			else
			{
				dados.Espessura_do_Costado += 1;
				return verificarPaDosTampos(dados);
			}
		}

		public DadosOutputs(DadosOutputs outputs)
		{
			Classificacao_NR_13 = new NR_13_Tipos_de_Fluidos(outputs.Classificacao_NR_13);

			Espessura_do_costado_sem_sobrespessura_de_corrosao = outputs.Espessura_do_costado_sem_sobrespessura_de_corrosao;
			Espessura_do_costado_com_sobrespessura_de_corrosao = outputs.Espessura_do_costado_com_sobrespessura_de_corrosao;

			Espessura_dos_tampos_sem_sobrespessura_de_corrosao = outputs.Espessura_dos_tampos_sem_sobrespessura_de_corrosao;
			Espessura_dos_tampos_com_sobrespessura_de_corrosao = outputs.Espessura_dos_tampos_com_sobrespessura_de_corrosao;
			Pressao_interna_maxima_admissivel_dos_tampos = outputs.Pressao_interna_maxima_admissivel_dos_tampos;
		}
	}
}
