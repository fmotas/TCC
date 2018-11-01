using Dimensionamento.Cálculos;
using Dimensionamento.Entities;
using Dimensionamento.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using System;

namespace Dimensionamento.Controllers
{
	public class DimensionarController : Controller
	{
		private readonly IOptions<DbConfig> _dbConfig;

		public DimensionarController(IOptions<DbConfig> dbConfig)
		{
			_dbConfig = dbConfig;
		}

		[HttpGet]
		public IActionResult DadosDeProjeto()
		{
			ViewBag.Fluidos = new SelectList
				(
					new Fluidos(_dbConfig).getFluidos(),
					"Text",
					"Value"
				);

			ViewBag.Materiais = new SelectList
				(
					new Models.Materiais(_dbConfig).getMateriais(),
					"Text",
					"Value"
				);

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
			var resultadoGrupodePotencialdeRisco = CalculosGerais.getGrupoPotencialdeRisco(dados);
			var resultadoClassedeFluido = CalculosGerais.getClassedeFluido(dados);
			var resultadoCategoriadeFluido = CalculosGerais.getCategoriadoVaso(dados);

			var textoResultadoSemSobrespessuradeCorrosao =
				$"{resultadoSemSobrespessuradeCorrosao}mm sem sobrespessura de corrosão.";
			var textoResultadoComSobrespessuradeCorrosao =
				$"{resultadoComSobrespessuradeCorrosao}mm com sobrespessura de corrosão.";

			var textoResultadoGrupodePotencialdeRisco = $"O vaso que está sendo dimensionado neste trabalho, é classificado na Categoria {resultadoCategoriadeFluido}, grupo {resultadoGrupodePotencialdeRisco} e classe {resultadoClassedeFluido}";

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
								   textoResultadoGrupodePotencialdeRisco +
								   Environment.NewLine +
								   textoResultadoSemSobrespessuradeCorrosao +
								   Environment.NewLine +
								   textoResultadoComSobrespessuradeCorrosao;
			return textoInformativo;
		}
	}
}