using System;
using Dimensionamento.Controllers;
using Dimensionamento.Cálculos;
using Dimensionamento.Entities;
using Xunit;

namespace DimensionamentoTests
{
	public class EspessuraDoCostadoTests
	{
		public readonly DadosDeProjeto dados = new DadosDeProjeto
		{
			Tipo_de_Casco_ou_Costado = "Cilíndrico",
			Tipo_de_Tampo = "Eliptico",
			Pressao_de_Operacao_Maxima = 2,
			Pressao_de_Operacao_Minima = 1.5,
			Pressao_Interna_de_Projeto = 2.5,
			Pressao_Externa_de_Projeto = 0.1030,
			Temperatura_de_Operacao = 40,
			Temperatura_de_Projeto = 105,
			Diametro_Interno = 3150,
			Comprimento_Entre_Tangentes = 9000,
			Volume_Interno = 78,
			Sobrespessura_de_Corrosao = 3,
			Fluido = "Gás/Óleo/Água",
			Gravidade_Especifica = 1133,
			Teste_de_Pressao_Hidrostatica = 3.8,
			Nivel_de_Liquido = new NivelDeLiquido
			{
				Maximo = 2150,
				Minimo = 350
			},
			Materiais = new Materiais
			{
				Cascos_e_Tampos = "SA- 516 Gr.70",
				Suportes = "SA - 36",
				Pescoco_de_Bocais = "SA-105/SA-106 Gr.B",
				Boca_de_Visita = "SA-516 Gr.70",
				Luvas = "SA-105",
				Internos_Chapas = "SA-516 Gr.70",
				Parafusos = "SA-193 Gr.B7"
			},
			Juntas_de_Topo = "Tipo 1",
			Radiografia_do_Casco_e_Tampo = "Total",
			Eficiencia_de_Junta_do_Costado = 1,
			Eficiencia_de_Junta_dos_Tampos = 1,
			Fator_do_Tampo_Eliptico = 2
		};
		
		[Fact]
		public void EspessuraShoulBe2528()
		{
			var result = EspessuraDoCostado.ResultadoSemSobrespessuraDeCorrosao(dados);

			Assert.Equal(25.28, result, 2);
		}

		[Fact]
		public void EspessuraShoulBe2828()
		{
			var result = EspessuraDoCostado.ResultadoComSobrespessuraDeCorrosao(dados);

			Assert.Equal(28.28, result, 2);
		}
	}
}
