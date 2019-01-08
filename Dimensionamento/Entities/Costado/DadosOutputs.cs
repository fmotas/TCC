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

		private double pEspessura_Bocal_de_Entrada_de_Fluido_t1_Sem_Sobrespessura_de_Corrosao;
		private double pEspessura_Bocal_de_Entrada_de_Fluido_t1_Com_Sobrespessura_de_Corrosao;
		private double pEspessura_Bocal_de_Entrada_de_Fluido_t2;

		private double pEspessura_Bocal_de_Saida_de_Gas_t1_Sem_Sobrespessura_de_Corrosao;
		private double pEspessura_Bocal_de_Saida_de_Gas_t1_Com_Sobrespessura_de_Corrosao;
		private double pEspessura_Bocal_de_Saida_de_Gas_t2;

		private double pEspessura_Bocal_de_Valvula_de_Seguranca_t1_Sem_Sobrespessura_de_Corrosao;
		private double pEspessura_Bocal_de_Valvula_de_Seguranca_t1_Com_Sobrespessura_de_Corrosao;
		private double pEspessura_Bocal_de_Valvula_de_Seguranca_t2;

		private double pEspessura_Bocal_de_Saida_de_Agua_t1_Sem_Sobrespessura_de_Corrosao;
		private double pEspessura_Bocal_de_Saida_de_Agua_t1_Com_Sobrespessura_de_Corrosao;
		private double pEspessura_Bocal_de_Saida_de_Agua_t2;

		private double pEspessura_Bocal_de_Saida_de_Oleo_t1_Sem_Sobrespessura_de_Corrosao;
		private double pEspessura_Bocal_de_Saida_de_Oleo_t1_Com_Sobrespessura_de_Corrosao;
		private double pEspessura_Bocal_de_Saida_de_Oleo_t2;

		private double pEspessura_Dreno_t1_Sem_Sobrespessura_de_Corrosao;
		private double pEspessura_Dreno_t1_Com_Sobrespessura_de_Corrosao;
		private double pEspessura_Dreno_t2;

		private double pEspessura_Respiradouro_t1_Sem_Sobrespessura_de_Corrosao;
		private double pEspessura_Respiradouro_t1_Com_Sobrespessura_de_Corrosao;
		private double pEspessura_Respiradouro_t2;

		private double pEspessura_Bocas_de_Visita_t1_Sem_Sobrespessura_de_Corrosao;
		private double pEspessura_Bocas_de_Visita_t1_Com_Sobrespessura_de_Corrosao;
		private double pEspessura_Bocas_de_Visita_t2;

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
		[Display(Name = "t1 Sem Sobrespessura de Corrosao(mm)")]
		public double Espessura_Bocal_de_Entrada_de_Fluido_t1_Sem_Sobrespessura_de_Corrosao
		{
			get => double.Parse(pEspessura_Bocal_de_Entrada_de_Fluido_t1_Sem_Sobrespessura_de_Corrosao.ToString("0.000"));
			set => pEspessura_Bocal_de_Entrada_de_Fluido_t1_Sem_Sobrespessura_de_Corrosao = value;
		}
		[Display(Name = "t1 Com Sobrespessura de Corrosao(mm)")]
		public double Espessura_Bocal_de_Entrada_de_Fluido_t1_Com_Sobrespessura_de_Corrosao
		{
			get => double.Parse(pEspessura_Bocal_de_Entrada_de_Fluido_t1_Com_Sobrespessura_de_Corrosao.ToString("0.000"));
			set => pEspessura_Bocal_de_Entrada_de_Fluido_t1_Com_Sobrespessura_de_Corrosao = value;
		}
		[Display(Name = "t2(mm)")]
		public double Espessura_Bocal_de_Entrada_de_Fluido_t2
		{
			get => double.Parse(pEspessura_Bocal_de_Entrada_de_Fluido_t2.ToString("0.000"));
			set => pEspessura_Bocal_de_Entrada_de_Fluido_t2 = value;
		}
		[Display(Name = "t1 Sem Sobrespessura de Corrosao(mm)")]
		public double Espessura_Bocal_de_Saida_de_Gas_t1_Sem_Sobrespessura_de_Corrosao
		{
			get => double.Parse(pEspessura_Bocal_de_Saida_de_Gas_t1_Sem_Sobrespessura_de_Corrosao.ToString("0.000"));
			set => pEspessura_Bocal_de_Saida_de_Gas_t1_Sem_Sobrespessura_de_Corrosao = value;
		}
		[Display(Name = "t1 Com Sobrespessura de Corrosao(mm)")]
		public double Espessura_Bocal_de_Saida_de_Gas_t1_Com_Sobrespessura_de_Corrosao
		{
			get => double.Parse(pEspessura_Bocal_de_Saida_de_Gas_t1_Com_Sobrespessura_de_Corrosao.ToString("0.000"));
			set => pEspessura_Bocal_de_Saida_de_Gas_t1_Com_Sobrespessura_de_Corrosao = value;
		}
		[Display(Name = "t2(mm)")]
		public double Espessura_Bocal_de_Saida_de_Gas_t2
		{
			get => double.Parse(pEspessura_Bocal_de_Saida_de_Gas_t2.ToString("0.000"));
			set => pEspessura_Bocal_de_Saida_de_Gas_t2 = value;
		}
		[Display(Name = "t1 Sem Sobrespessura de Corrosao(mm)")]
		public double Espessura_Bocal_de_Valvula_de_Seguranca_t1_Sem_Sobrespessura_de_Corrosao
		{
			get => double.Parse(pEspessura_Bocal_de_Valvula_de_Seguranca_t1_Sem_Sobrespessura_de_Corrosao.ToString("0.000"));
			set => pEspessura_Bocal_de_Valvula_de_Seguranca_t1_Sem_Sobrespessura_de_Corrosao = value;
		}
		[Display(Name = "t1 Com Sobrespessura de Corrosao(mm)")]
		public double Espessura_Bocal_de_Valvula_de_Seguranca_t1_Com_Sobrespessura_de_Corrosao
		{
			get => double.Parse(pEspessura_Bocal_de_Valvula_de_Seguranca_t1_Com_Sobrespessura_de_Corrosao.ToString("0.000"));
			set => pEspessura_Bocal_de_Valvula_de_Seguranca_t1_Com_Sobrespessura_de_Corrosao = value;
		}
		[Display(Name = "t2(mm)")]
		public double Espessura_Bocal_de_Valvula_de_Seguranca_t2
		{
			get => double.Parse(pEspessura_Bocal_de_Valvula_de_Seguranca_t2.ToString("0.000"));
			set => pEspessura_Bocal_de_Valvula_de_Seguranca_t2 = value;
		}
		//[Display(Name = "t1 Sem Sobrespessura de Corrosao(mm)")]
		//public double Espessura_Bocal_de_Saida_de_Agua_t1_Sem_Sobrespessura_de_Corrosao
		//{
		//	get => double.Parse(pEspessura_Bocal_de_Saida_de_Agua_t1_Sem_Sobrespessura_de_Corrosao.ToString("0.000"));
		//	set => pEspessura_Bocal_de_Saida_de_Agua_t1_Sem_Sobrespessura_de_Corrosao = value;
		//}
		//[Display(Name = "t1 Com Sobrespessura de Corrosao(mm)")]
		//public double Espessura_Bocal_de_Saida_de_Agua_t1_Com_Sobrespessura_de_Corrosao
		//{
		//	get => double.Parse(pEspessura_Bocal_de_Saida_de_Agua_t1_Com_Sobrespessura_de_Corrosao.ToString("0.000"));
		//	set => pEspessura_Bocal_de_Saida_de_Agua_t1_Com_Sobrespessura_de_Corrosao = value;
		//}
		//[Display(Name = "t2(mm)")]
		//public double Espessura_Bocal_de_Saida_de_Agua_t2
		//{
		//	get => double.Parse(pEspessura_Bocal_de_Saida_de_Agua_t2.ToString("0.000"));
		//	set => pEspessura_Bocal_de_Saida_de_Agua_t2 = value;
		//}
		//[Display(Name = "t1 Sem Sobrespessura de Corrosao(mm)")]
		//public double Espessura_Bocal_de_Saida_de_Oleo_t1_Sem_Sobrespessura_de_Corrosao
		//{
		//	get => double.Parse(pEspessura_Bocal_de_Saida_de_Oleo_t1_Sem_Sobrespessura_de_Corrosao.ToString("0.000"));
		//	set => pEspessura_Bocal_de_Saida_de_Oleo_t1_Sem_Sobrespessura_de_Corrosao = value;
		//}
		//[Display(Name = "t1 Com Sobrespessura de Corrosao(mm)")]
		//public double Espessura_Bocal_de_Saida_de_Oleo_t1_Com_Sobrespessura_de_Corrosao
		//{
		//	get => double.Parse(pEspessura_Bocal_de_Saida_de_Oleo_t1_Com_Sobrespessura_de_Corrosao.ToString("0.000"));
		//	set => pEspessura_Bocal_de_Saida_de_Oleo_t1_Com_Sobrespessura_de_Corrosao = value;
		//}
		//[Display(Name = "t2(mm)")]
		//public double Espessura_Bocal_de_Saida_de_Oleo_t2
		//{
		//	get => double.Parse(pEspessura_Bocal_de_Saida_de_Oleo_t2.ToString("0.000"));
		//	set => pEspessura_Bocal_de_Saida_de_Oleo_t2 = value;
		//}
		[Display(Name = "t1 Sem Sobrespessura de Corrosao(mm)")]
		public double Espessura_Dreno_t1_Sem_Sobrespessura_de_Corrosao
		{
			get => double.Parse(pEspessura_Dreno_t1_Sem_Sobrespessura_de_Corrosao.ToString("0.000"));
			set => pEspessura_Dreno_t1_Sem_Sobrespessura_de_Corrosao = value;
		}
		[Display(Name = "t1 Com Sobrespessura de Corrosao(mm)")]
		public double Espessura_Dreno_t1_Com_Sobrespessura_de_Corrosao
		{
			get => double.Parse(pEspessura_Dreno_t1_Com_Sobrespessura_de_Corrosao.ToString("0.000"));
			set => pEspessura_Dreno_t1_Com_Sobrespessura_de_Corrosao = value;
		}
		[Display(Name = "t2(mm)")]
		public double Espessura_Dreno_t2
		{
			get => double.Parse(pEspessura_Dreno_t2.ToString("0.000"));
			set => pEspessura_Dreno_t2 = value;
		}
		[Display(Name = "t1 Sem Sobrespessura de Corrosao(mm)")]
		public double Espessura_Respiradouro_t1_Sem_Sobrespessura_de_Corrosao
		{
			get => double.Parse(pEspessura_Respiradouro_t1_Sem_Sobrespessura_de_Corrosao.ToString("0.000"));
			set => pEspessura_Respiradouro_t1_Sem_Sobrespessura_de_Corrosao = value;
		}
		[Display(Name = "t1 Com Sobrespessura de Corrosao(mm)")]
		public double Espessura_Respiradouro_t1_Com_Sobrespessura_de_Corrosao
		{
			get => double.Parse(pEspessura_Respiradouro_t1_Com_Sobrespessura_de_Corrosao.ToString("0.000"));
			set => pEspessura_Respiradouro_t1_Com_Sobrespessura_de_Corrosao = value;
		}
		[Display(Name = "t2(mm)")]
		public double Espessura_Respiradouro_t2
		{
			get => double.Parse(pEspessura_Respiradouro_t2.ToString("0.000"));
			set => pEspessura_Respiradouro_t2 = value;
		}
		[Display(Name = "t1 Sem Sobrespessura de Corrosao(mm)")]
		public double Espessura_Bocas_de_Visita_t1_Sem_Sobrespessura_de_Corrosao
		{
			get => double.Parse(pEspessura_Bocas_de_Visita_t1_Sem_Sobrespessura_de_Corrosao.ToString("0.000"));
			set => pEspessura_Bocas_de_Visita_t1_Sem_Sobrespessura_de_Corrosao = value;
		}
		[Display(Name = "t1 Com Sobrespessura de Corrosao(mm)")]
		public double Espessura_Bocas_de_Visita_t1_Com_Sobrespessura_de_Corrosao
		{
			get => double.Parse(pEspessura_Bocas_de_Visita_t1_Com_Sobrespessura_de_Corrosao.ToString("0.000"));
			set => pEspessura_Bocas_de_Visita_t1_Com_Sobrespessura_de_Corrosao = value;
		}
		[Display(Name = "t2(mm)")]
		public double Espessura_Bocas_de_Visita_t2
		{
			get => double.Parse(pEspessura_Bocas_de_Visita_t2.ToString("0.000"));
			set => pEspessura_Bocas_de_Visita_t2 = value;
		}

		public DadosOutputs(DadosDeProjeto dados)
		{
			Classificacao_NR_13 = new NR_13_Tipos_de_Fluidos(dados);

			Espessura_do_costado_sem_sobrespessura_de_corrosao = EspessuraDoCostado.ResultadoSemSobrespessuraDeCorrosao(dados);
			Espessura_do_costado_com_sobrespessura_de_corrosao = EspessuraDoCostado.ResultadoComSobrespessuraDeCorrosao(dados);
			dados.Espessura_do_Costado = Espessura_do_costado_com_sobrespessura_de_corrosao;

			var dimensionamentoDosTampos = VerificarPaDosTampos(dados);
			Espessura_dos_tampos_sem_sobrespessura_de_corrosao = dimensionamentoDosTampos.EspessuraDosTampos - dados.Sobrespessura_de_Corrosao;
			Espessura_dos_tampos_com_sobrespessura_de_corrosao = dimensionamentoDosTampos.EspessuraDosTampos;
			Pressao_interna_maxima_admissivel_dos_tampos = dimensionamentoDosTampos.Pa;
			

			Espessura_Bocal_de_Entrada_de_Fluido_t1_Sem_Sobrespessura_de_Corrosao = dados.Bocal_de_Entrada_de_Fluido.t1_Sem_Sobrespessura_de_Corrosao;
			Espessura_Bocal_de_Entrada_de_Fluido_t1_Com_Sobrespessura_de_Corrosao = dados.Bocal_de_Entrada_de_Fluido.t1_Com_Sobrespessura_de_Corrosao;
			Espessura_Bocal_de_Entrada_de_Fluido_t2 = dados.Bocal_de_Entrada_de_Fluido.t2;

			Espessura_Bocal_de_Saida_de_Gas_t1_Sem_Sobrespessura_de_Corrosao = dados.Bocal_de_Saida_de_Gas.t1_Sem_Sobrespessura_de_Corrosao;
			Espessura_Bocal_de_Saida_de_Gas_t1_Com_Sobrespessura_de_Corrosao = dados.Bocal_de_Saida_de_Gas.t1_Com_Sobrespessura_de_Corrosao;
			Espessura_Bocal_de_Saida_de_Gas_t2 = dados.Bocal_de_Saida_de_Gas.t2;

			Espessura_Bocal_de_Valvula_de_Seguranca_t1_Sem_Sobrespessura_de_Corrosao = dados.Bocal_de_Valvula_de_Seguranca.t1_Sem_Sobrespessura_de_Corrosao;
			Espessura_Bocal_de_Valvula_de_Seguranca_t1_Com_Sobrespessura_de_Corrosao = dados.Bocal_de_Valvula_de_Seguranca.t1_Com_Sobrespessura_de_Corrosao;
			Espessura_Bocal_de_Valvula_de_Seguranca_t2 = dados.Bocal_de_Valvula_de_Seguranca.t2;

			//Espessura_Bocal_de_Saida_de_Agua_t1_Sem_Sobrespessura_de_Corrosao = dados.Bocal_de_Saida_de_Agua.t1_Sem_Sobrespessura_de_Corrosao;
			//Espessura_Bocal_de_Saida_de_Agua_t1_Com_Sobrespessura_de_Corrosao = dados.Bocal_de_Saida_de_Agua.t1_Com_Sobrespessura_de_Corrosao;
			//Espessura_Bocal_de_Saida_de_Agua_t2 = dados.Bocal_de_Saida_de_Agua.t2;

			//Espessura_Bocal_de_Saida_de_Oleo_t1_Sem_Sobrespessura_de_Corrosao = dados.Bocal_de_Saida_de_Oleo.t1_Sem_Sobrespessura_de_Corrosao;
			//Espessura_Bocal_de_Saida_de_Oleo_t1_Com_Sobrespessura_de_Corrosao = dados.Bocal_de_Saida_de_Oleo.t1_Com_Sobrespessura_de_Corrosao;
			//Espessura_Bocal_de_Saida_de_Oleo_t2 = dados.Bocal_de_Saida_de_Oleo.t2;

			Espessura_Dreno_t1_Sem_Sobrespessura_de_Corrosao = dados.Dreno.t1_Sem_Sobrespessura_de_Corrosao;
			Espessura_Dreno_t1_Com_Sobrespessura_de_Corrosao = dados.Dreno.t1_Com_Sobrespessura_de_Corrosao;
			Espessura_Dreno_t2 = dados.Dreno.t2;

			Espessura_Respiradouro_t1_Sem_Sobrespessura_de_Corrosao = dados.Respiradouro.t1_Sem_Sobrespessura_de_Corrosao;
			Espessura_Respiradouro_t1_Com_Sobrespessura_de_Corrosao = dados.Respiradouro.t1_Com_Sobrespessura_de_Corrosao;
			Espessura_Respiradouro_t2 = dados.Respiradouro.t2;

			Espessura_Bocas_de_Visita_t1_Sem_Sobrespessura_de_Corrosao = dados.Bocas_de_Visita.t1_Sem_Sobrespessura_de_Corrosao;
			Espessura_Bocas_de_Visita_t1_Com_Sobrespessura_de_Corrosao = dados.Bocas_de_Visita.t1_Com_Sobrespessura_de_Corrosao;
			Espessura_Bocas_de_Visita_t2 = dados.Bocas_de_Visita.t2;
		}

		private DimensionamentoDosTampos VerificarPaDosTampos(DadosDeProjeto dados)
		{
			var dimensionamentoDosTampos = new DimensionamentoDosTampos(dados);

			if (dimensionamentoDosTampos.Pa >= dados.Pressao_Interna_de_Projeto)
			{
				return dimensionamentoDosTampos;
			}
			else
			{
				dados.Espessura_do_Costado += 1;
				return VerificarPaDosTampos(dados);
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

			Espessura_Bocal_de_Entrada_de_Fluido_t1_Sem_Sobrespessura_de_Corrosao = outputs.Espessura_Bocal_de_Entrada_de_Fluido_t1_Sem_Sobrespessura_de_Corrosao;
			Espessura_Bocal_de_Entrada_de_Fluido_t1_Com_Sobrespessura_de_Corrosao = outputs.Espessura_Bocal_de_Entrada_de_Fluido_t1_Com_Sobrespessura_de_Corrosao;
			Espessura_Bocal_de_Entrada_de_Fluido_t2 = outputs.Espessura_Bocal_de_Entrada_de_Fluido_t2;

			Espessura_Bocal_de_Saida_de_Gas_t1_Sem_Sobrespessura_de_Corrosao = outputs.Espessura_Bocal_de_Saida_de_Gas_t1_Sem_Sobrespessura_de_Corrosao;
			Espessura_Bocal_de_Saida_de_Gas_t1_Com_Sobrespessura_de_Corrosao = outputs.Espessura_Bocal_de_Saida_de_Gas_t1_Com_Sobrespessura_de_Corrosao;
			Espessura_Bocal_de_Saida_de_Gas_t2 = outputs.Espessura_Bocal_de_Saida_de_Gas_t2;

			Espessura_Bocal_de_Valvula_de_Seguranca_t1_Sem_Sobrespessura_de_Corrosao = outputs.Espessura_Bocal_de_Valvula_de_Seguranca_t1_Sem_Sobrespessura_de_Corrosao;
			Espessura_Bocal_de_Valvula_de_Seguranca_t1_Com_Sobrespessura_de_Corrosao = outputs.Espessura_Bocal_de_Valvula_de_Seguranca_t1_Com_Sobrespessura_de_Corrosao;
			Espessura_Bocal_de_Valvula_de_Seguranca_t2 = outputs.Espessura_Bocal_de_Valvula_de_Seguranca_t2;

			//Espessura_Bocal_de_Saida_de_Agua_t1_Sem_Sobrespessura_de_Corrosao = outputs.Espessura_Bocal_de_Saida_de_Agua_t1_Sem_Sobrespessura_de_Corrosao;
			//Espessura_Bocal_de_Saida_de_Agua_t1_Com_Sobrespessura_de_Corrosao = outputs.Espessura_Bocal_de_Saida_de_Agua_t1_Com_Sobrespessura_de_Corrosao;
			//Espessura_Bocal_de_Saida_de_Agua_t2 = outputs.Espessura_Bocal_de_Saida_de_Agua_t2;

			//Espessura_Bocal_de_Saida_de_Oleo_t1_Sem_Sobrespessura_de_Corrosao = outputs.Espessura_Bocal_de_Saida_de_Oleo_t1_Sem_Sobrespessura_de_Corrosao;
			//Espessura_Bocal_de_Saida_de_Oleo_t1_Com_Sobrespessura_de_Corrosao = outputs.Espessura_Bocal_de_Saida_de_Oleo_t1_Com_Sobrespessura_de_Corrosao;
			//Espessura_Bocal_de_Saida_de_Oleo_t2 = outputs.Espessura_Bocal_de_Saida_de_Oleo_t2;

			Espessura_Dreno_t1_Sem_Sobrespessura_de_Corrosao = outputs.Espessura_Dreno_t1_Sem_Sobrespessura_de_Corrosao;
			Espessura_Dreno_t1_Com_Sobrespessura_de_Corrosao = outputs.Espessura_Dreno_t1_Com_Sobrespessura_de_Corrosao;
			Espessura_Dreno_t2 = outputs.Espessura_Dreno_t2;

			Espessura_Respiradouro_t1_Sem_Sobrespessura_de_Corrosao = outputs.Espessura_Respiradouro_t1_Sem_Sobrespessura_de_Corrosao;
			Espessura_Respiradouro_t1_Com_Sobrespessura_de_Corrosao = outputs.Espessura_Respiradouro_t1_Com_Sobrespessura_de_Corrosao;
			Espessura_Respiradouro_t2 = outputs.Espessura_Respiradouro_t2;

			Espessura_Bocas_de_Visita_t1_Sem_Sobrespessura_de_Corrosao = outputs.Espessura_Bocas_de_Visita_t1_Sem_Sobrespessura_de_Corrosao;
			Espessura_Bocas_de_Visita_t1_Com_Sobrespessura_de_Corrosao = outputs.Espessura_Bocas_de_Visita_t1_Com_Sobrespessura_de_Corrosao;
			Espessura_Bocas_de_Visita_t2 = outputs.Espessura_Bocas_de_Visita_t2;
		}
	}
}
