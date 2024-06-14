using K.DAL.Context;
using K.Model;
using K.Shared.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace K.DAL.Repository
{
	public class UtilizadorRepository : GenericRepository<Utilizador>, IUtilizadorRepository
	{
		public UtilizadorRepository(KarapinhaContext context) : base(context)
		{
		}
	}
}
