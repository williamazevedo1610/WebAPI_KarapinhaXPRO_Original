using K.DTO;
using K.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.Shared.IService
{
	public interface ICategoriaService
	{
		Task<Categoria> ListarPorId(int id);
		Task<List<Categoria>> ListarTodos();
		Task<bool> Actualizar(CategoriaActualizarDTO categoriaActualizarDTO);
		Task<bool> Salvar(CategoriaSalvarDTO categoriaSalvarDTO);
		Task<bool> Eliminar(int id);
	}
}
