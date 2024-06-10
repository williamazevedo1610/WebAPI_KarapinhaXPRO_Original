using K.DTO;
using K.Shared.IRepository;
using K.Shared.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_KarapinhaXPRO_Original.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriaController : ControllerBase
	{
		private readonly ICategoriaService _categoriaService;

		public CategoriaController(ICategoriaService categoriaService)
		{
			_categoriaService = categoriaService;
		}

		[HttpGet]
		public async Task<IActionResult> ListarCategorias()
		{
			return Ok(await _categoriaService.ListarTodos());
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> ListarCategoriaPorID(int id)
		{
			return Ok(await _categoriaService.ListarPorId(id));
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> EliminarCategoria(int id)
		{
			return Ok(await _categoriaService.Eliminar(id));
		}

		[HttpPost]
		public async Task<IActionResult> Salvar(CategoriaSalvarDTO categ)
		{
			return Ok(await _categoriaService.Salvar(categ));
		}

		[HttpPut]
		public async Task<IActionResult> ActualizarCategoria(CategoriaActualizarDTO cat)
		{
			return Ok(await _categoriaService.Actualizar(cat));
		}


	}
}
