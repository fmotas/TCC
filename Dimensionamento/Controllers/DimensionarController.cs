using Dimensionamento.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using Dimensionamento.Cálculos;

namespace Dimensionamento.Controllers
{
	public class DimensionarController : Controller
	{
		[HttpGet]
		public IActionResult DadosDeProjeto()
		{
			return View();
		}

		[HttpPost]
		public IActionResult DadosDeProjeto(DadosDeProjeto dados)
		{
			var textoInformativo = TextoInformativo(dados);

			return Content(textoInformativo);
		}

		public static string TextoInformativo(DadosDeProjeto dados)
		{
			var resultadoSemSobrespessuradeCorrosao = 
				EspessuraDoCostado.ResultadoSemSobrespessuraDeCorrosao(dados);
			var resultadoComSobrespessuradeCorrosao =
				EspessuraDoCostado.ResultadoComSobrespessuraDeCorrosao(dados);
			var textoResultadoSemSobrespessuradeCorrosao =
				$"{resultadoSemSobrespessuradeCorrosao}mm sem sobrespessura de corrosão.";
			var textoResultadoComSobrespessuradeCorrosao =
				$"{resultadoComSobrespessuradeCorrosao}mm com sobrespessura de corrosão.";

			var textoInformativo = $"Usando os dados:" +
								   Environment.NewLine +
								   $"Pressão Interna de Projeto = {dados.Pressao_Interna_de_Projeto} MPa," +
								   Environment.NewLine +
								   $"Diâmetro Interno = {dados.Diametro_Interno} mm," +
								   Environment.NewLine +
								   $"Máxima Tensão Admissível = 157 MPa," +
								   Environment.NewLine +
								   $"Coeficiente de Eficiência de Solda = {dados.Eficiencia_de_Junta_do_Costado}," +
								   Environment.NewLine +
								   $"Sobrespessura de Corrosão = {dados.Sobrespessura_de_Corrosao} mm" +
								   Environment.NewLine +
								   Environment.NewLine +
								   Environment.NewLine +
								   Environment.NewLine +
								   $"Obtivemos os seguintes resultados:" +
								   Environment.NewLine +
								   textoResultadoSemSobrespessuradeCorrosao +
								   Environment.NewLine +
								   textoResultadoComSobrespessuradeCorrosao;
			return textoInformativo;
		}
	}
}