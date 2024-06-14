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
	public class ProfissionalRepository : GenericRepository<Profissional>, IProfissionalRepository
	{
		public ProfissionalRepository(KarapinhaContext context) : base(context)
		{
		}
	}
