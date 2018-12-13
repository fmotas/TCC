using Dimensionamento.Entities;
using System;

namespace Dimensionamento.Cálculos
{
	public class EspessuraDoCostado
	{
		public static double ResultadoSemSobrespessuraDeCorrosao(DadosDeProjeto dados)
		{
			var material = dados.Materiais.Cascos_e_Tampos;
			var temperaturaDeProjeto = dados.Temperatura_de_Projeto;
			var parte = "Cascos e Tampos";

			var P = dados.Pressao_Interna_de_Projeto;
			var D = dados.Diametro_Interno;
			var S = CalculosGerais.GetTensaoMaximaAdmissivel(parte, temperaturaDeProjeto, material);
			var E = dados.Eficiencia_de_Junta_do_Costado;


			var resultadoSemSobrespessuraDeCorrosao = (D / 2) * ((Math.Exp(P / (S * E))) - 1);

			//O capítulo 4, seção 4.1, subseção 4.1.2 diz que a espessura mínima sem sobrespessura de corrosão é de 1,6 mm.
			if (resultadoSemSobrespessuraDeCorrosao < 1.6)
			{
				resultadoSemSobrespessuraDeCorrosao = 1.6;
			}

			return resultadoSemSobrespessuraDeCorrosao;
		}

		public static double ResultadoComSobrespessuraDeCorrosao(DadosDeProjeto dados)
		{
			var C = dados.Sobrespessura_de_Corrosao;
			var resultadoComSobrespessuraDeCorrosao = ResultadoSemSobrespessuraDeCorrosao(dados) + C;

			return resultadoComSobrespessuraDeCorrosao;
		}
	}
}
