using K.DTO;
using K.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.Shared.IService
{
	public interface IUtilizadorService
	{
		Task<Utilizador> ListarPorId(int id);
		Task<List<Utilizador>> ListarTodos();
		Task<bool> Actualizar(UtilizadorActualizarDTO utilizadorActualizarDTO);
		Task<bool> Salvar(UtilizadorSalvarDTO utilizadorSalvarDTO);
		Task<bool> Eliminar(int id);

	}
}
