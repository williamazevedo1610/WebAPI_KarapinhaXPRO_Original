using K.DAL.Context;
using K.Model;
using K.Shared.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.DAL.Repository
{
	public class CategoriaRepository : GenericRepository<Categoria>, ICategoriaRepository
	{
		public CategoriaRepository(KarapinhaContext karapinhaContext) : base(karapinhaContext)
		{
			
		}
	}
}
