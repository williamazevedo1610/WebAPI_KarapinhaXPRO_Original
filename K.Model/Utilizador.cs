using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.Model
{
	public class Utilizador
	{
		[Key]
		public int id { get; set; }
		[Required]
		public String ?Nome { get; set; }
		public String ?Email {  get; set; }
		public int ? telefone { get; set; }
		public string ? Fotografia { get; set; }
		public String ? BilheteIden {  get; set; }
		public String ? Username {  get; set; }
		public String ? PasswordHash { get; set; }
		public int ? PerfilID {get; set; }
		[ForeignKey(nameof(PerfilID))]
		public Perfil ?perfil { get; set; }
		public bool Activar { get; set; }
		public bool Status { get; set; }

		
	}
}
