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
	public class UtilizadorService : IUtilizadorService
	{
		private readonly IUtilizadorRepository _utilizadorRepository;

		public UtilizadorService(IUtilizadorRepository utilizadorRepository)
		{
			_utilizadorRepository = utilizadorRepository;
		}

		public async Task<bool> Actualizar(UtilizadorActualizarDTO utilizadorActualizarDTO)
		{
			var utilizador = await _utilizadorRepository.ListarPorId(utilizadorActualizarDTO.id);
			if (utilizador != null)
			{
				utilizador.Nome = utilizadorActualizarDTO.Nome;
				utilizador.Email = utilizadorActualizarDTO.Email;
				utilizador.telefone = utilizadorActualizarDTO.telefone;
				utilizador.Fotografia = utilizadorActualizarDTO.Fotografia;
				utilizador.BilheteIden = utilizadorActualizarDTO.BilheteIden;
				utilizador.Username = utilizadorActualizarDTO.Username;
				utilizador.PasswordHash = utilizadorActualizarDTO.PasswordHash;
				utilizador.PerfilID = utilizadorActualizarDTO.PerfilID;
				utilizador.Activar = utilizadorActualizarDTO.Activar;
				utilizador.Status = utilizadorActualizarDTO.Status;
				return await _utilizadorRepository.Actualizar(utilizador);
			}
			return false;
		}

		public async Task<bool> Eliminar(int id)
		{
			var utilizador = await _utilizadorRepository.ListarPorId(id);
			if (utilizador != null)
			{
				return await _utilizadorRepository.Eliminar(utilizador);
			}
			return false;
		}

		public async Task<Utilizador> ListarPorId(int id)
		{
			return await _utilizadorRepository.ListarPorId(id);
		}

		public async Task<bool> Salvar(UtilizadorSalvarDTO utilizadorSalvarDTO)
		{
			var utilizador = new Utilizador
			{
				Nome = utilizadorSalvarDTO.Nome,
				Email = utilizadorSalvarDTO.Email,
				telefone = utilizadorSalvarDTO.telefone,
				Fotografia = utilizadorSalvarDTO.Fotografia,
				BilheteIden = utilizadorSalvarDTO.BilheteIden,
				Username = utilizadorSalvarDTO.Username,
				PasswordHash = utilizadorSalvarDTO.PasswordHash,
				PerfilID = utilizadorSalvarDTO.PerfilID,
				Activar = utilizadorSalvarDTO.Activar,
				Status = utilizadorSalvarDTO.Status
			};
			return await _utilizadorRepository.Salvar(utilizador);
		}

		public async Task<List<Utilizador>> ListarTodos()
		{
			return await _utilizadorRepository.Listar();
		}
		
	}

}
