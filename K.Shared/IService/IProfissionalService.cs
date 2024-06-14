using K.DTO;
using K.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.Shared.IService
{
	public interface IProfissionalService
	{
		Task<Profissional> ListarPorId(int id);
		Task<List<Profissional>> ListarTodos();
		Task<bool> Actualizar(ProfissionalActualizarDTO profissionalActualizarDTO);
		Task<bool> Salvar(ProfissionalSalvarDTO profissionalSalvarDTO);
		Task<bool> Eliminar(int id);
	}
}
