using K.DTO;
using K.Shared.IService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebAPI_KarapinhaXPRO_Original.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UtilizadorController : ControllerBase
	{
		private readonly IUtilizadorService _utilizadorService;

		public UtilizadorController(IUtilizadorService utilizadorService)
		{
			_utilizadorService = utilizadorService;
		}

		[HttpGet]
		public async Task<IActionResult> ListarUtilizadores()
		{
			return Ok(await _utilizadorService.ListarTodos());
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> ListarUtilizadorPorID(int id)
		{
			var utilizador = await _utilizadorService.ListarPorId(id);
			if (utilizador == null)
			{
				return NotFound();
			}
			return Ok(utilizador);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> EliminarUtilizador(int id)
		{
			var resultado = await _utilizadorService.Eliminar(id);
			if (!resultado)
			{
				return NotFound();
			}
			return Ok();
		}

		[HttpPost]
		public async Task<IActionResult> Salvar(UtilizadorSalvarDTO utilizador)
		{
			var resultado = await _utilizadorService.Salvar(utilizador);
			if (!resultado)
			{
				return BadRequest("Não foi possível salvar o utilizador.");
			}
			return Ok();
		}

		[HttpPut]
		public async Task<IActionResult> ActualizarUtilizador(UtilizadorActualizarDTO utilizador)
		{
			var resultado = await _utilizadorService.Actualizar(utilizador);
			if (!resultado)
			{
				return NotFound("Utilizador não encontrado para atualização.");
			}
			return Ok();
		}
	}
}
