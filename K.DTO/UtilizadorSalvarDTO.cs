using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.DTO
{
	public class UtilizadorSalvarDTO
	{

			public string Nome { get; set; }
			public string? Email { get; set; }
			public int? telefone { get; set; }
			public string? Fotografia { get; set; }
			public string? BilheteIden { get; set; }
			public string? Username { get; set; }
			public string? PasswordHash { get; set; }
			public int? PerfilID { get; set; }
			public bool Activar { get; set; }
			public bool Status { get; set; }
		

	}
}
