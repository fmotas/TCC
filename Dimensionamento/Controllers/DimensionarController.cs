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

		[HttpGet]
		public IActionResult Contact()
		{
			return View();
		}

		[HttpPost]
		public IActionResult DadosDeProjeto(DadosDeProjeto dados, string Materiais)
		{
			dados.Materiais = new Entities.Materiais();
			dados.Materiais.Cascos_e_Tampos = Materiais;

			var fullView = BuildInfo(dados);

			ViewData["fullView"] = fullView;

			return View("CostadoFullView", fullView);
		}

		public static CostadoFullView BuildInfo(DadosDeProjeto dados)
		{
			var inputs = new CostadoInputs(dados);
			var outputs = new CostadoOutputs(dados);

			var fullView = new CostadoFullView(inputs, outputs);

			return fullView;
		}

		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}