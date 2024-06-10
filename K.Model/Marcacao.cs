using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.Model
{
	public class Marcacao
	{
		[Key]
		public int Id { get; set; }
		public DateTime DataRegisto { get; set; }
		public double TotalPagar {  get; set; }
		public bool Status {  get; set; }
		public int ?Perfil { get; set; }
		public int ? UtilizadorID {  get; set; }
		[ForeignKey(nameof(UtilizadorID))]
		public Utilizador ?User { get; set; }


	}
}
