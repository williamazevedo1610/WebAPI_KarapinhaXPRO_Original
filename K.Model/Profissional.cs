using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.Model
{
	public class Profissional
	{
		[Key]
		public int Id { get; set; }
		public String Nome { get; set; }
		public String Email { get; set; }
		public int telefone { get; set; }
		public string Fotografia { get; set; }
		public String? BilheteIden { get; set; }
		public int ServicoID {  get; set; }
		[ForeignKey(nameof(ServicoID))]
		public Servico Servico { get; set; }
	}
}
