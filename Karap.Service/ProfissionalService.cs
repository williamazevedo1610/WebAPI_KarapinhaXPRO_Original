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
	public class ProfissionalService : IProfissionalService
	{
		private readonly IProfissionalRepository _profissionalRepository;

		public ProfissionalService(IProfissionalRepository profissionalRepository)
		{
			_profissionalRepository = profissionalRepository;
		}

		public async Task<bool> Actualizar(ProfissionalActualizarDTO profissionalActualizarDTO)
		{
			var profissional = await _profissionalRepository.ListarPorId(profissionalActualizarDTO.Id);
			if (profissional != null)
			{
				profissional.Nome = profissionalActualizarDTO.Nome;
				profissional.Email = profissionalActualizarDTO.Email;
				profissional.telefone = profissionalActualizarDTO.telefone;
				profissional.Fotografia = profissionalActualizarDTO.Fotografia;
				profissional.BilheteIden = profissionalActualizarDTO.BilheteIden;
				profissional.ServicoID = profissionalActualizarDTO.ServicoID;
				return await _profissionalRepository.Actualizar(profissional);
			}
			return false;
		}

		public async Task<bool> Eliminar(int id)
		{
			var profissional = await _profissionalRepository.ListarPorId(id);
			if (profissional != null)
			{
				return await _profissionalRepository.Eliminar(profissional);
			}
			return false;
		}

		public async Task<Profissional> ListarPorId(int id)
		{
			return await _profissionalRepository.ListarPorId(id);
		}

		public async Task<bool> Salvar(ProfissionalSalvarDTO profissionalSalvarDTO)
		{
			var profissional = new Profissional
			{
				Nome = profissionalSalvarDTO.Nome,
				Email = profissionalSalvarDTO.Email,
				telefone = profissionalSalvarDTO.telefone,
				Fotografia = profissionalSalvarDTO.Fotografia,
				BilheteIden = profissionalSalvarDTO.BilheteIden,
				ServicoID = profissionalSalvarDTO.ServicoID
			};
			return await _profissionalRepository.Salvar(profissional);
		}

		public async Task<List<Profissional>> ListarTodos()
		{
			return await _profissionalRepository.Listar();
		}
	}
}
