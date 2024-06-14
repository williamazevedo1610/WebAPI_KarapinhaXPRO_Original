using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.DTO
{
	public class ProfissionalSalvarDTO
	{
		public string Nome { get; set; }
		public string Email { get; set; }
		public int telefone { get; set; }
		public string Fotografia { get; set; }
		public string? BilheteIden { get; set; }
		public int ServicoID { get; set; }
	}

}
