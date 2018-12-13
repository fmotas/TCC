using Dimensionamento.Entities;
using System;

namespace Dimensionamento.Cálculos
{
	public static class EspessuraDosBocais
	{
		public static double DN;
		public static double E;
		public static double Sn;
		public static double P;
		public static double C;
		public static void SetEspessuraDoBocal(Bocal bocal, DadosDeProjeto dados)
		{
			ConfigurarVariaveisBase(bocal, dados);
			Calculart1(bocal);
			Calculart2(bocal);
		}

		private static void Calculart2(Bocal bocal)
		{
			var t2 = Table452.getMinimumThickness(DN);

			bocal.t2 = t2 + C;
		}

		private static void Calculart1(Bocal bocal)
		{
			var t1 = (DN / 2) * ((Math.Exp(P / (Sn * E))) - 1);

			if (t1 > bocal.t1_Sem_Sobrespessura_de_Corrosao)
			{
				bocal.t1_Sem_Sobrespessura_de_Corrosao = t1;
			}

			bocal.t1_Com_Sobrespessura_de_Corrosao = bocal.t1_Sem_Sobrespessura_de_Corrosao + C;
		}

		private static void ConfigurarVariaveisBase(Bocal bocal, DadosDeProjeto dados)
		{
			bocal.Tensão_Admissivel_Para_o_Bocal_a_Temperatura_de_Projeto = CalculosGerais.GetTensaoMaximaAdmissivel("Bocal", dados.Temperatura_de_Projeto, bocal.Material);

			DN = bocal.Diametro_Nominal;
			E = bocal.Coeficiente_de_Eficiencia_de_Solda;
			Sn = bocal.Tensão_Admissivel_Para_o_Bocal_a_Temperatura_de_Projeto;
			P = dados.Pressao_Interna_de_Projeto;
			C = dados.Sobrespessura_de_Corrosao;
		}
	}
}
