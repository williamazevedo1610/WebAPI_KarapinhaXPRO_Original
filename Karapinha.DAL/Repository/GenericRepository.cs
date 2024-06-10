using K.DAL.Context;
using K.Shared.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.DAL.Repository
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		private readonly KarapinhaContext _karapinhaContext;
		public GenericRepository(KarapinhaContext karapinhaContext)
		{
			_karapinhaContext = karapinhaContext;
		}

		public async Task<bool> Actualizar(T entity)
		{
			_karapinhaContext.Entry(entity).State = EntityState.Modified;
			return await _karapinhaContext.SaveChangesAsync() > 0;
		}

		public async Task<bool> Eliminar(T entity)
		{
			_karapinhaContext.Set<T>().Remove(entity);
			return await _karapinhaContext.SaveChangesAsync() > 0;
		}

		public async Task<List<T>> Listar()
		{
			return await _karapinhaContext.Set<T>().ToListAsync();
		}

		public async Task<T> ListarPorId(int id)
		{
			return await _karapinhaContext.Set<T>().FindAsync(id);
		}

		public async Task<bool> Salvar(T entity)
		{
			await _karapinhaContext.Set<T>().AddAsync(entity);
			return await _karapinhaContext.SaveChangesAsync() > 0;
		}
	}
}
