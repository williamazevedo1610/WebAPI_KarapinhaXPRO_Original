using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.Shared.IRepository
{
	public interface IGenericRepository<T>
	{
		Task<T> ListarPorId(int id);
		Task<bool> Salvar(T entity);
		Task<bool> Eliminar(T entity);
		Task<bool> Actualizar(T entity);
		Task<List<T>> Listar();
	}
}
