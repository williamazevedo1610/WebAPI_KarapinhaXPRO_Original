using K.DTO;
using K.Shared.IService;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_KarapinhaXPRO_Original.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServicoController : ControllerBase
	{
		private readonly IServicoService _servicoService;

		public ServicoController(IServicoService servicoService)
		{
			_servicoService = servicoService;
		}

		[HttpGet]
		public async Task<IActionResult> ListarServicos()
		{
			return Ok(await _servicoService.ListarTodos());
		}

		[HttpGet("{idServico}")]
		public async Task<IActionResult> ListarServicosPorID(int idServico)
		{
			var servico = await _servicoService.ListarPorId(idServico);
			if (servico == null)
			{
				return NotFound();
			}
			return Ok(servico);
		}

		[HttpDelete("{idServico}")]
		public async Task<IActionResult> EliminarServico(int idServico)
		{
			var resultado = await _servicoService.Eliminar(idServico);
			if (!resultado)
			{
				return NotFound();
			}
			return Ok();
		}

		[HttpPost]
		public async Task<IActionResult> Salvar(ServicoSalvarDTO serv)
		{
			var resultado = await _servicoService.Salvar(serv);
			if (!resultado)
			{
				return BadRequest("Não foi possível salvar o serviço.");
			}
			return Ok();
		}

		[HttpPut]
		public async Task<IActionResult> ActualizarServico(ServicoActualizarDTO serv)
		{
			var resultado = await _servicoService.Actualizar(serv);
			if (!resultado)
			{
				return NotFound("Serviço não encontrado para atualização.");
			}
			return Ok();
		}
	}
}
