using K.DTO;
using K.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.Shared.IService
{
	public interface IServicoService
	{
		Task<Servico> ListarPorId(int id);
		Task<List<Servico>> ListarTodos();
		Task<bool> Actualizar(ServicoActualizarDTO servicoActualizarDTO);
		Task<bool> Salvar(ServicoSalvarDTO servicoSalvarDTO);
		Task<bool> Eliminar(int id);
	}
}
