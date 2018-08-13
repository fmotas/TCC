using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dimensionamento.Entities;

namespace Dimensionamento.Cálculos
{
    public class EspessuraDoCostado
    {
	    public static double ResultadoSemSobrespessuraDeCorrosao(DadosDeProjeto dados)
	    {
		    var P = dados.Pressao_Interna_de_Projeto;
		    var D = dados.Diametro_Interno;
		    var S = 157;
		    var E = dados.Eficiencia_de_Junta_do_Costado;
		    var C = dados.Sobrespessura_de_Corrosao;

		    var resultadoSemSobrespessuraDeCorrosao = (D / 2) * ((Math.Exp(P / (S * E))) - 1);
		    return resultadoSemSobrespessuraDeCorrosao;
	    }

	    public static double ResultadoComSobrespessuraDeCorrosao(DadosDeProjeto dados)
	    {
		    var resultadoComSobrespessuraDeCorrosao =
			    ResultadoSemSobrespessuraDeCorrosao(dados) + dados.Sobrespessura_de_Corrosao;

			return resultadoComSobrespessuraDeCorrosao;
	    }
	}
}
