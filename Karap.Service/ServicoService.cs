using K.DAL.Repository;
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
	public class ServicoService : IServicoService
	{
		private readonly IServicoRepository _servicoRepository;

		public ServicoService(IServicoRepository servicoRepository)
		{
			_servicoRepository = servicoRepository;
		}

		public async Task<bool> Actualizar(ServicoActualizarDTO servicoActualizarDTO)
		{
			var servico = await _servicoRepository.ListarPorId(servicoActualizarDTO.Id);
			if (servico != null)
			{
				servico.Descricao = servicoActualizarDTO.Descricao;
				servico.Preco = servicoActualizarDTO.Preco;
				servico.CategoriaID = servicoActualizarDTO.CategoriaID;
				return await _servicoRepository.Actualizar(servico);
			}
			return false;
		}

		public async Task<bool> Eliminar(int id)
		{
			var servico = await _servicoRepository.ListarPorId(id);
			if (servico != null)
			{
				return await _servicoRepository.Eliminar(servico);
			}
			return false;
		}

		public async Task<Servico> ListarPorId(int id)
		{
			return await _servicoRepository.ListarPorId(id);
		}

		public async Task<bool> Salvar(ServicoSalvarDTO servicoSalvarDTO)
		{
			var servico = new Servico
			{
				Descricao = servicoSalvarDTO.Descricao,
				Preco = servicoSalvarDTO.Preco,
				CategoriaID = servicoSalvarDTO.CategoriaID
			};
			return await _servicoRepository.Salvar(servico);
		}

		public async Task<List<Servico>> ListarTodos()
		{
			return await _servicoRepository.Listar();
		}
	}
}
