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
	public class ServicoRepository : GenericRepository<Servico>, IServicoRepository
	{
		public ServicoRepository(KarapinhaContext karapinhaContext) : base(karapinhaContext)
		{
		}
	}
}
