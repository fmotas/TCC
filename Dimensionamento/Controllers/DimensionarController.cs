﻿using Dimensionamento.Cálculos;
using Dimensionamento.Entities;
using Dimensionamento.Entities.Costado;
using Dimensionamento.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using System.Diagnostics;

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
			ViewBag.Fluido = new SelectList
				(
					new Fluidos(_dbConfig).getFluidos(),
					"Text",
					"Value"
				);

			ViewBag.MateriaisDotCascos_e_Tampos = new SelectList
				(
					new Models.Materiais(_dbConfig).GetSpecificProductFormMateriais(
						"Plate                                             "),
					"Text",
					"Value",
					"SA-516                                            Gr.70                                                "
				);
			ViewBag.MateriaisDotBocal_de_Entrada_de_Fluido = new SelectList
				(
					new Models.Materiais(_dbConfig).GetSpecificProductFormsMateriais(
						"Forgings                                          ",
						"Smls. pipe                                        "),
					"Text",
					"Value",
					"SA-105                                            "
				);
			ViewBag.MateriaisDotBocal_de_Saida_de_Gas = new SelectList
				(
					new Models.Materiais(_dbConfig).GetSpecificProductFormsMateriais(
						"Forgings                                          ",
						"Smls. pipe                                        "),
					"Text",
					"Value",
					"SA-105                                            "
				);
			ViewBag.MateriaisDotBocal_de_Valvula_de_Seguranca = new SelectList
				(
					new Models.Materiais(_dbConfig).GetSpecificProductFormsMateriais(
						"Forgings                                          ",
						"Smls. pipe                                        "),
					"Text",
					"Value",
					"SA-105                                            "
				);
			ViewBag.MateriaisDotBocal_de_Saida_de_Agua = new SelectList
				(
					new Models.Materiais(_dbConfig).GetSpecificProductFormsMateriais(
						"Forgings                                          ",
						"Smls. pipe                                        "),
					"Text",
					"Value",
					"SA-106                                            Gr.B                                                 "
				);
			ViewBag.MateriaisDotBocal_de_Saida_de_Oleo = new SelectList
				(
					new Models.Materiais(_dbConfig).GetSpecificProductFormsMateriais(
						"Forgings                                          ",
						"Smls. pipe                                        "),
					"Text",
					"Value",
					"SA-106                                            Gr.B                                                 "
				);
			ViewBag.MateriaisDotDreno = new SelectList
				(
					new Models.Materiais(_dbConfig).GetSpecificProductFormsMateriais(
						"Forgings                                          ",
						"Smls. pipe                                        "),
					"Text",
					"Value",
					"SA-106                                            Gr.B                                                 "
				);
			ViewBag.MateriaisDotRespiradouro = new SelectList
				(
					new Models.Materiais(_dbConfig).GetSpecificProductFormsMateriais(
						"Forgings                                          ",
						"Smls. pipe                                        "),
					"Text",
					"Value",
					"SA-106                                            Gr.B                                                 "
				);
			ViewBag.MateriaisDotBocas_de_Visita = new SelectList
				(
					new Models.Materiais(_dbConfig).GetSpecificProductFormsMateriais(
						"Forgings                                          ",
						"Smls. pipe                                        "),
					"Text",
					"Value",
					"SA-105                                            "
				);


			return View();
		}

		[HttpGet]
		public IActionResult Contact()
		{
			return View();
		}

		[HttpPost]
		public IActionResult DadosDeProjeto(DadosDeProjeto dados, string MateriaisDotCascos_e_Tampos, string Fluido)
		{
			dados.Materiais = new Entities.Materiais
			{
				Cascos_e_Tampos = MateriaisDotCascos_e_Tampos
			};

			dados.Fluido = Fluido;

			var fullView = BuildInfo(dados);

			ViewData["fullView"] = fullView;

			return View("DadosFullView", fullView);
		}

		public static DadosFullView BuildInfo(DadosDeProjeto dados)
		{
			var material = dados.Materiais.Cascos_e_Tampos;
			var temperaturaDeProjeto = dados.Temperatura_de_Projeto;
			var parte = "Cascos e Tampos";

			dados.Maxima_Tensao_Admissivel = CalculosGerais.GetTensaoMaximaAdmissivel(parte, temperaturaDeProjeto, material);
			var inputs = new DadosInputs(dados);
			var outputs = new DadosOutputs(dados);

			var fullView = new DadosFullView(inputs, outputs);

			return fullView;
		}

		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}