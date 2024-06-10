using K.DTO;
using K.Model;
using K.Shared.IRepository;
using K.Shared.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.Service
{
	public class CategoriaService :ICategoriaService
	{
		private readonly ICategoriaRepository _categoriaRepository;

		public CategoriaService(ICategoriaRepository categoriaRepository)
		{
			_categoriaRepository = categoriaRepository;
		}

		public async Task<bool> Actualizar(CategoriaActualizarDTO categoriaActualizarDTO)
		{
			var categoria = await _categoriaRepository.ListarPorId(categoriaActualizarDTO.ID);
			if (categoria != null)
			{
				categoria.Descricao = categoriaActualizarDTO.Descricao;
				return await _categoriaRepository.Actualizar(categoria);
			}
			return false;
		}

		public async Task<bool> Eliminar(int id)
		{
			var categoria = await _categoriaRepository.ListarPorId(id);
			if(categoria != null)
			{
				return await _categoriaRepository.Eliminar(categoria);
			}
			return false;
			
		}

		public async Task<Categoria> ListarPorId(int id)
		{
			return await _categoriaRepository.ListarPorId(id);
		}

		public async Task<List<Categoria>> ListarTodos()
		{
			return await _categoriaRepository.Listar();
		}

		public async Task<bool> Salvar(CategoriaSalvarDTO categoriaSalvarDTO)
		{
			var categoria = new Categoria
			{
				Descricao = categoriaSalvarDTO.Descricao,
			};
			return await _categoriaRepository.Salvar(categoria);
		}
	}
}
