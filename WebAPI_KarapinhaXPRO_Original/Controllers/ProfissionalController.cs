using K.DTO;
using K.Shared.IService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebAPI_KarapinhaXPRO_Original.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProfissionalController : ControllerBase
	{
		private readonly IProfissionalService _profissionalService;

		public ProfissionalController(IProfissionalService profissionalService)
		{
			_profissionalService = profissionalService;
		}

		[HttpGet]
		public async Task<IActionResult> ListarProfissionais()
		{
			return Ok(await _profissionalService.ListarTodos());
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> ListarProfissionalPorID(int id)
		{
			var profissional = await _profissionalService.ListarPorId(id);
			if (profissional == null)
			{
				return NotFound();
			}
			return Ok(profissional);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> EliminarProfissional(int id)
		{
			var resultado = await _profissionalService.Eliminar(id);
			if (!resultado)
			{
				return NotFound();
			}
			return Ok();
		}

		[HttpPost]
		public async Task<IActionResult> Salvar(ProfissionalSalvarDTO profissional)
		{
			var resultado = await _profissionalService.Salvar(profissional);
			if (!resultado)
			{
				return BadRequest("Não foi possível salvar o profissional.");
			}
			return Ok();
		}

		[HttpPut]
		public async Task<IActionResult> ActualizarProfissional(ProfissionalActualizarDTO profissional)
		{
			var resultado = await _profissionalService.Actualizar(profissional);
			if (!resultado)
			{
				return NotFound("Profissional não encontrado para atualização.");
			}
			return Ok();
		}
	}
}
