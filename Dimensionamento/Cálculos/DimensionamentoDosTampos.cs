using Dimensionamento.Entities;
using System;

namespace Dimensionamento.Cálculos
{
	public class DimensionamentoDosTampos
	{
		public double h;
		public double k;
		public double r;
		public double L;

		public double P;
		public double D;
		public double E;
		public double S;
		public double C;
		public double Et;
		public double Sy;
		public double Fte;
		public double EspessuraDosTampos;

		public bool condicoesPasso2;

		public double Bth;
		public double Oth;
		public double Rth;

		public double C1;
		public double C2;

		public double Peth;

		public double Py;
		public double C3;

		public double Pck;
		public double G;

		public double Pak;

		public double Pac;

		public double Pa;

		public DimensionamentoDosTampos(DadosDeProjeto dados)
		{
			ConfigurarVariaveisBase(dados);
			CalcularVariaveisBaseTampos(dados);
			condicoesPasso2 = VerificarCondicoesPasso2();
			CalcularConstantesPasso3();
			CalcularConstantesPasso4();
			CalcularPethPasso5();
			CalcularPyPasso6();
			CalcularPckPasso7();
			CalcularPakPasso8();
			CalcularPacPasso9();
			CalcularPaPasso10();
		}

		private void CalcularPaPasso10()
		{
			if (Pak <= Pac)
			{
				Pa = Pak;
			}
			else if (Pak > Pac)
			{
				Pa = Pac;
			}
		}

		private void CalcularPacPasso9()
		{
			var pacNumerador = 2 * S * E;
			var pacDenominador = (L / EspessuraDosTampos) + 0.5;

			Pac = pacNumerador / pacDenominador;
		}

		private void CalcularPakPasso8()
		{
			Pak = Pck / 1.5;
		}

		private void CalcularPckPasso7()
		{
			G = Peth / Py;

			if (G <= 1.0)
			{
				Pck = 0.6 * Peth;
			}
			else if (G > 1.0)
			{
				var pckNumerador = (0.77508 * G) - (0.20354 * Math.Pow(G, 2)) + (0.019274 * Math.Pow(G, 3));
				var pckDenominador = 1 + (0.19014 * G) - (0.089534 * Math.Pow(G, 2)) + (0.0093965 * Math.Pow(G, 3));

				Pck = (pckNumerador / pckDenominador) * Py;
			}
		}

		private void CalcularPyPasso6()
		{
			C3 = Sy;

			Py = (C3 * EspessuraDosTampos) / (C2 * Rth * ((Rth / (2 * r)) - 1));
		}

		private void CalcularPethPasso5()
		{
			Peth = (C1 * Et * Math.Pow(EspessuraDosTampos, 2)) / (C2 * Rth * ((Rth / 2) - r));
		}

		private void CalcularConstantesPasso4()
		{
			var rbyD = r / D;

			if (rbyD <= 0.08)
			{
				C1 = (9.31 * rbyD) - 0.086;
				C2 = 1.25;
			}
			else if (rbyD > 0.08)
			{
				C1 = (0.692 * rbyD) + 0.605;
				C2 = 1.46 - (2.6 * rbyD);
			}
		}

		private void CalcularConstantesPasso3()
		{
			Bth = Math.Acos(((0.5 * D) - r) / (L - r));
			Oth = Math.Sqrt(L * EspessuraDosTampos) / r;

			if (Oth < Bth)
			{
				Rth = (((0.5 * D) - r) / (Math.Cos(Bth - Oth))) + r;
			}
			else if (Oth >= Bth)
			{
				Rth = 0.5 * D;
			}
		}

		private bool VerificarCondicoesPasso2()
		{
			var cond1 = L / D;
			var cond2 = r / D;
			var cond3 = L / EspessuraDosTampos;

			if (!(cond1 >= 0.7 && cond1 <= 1.0))
			{
				return false;
			}

			if (!(cond2 >= 0.6))
			{
				return false;
			}

			if (!(cond3 >= 20.0 && cond3 <= 2000.0))
			{
				return false;
			}

			return true;
		}

		private void ConfigurarVariaveisBase(DadosDeProjeto dados)
		{
			P = dados.Pressao_Interna_de_Projeto;
			D = dados.Diametro_Interno;
			E = dados.Eficiencia_de_Junta_dos_Tampos;
			S = dados.Maxima_Tensao_Admissivel;
			C = dados.Sobrespessura_de_Corrosao;
			Et = dados.Modulo_de_Elasticidade_a_Temperatura_Maxima_de_Projeto;
			Sy = dados.Tensao_de_Escoamento_do_Material_a_Temperatura_de_Projeto;
			Fte = dados.Fator_do_Tampo_Eliptico;
			EspessuraDosTampos = dados.Espessura_do_Costado;
		}

		private void CalcularVariaveisBaseTampos(DadosDeProjeto dados)
		{
			h = D / (2 * Fte);
			k = D / (2 * h);
			r = D * ((0.5 / k) - 0.08);
			L = D * ((0.44 * k) + 0.02);
		}
	}
}
